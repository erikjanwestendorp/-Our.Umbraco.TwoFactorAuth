namespace Our.Umbraco.TwoFactorAuth;

internal class Constants
{
    public static class Application
    {
        public const string Name = "Umbraco Website";
    }

    public static class Authentication
    {
        public const string AppAuthenticatorProvider = "AppAuthenticator";
        public const string SetupViewPath = "..\\App_Plugins\\Our.Umbraco.TwoFactorAuth\\two-factor-authentication.html";
    }
}