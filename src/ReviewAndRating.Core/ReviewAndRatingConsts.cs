using ReviewAndRating.Debugging;

namespace ReviewAndRating
{
    public class ReviewAndRatingConsts
    {
        public const string LocalizationSourceName = "ReviewAndRating";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "c66735e53e7c481ba783faf93c352c9f";
    }
}
