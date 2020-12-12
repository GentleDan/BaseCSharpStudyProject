using System.Collections.Generic;

namespace laba_kamyshov
{
    public class TrackedVehicleComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x is TrackedVehicle && y is TrackedVehicle)
            {
                return ComparerTrackedVehicle((TrackedVehicle)x, (TrackedVehicle)y);
            }
            if (x is Excavator && y is Excavator)
            {
                return ComparerExcavator((Excavator)x, (Excavator)y);
            }
            if (x is TrackedVehicle && y is Excavator)
            {
                return -1;
            }
            if (x is Excavator && y is TrackedVehicle)
            {
                return -1;
            }
            return 0;
        }

        private int ComparerTrackedVehicle(TrackedVehicle x, TrackedVehicle y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }
        private int ComparerExcavator(Excavator x, Excavator y)
        {
            int res = ComparerTrackedVehicle(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.Flasher != y.Flasher)
            {
                return x.Flasher.CompareTo(y.Flasher);
            }
            if (x.Ladle != y.Ladle)
            {
                return x.Ladle.CompareTo(y.Ladle);
            }
            if (x.Stand != y.Stand)
            {
                return x.Stand.CompareTo(y.Stand);
            }
            return 0;
        }
    }
}
