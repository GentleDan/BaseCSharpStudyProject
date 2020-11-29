using System;

namespace laba_kamyshov
{
    public class ParkingNotFoundException : Exception
    {
        public ParkingNotFoundException(int i) : base("Не найден автомобиль по месту " + i)
        {

        }
    }
}
