using System;

namespace laba_kamyshov
{
    public class ParkingOverflowException : Exception
    {
        public ParkingOverflowException() : base("На парковке нет свободных мест")
        {

        }
    }
}
