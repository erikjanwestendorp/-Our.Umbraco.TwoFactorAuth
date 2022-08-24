using System.Runtime.Serialization;

namespace Our.Umbraco.TwoFactorAuth.Models;

[DataContract]
internal class TwoFactorAuthInfo
{
    [DataMember(Name = "qrCodeSetupImageUrl")]
    public string QrCodeSetupImageUrl { get; set; }

    [DataMember(Name = "secret")]
    public string Secret { get; set; }
}