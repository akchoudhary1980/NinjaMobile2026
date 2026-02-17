using Microsoft.AspNetCore.Components;
using MudBlazor;
using NinjaMobile.Data;
using NinjaMobile.DtoModel;
using NinjaMobile.Models;
using NinjaMobile.Services;
#nullable disable

namespace NinjaMobile.Components.Pages
{
    public partial class Home
    {
        [Inject] private MobileFrontendService MFrontend { get; set; }

        public FrontEndDto fs = new FrontEndDto();
        public PackageViewerData pv = new PackageViewerData();

        public List<SliderModel> sliderList = new();
        public List<VideoSliderModel> videoSliderList = new();
        public List<TestimonialsModel> testimonialsList = new();
        public List<SelectItems> occasionList = new();
        // action button 
        List<SpeedDialItem> Actions;
        protected override async Task OnInitializedAsync()
        {

            fs = await MFrontend.GetFontEndData();

            sliderList = fs.SliderList;
            videoSliderList = fs.VideoSliderList;
            testimonialsList = fs.TestimonialsList;
            occasionList = fs.OccasionList;

            pv.BoxPackageList = fs.BoxPackageList;
            pv.BoxPackageTransList = fs.BoxPackageTransList;

            pv.FeastPackageList = fs.FeastPackageList;
            pv.FeastPackageTransList = fs.FeastPackageTransList;

            pv.BentoPackageList = fs.BentoPackageList;
            pv.BentoPackageTransList = fs.BentoPackageTransList;

            pv.AdOnServiceList = fs.AdOnServiceList;
            pv.OccasionList = fs.OccasionList;



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
