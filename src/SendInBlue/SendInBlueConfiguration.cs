using System.Configuration;

namespace SendInBlue
{
    public static class SendInBlueConfiguration
    {
        private static string _apiKey;

        internal static string GetApiKey()
        {
            if (string.IsNullOrEmpty(_apiKey))
                _apiKey = ConfigurationManager.AppSettings["SendInBlueApiKey"];

            return _apiKey;
        }

        public static void SetApiKey(string newApiKey)
        {
            _apiKey = newApiKey;
        }
    }
}
