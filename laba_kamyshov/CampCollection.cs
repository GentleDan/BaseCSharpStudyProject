using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace laba_kamyshov
{
    public class CampCollection
    {
        private readonly Dictionary<string, Camp<Vehicle>> campStages;
        public List<string> Keys => campStages.Keys.ToList();

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly char separator = ':';

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

        public void SaveData(string filename)
        {
            using (StreamWriter streamWriter = new StreamWriter
            (filename, false, System.Text.Encoding.Default))
            {
                streamWriter.WriteLine("CampCollection");
                foreach (var level in campStages)
                {
                    streamWriter.WriteLine("Camp" + separator + level.Key);

                    ITransport truck;
                    for (int i = 0; (truck = level.Value.GetNext(i)) != null; i++)
                    {
                        if (truck.GetType().Name == "TrackedVehicle")
                        {
                            streamWriter.Write("TrackedVehicle" + separator);
                        }
                        else if (truck.GetType().Name == "Excavator")
                        {
                            streamWriter.Write("Excavator" + separator);
                        }
                        streamWriter.WriteLine(truck);
                    }
                }
            }
        }

        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            using (StreamReader streamReader = new StreamReader
            (filename, System.Text.Encoding.Default))
            {
                if (streamReader.ReadLine().Contains("CampCollection"))
                {
                    campStages.Clear();
                }
                else
                {
                    throw new FormatException("Неверный формат файла");
                }
                Vehicle transport = null;
                string key = string.Empty;
                string line;
                for (int i = 0; (line = streamReader.ReadLine()) != null; i++)
                {
                    if (line.Contains("Camp"))
                    {
                        key = line.Split(separator)[1];
                        campStages.Add(key, new Camp<Vehicle>(pictureWidth, pictureHeight));
                    }
                    else if (line.Contains(separator))
                    {
                        if (line.Contains("TrackedVehicle"))
                        {
                            transport = new TrackedVehicle(line.Split(separator)[1]);
                        }
                        else if (line.Contains("Excavator"))
                        {
                            transport = new Excavator(line.Split(separator)[1]);
                        }
                        if (!(campStages[key] + transport))
                        {
                            throw new TypeLoadException("Не удалось загрузить автомобиль на парковку");
                        }
                    }
                }
            }
        }
    }
}
