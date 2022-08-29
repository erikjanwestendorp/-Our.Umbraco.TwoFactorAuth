namespace Our.Umbraco.TwoFactorAuth.Options;

internal class TwoFactorAuthSettings
{
    public string ApplicationName { get; set; } = Constants.Application.Name; 
    public bool ShowEnvironment { get; set; } = true;
}