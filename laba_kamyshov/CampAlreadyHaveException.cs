using System;

namespace laba_kamyshov
{
    public class CampAlreadyHaveException : Exception
    {
        public CampAlreadyHaveException() : base("На парковке уже есть такой транспорт")
        { }
    }
}
