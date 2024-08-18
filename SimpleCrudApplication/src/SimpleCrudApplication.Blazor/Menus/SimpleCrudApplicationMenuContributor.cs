using System.Threading.Tasks;
using SimpleCrudApplication.Localization;
using SimpleCrudApplication.Permissions;
using SimpleCrudApplication.MultiTenancy;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.UI.Navigation;
using Volo.Abp.SettingManagement.Blazor.Menus;
using Volo.Abp.TenantManagement.Blazor.Navigation;
using Volo.Abp.Identity.Blazor;

namespace SimpleCrudApplication.Blazor.Menus;

public class SimpleCrudApplicationMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var l = context.GetLocalizer<SimpleCrudApplicationResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                SimpleCrudApplicationMenus.Home,
                l["Menu:Home"],
                "/",
                icon: "fas fa-home",
                order: 1
            )
        );

        context.Menu.AddItem(new ApplicationMenuItem("SimpleCrudApplication.Movies", l["Movies"], url: "/movies"));

        //Administration
        var administration = context.Menu.GetAdministration();
        administration.Order = 4;
    
        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenus.GroupName, 3);

        return Task.CompletedTask;
    }
}
