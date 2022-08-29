using Umbraco.Cms.Core.Manifest;

namespace Our.Umbraco.TwoFactorAuth.Assets;

internal class ManifestFilter : IManifestFilter
{
    public void Filter(List<PackageManifest> manifests)
    {
        manifests.Add(new PackageManifest
        {
            PackageName = "Our.Umbraco.TwoFactorAuth",
            Scripts = new[]
            {
                "~/App_Plugins/Our.Umbraco.TwoFactorAuth/two-factor-authentication.controller.js"
            }, 
            Version = "1.0.0"
        });
    }
}