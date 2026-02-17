using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using NinjaMobile.Models;
#nullable disable warnings

namespace NinjaMobile.Components.Shared.Visuals
{
    public partial class MarqueeSlider
    {
        [Parameter]
        public List<TestimonialsModel> TestimonialsList { get; set; }

        [Inject]
        private IJSRuntime JS { get; set; }

        int activeIndex = 0;
        DotInteropHelper dotHelper;
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender && TestimonialsList != null && TestimonialsList.Count > 0)
            {
                dotHelper = new DotInteropHelper(this);
                await JS.InvokeVoidAsync("TrackMarquee", "#clientMarquee.marquee-content", TestimonialsList.Count, DotInteropHelper.CreateRef(dotHelper), nameof(DotInteropHelper.ReceiveIndex));
            }
        }

        [JSInvokable]
        public void UpdateActiveIndex(int index)
        {
            activeIndex = index;
            InvokeAsync(StateHasChanged);
        }

        public class DotInteropHelper
        {
            private readonly MarqueeSlider _component;

            public DotInteropHelper(MarqueeSlider component)
            {
                _component = component;
            }

            [JSInvokable]
            public void ReceiveIndex(int index)
            {
                _component.UpdateActiveIndex(index);
            }
            public static DotNetObjectReference<DotInteropHelper> CreateRef(DotInteropHelper helper) => DotNetObjectReference.Create(helper);
        }
    }
}
