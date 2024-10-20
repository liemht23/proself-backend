using Volo.Abp.Settings;

namespace ProSelf.Settings;

public class ProSelfSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ProSelfSettings.MySetting1));
    }
}
