using System.Threading.Tasks;

namespace GymMan.Data;

public interface IGymManDbSchemaMigrator
{
    Task MigrateAsync();
}
