using GymMan.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace GymMan.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(GymManEntityFrameworkCoreModule),
    typeof(GymManApplicationContractsModule)
    )]
public class GymManDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
