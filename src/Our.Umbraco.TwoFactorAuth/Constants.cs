namespace Our.Umbraco.TwoFactorAuth;

internal class Constants
{
    internal static class Application
    {
        public const string Name = "Umbraco Website";
    }

    internal static class Authentication
    {
        public const string AppAuthenticatorProvider = "AppAuthenticator";
        public const string SetupViewPath = "..\\App_Plugins\\Our.Umbraco.TwoFactorAuth\\two-factor-authentication.html";
    }

    internal static class Configuration
    {
        public const string TwoFactorAuth = "Umbraco:TwoFactorAuth";
    }
}