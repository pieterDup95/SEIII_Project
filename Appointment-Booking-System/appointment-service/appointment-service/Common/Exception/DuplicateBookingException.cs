namespace appointment_service.Common.Exception
{
    public class DuplicateBookingException : System.Exception
    {
        public object Existing { get; }

        public DuplicateBookingException(object existing)
        {
            Existing = existing;
        }
    }
}
