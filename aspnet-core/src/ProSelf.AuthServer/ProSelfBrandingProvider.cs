using Microsoft.Extensions.Localization;
using ProSelf.Localization;
using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ProSelf;

[Dependency(ReplaceServices = true)]
public class ProSelfBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<ProSelfResource> _localizer;

    public ProSelfBrandingProvider(IStringLocalizer<ProSelfResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
