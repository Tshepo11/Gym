using Volo.Abp.Modularity;

namespace GymMan;

[DependsOn(
    typeof(GymManApplicationModule),
    typeof(GymManDomainTestModule)
    )]
public class GymManApplicationTestModule : AbpModule
{

}
