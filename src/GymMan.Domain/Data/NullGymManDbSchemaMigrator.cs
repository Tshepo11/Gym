using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace GymMan.Data;

/* This is used if database provider does't define
 * IGymManDbSchemaMigrator implementation.
 */
public class NullGymManDbSchemaMigrator : IGymManDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
