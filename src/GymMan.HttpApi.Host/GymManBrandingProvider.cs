using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace GymMan;

[Dependency(ReplaceServices = true)]
public class GymManBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "GymMan";
}
