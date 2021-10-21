using Umut.Debugging;

namespace Umut
{
    public class UmutConsts
    {
        public const string LocalizationSourceName = "Umut";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "f37b11d0678947de8344e0fc87e246f9";
    }
}
