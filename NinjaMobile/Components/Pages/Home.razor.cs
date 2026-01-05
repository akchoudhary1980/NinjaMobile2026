using MudBlazor;
using NinjaMobile.Data;
#nullable disable

namespace NinjaMobile.Components.Pages
{
    public partial class Home
    {
        List<SpeedDialItem> Actions;

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            Actions = new()
            {
                new SpeedDialItem { Icon = Icons.Custom.Brands.WhatsApp, Color = Color.Success, Label = "WhatsApp", Action = () => OnClick("WhatsApp") },
                new SpeedDialItem { Icon = Icons.Material.Filled.Phone, Color = Color.Primary, Label = "Phone", Action = () => OnClick("Phone") }
            };
        }

        void OnClick(string name)
        {
            Console.WriteLine($"{name} clicked");
        }

    }
}
