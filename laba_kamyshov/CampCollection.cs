using System.Collections.Generic;
using System.Linq;

namespace laba_kamyshov
{
    public class CampCollection
    {
        private readonly Dictionary<string, Camp<Vehicle>> campStages;
        public List<string> Keys => campStages.Keys.ToList();

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        public CampCollection(int pictureWidth, int pictureHeight)
        {
            campStages = new Dictionary<string, Camp<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddParking(string name)
        {
            if (campStages.ContainsKey(name))
            {
                return;
            }
            campStages.Add(name, new Camp<Vehicle>(pictureWidth, pictureHeight));
        }

        public void DeleteParking(string name)
        {
            if (campStages.ContainsKey(name))
            {
                campStages.Remove(name);
            }
        }

        public void DeleteParkingInt(int index)
        {
            if (index > -1 && index < campStages.Count)
            {
                campStages.Remove(Keys[index]);
            }
        }

        public Camp<Vehicle> this[string ind]
        {
            get
            {
                if (campStages.ContainsKey(ind))
                {
                    return campStages[ind];
                }
                return null;
            }
        }

    }
}
