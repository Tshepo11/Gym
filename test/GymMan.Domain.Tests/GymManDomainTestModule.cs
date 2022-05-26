using GymMan.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace GymMan;

[DependsOn(
    typeof(GymManEntityFrameworkCoreTestModule)
    )]
public class GymManDomainTestModule : AbpModule
{

}
