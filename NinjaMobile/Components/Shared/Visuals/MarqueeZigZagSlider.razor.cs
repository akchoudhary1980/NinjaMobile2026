using Microsoft.AspNetCore.Components;
using NinjaMobile.Models;
#nullable disable warnings
namespace NinjaMobile.Components.Shared.Visuals
{
    public partial class MarqueeZigZagSlider
    {
        [Parameter] 
        public List<SliderModel> SliderList { get; set; }
    }
}
