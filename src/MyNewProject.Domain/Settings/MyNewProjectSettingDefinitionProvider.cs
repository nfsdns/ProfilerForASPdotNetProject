using Volo.Abp.Settings;

namespace MyNewProject.Settings;

public class MyNewProjectSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MyNewProjectSettings.MySetting1));
    }
}
