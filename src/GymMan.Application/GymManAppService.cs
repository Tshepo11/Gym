using GymMan.Localization;
using Volo.Abp.Application.Services;

namespace GymMan;

/* Inherit your application services from this class.
 */
public abstract class GymManAppService : ApplicationService
{
    protected GymManAppService()
    {
        LocalizationResource = typeof(GymManResource);
    }
}
