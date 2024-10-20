using ProSelf.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ProSelf.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ProSelfController : AbpControllerBase
{
    protected ProSelfController()
    {
        LocalizationResource = typeof(ProSelfResource);
    }
}
