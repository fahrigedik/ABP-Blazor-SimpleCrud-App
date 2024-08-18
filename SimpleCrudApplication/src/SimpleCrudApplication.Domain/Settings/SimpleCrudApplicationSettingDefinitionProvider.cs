using Volo.Abp.Settings;

namespace SimpleCrudApplication.Settings;

public class SimpleCrudApplicationSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(SimpleCrudApplicationSettings.MySetting1));
    }
}
