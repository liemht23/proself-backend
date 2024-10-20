using System;
using System.Collections.Generic;
using System.Text;
using ProSelf.Localization;
using Volo.Abp.Application.Services;

namespace ProSelf;

/* Inherit your application services from this class.
 */
public abstract class ProSelfAppService : ApplicationService
{
    protected ProSelfAppService()
    {
        LocalizationResource = typeof(ProSelfResource);
    }
}
