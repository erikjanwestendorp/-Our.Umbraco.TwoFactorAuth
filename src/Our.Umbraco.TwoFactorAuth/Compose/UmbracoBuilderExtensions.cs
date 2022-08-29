using Google.Authenticator;
using Microsoft.Extensions.DependencyInjection;
using Our.Umbraco.TwoFactorAuth.Authentication;
using Our.Umbraco.TwoFactorAuth.Options;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Core.Security;
using Umbraco.Cms.Web.BackOffice.Security;
using Umbraco.Extensions;

namespace Our.Umbraco.TwoFactorAuth.Compose;

public static class UmbracoBuilderExtensions
{
    public static IUmbracoBuilder ConfigureTwoFactorAuth(this IUmbracoBuilder builder)
    {
        builder.Services.AddTransient(typeof(TwoFactorAuthenticator));

        var identityBuilder = new BackOfficeIdentityBuilder(builder.Services);
        identityBuilder.AddTwoFactorProvider<UmbracoUserAppAuthenticator>(UmbracoUserAppAuthenticator.Name);

        builder.Services.Configure<TwoFactorLoginViewOptions>(UmbracoUserAppAuthenticator.Name, options =>
        {
            options.SetupViewPath = Constants.Authentication.SetupViewPath;
        });

        builder.Services.AddOptions<TwoFactorAuthSettings>().Bind(builder.Config.GetSection(Constants.Configuration.TwoFactorAuth));

        return builder;
    }
}