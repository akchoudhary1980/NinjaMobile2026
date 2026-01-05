using MudBlazor;
#nullable disable
namespace NinjaMobile.Data
{
    public class SpeedDialItem
    {
        public string Icon { get; set; }
        public string Label { get; set; }
        public Color Color { get; set; }
        public Action Action { get; set; }
    }
}
