using Volo.Abp.Settings;

namespace GymMan.Settings;

public class GymManSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(GymManSettings.MySetting1));
    }
}
