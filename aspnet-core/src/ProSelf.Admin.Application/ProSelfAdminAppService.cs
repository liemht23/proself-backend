using System;
using System.Collections.Generic;
using System.Text;
using ProSelf.Localization;
using Volo.Abp.Application.Services;

namespace ProSelf.Admin;

/* Inherit your application services from this class.
 */
public abstract class ProSelfAdminAppService : ApplicationService
{
    protected ProSelfAdminAppService()
    {
        LocalizationResource = typeof(ProSelfResource);
    }
}
