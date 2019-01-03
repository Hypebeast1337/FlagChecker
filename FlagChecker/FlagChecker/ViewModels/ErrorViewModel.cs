namespace FlagChecker.Models
{
    public class ErrorViewModel
    {
        public enum Type
        {
            Default,
            Link
        }

        public Type ErrorType { get; set; }

    }
}