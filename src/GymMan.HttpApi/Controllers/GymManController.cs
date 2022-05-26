using GymMan.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace GymMan.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class GymManController : AbpControllerBase
{
    protected GymManController()
    {
        LocalizationResource = typeof(GymManResource);
    }
}
