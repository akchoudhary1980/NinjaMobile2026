using NinjaMobile.Models;

namespace NinjaMobile.DtoModel
{
    public class FrontEndDto
    {
        // Front Page
        public List<SelectItems> OccasionList { get; set; } = new(); // list
        public List<SliderModel> SliderList { get; set; } = new(); // take active
        public List<VideoSliderModel> VideoSliderList { get; set; } = new(); // take active
        public List<TestimonialsModel> TestimonialsList { get; set; } = new(); // take active


        // Gatherr Box 
        public List<BoxPackageModel> BoxPackageList { get; set; } = new(); // take 4 
        public List<BoxPackageTransModel> BoxPackageTransList { get; set; } = new(); // take 4  package details 

        // Gatherr Feast
        public List<FeastPackageModel> FeastPackageList { get; set; } = new(); // take 4 
        public List<FeastPackageTransModel> FeastPackageTransList { get; set; } = new(); // take 4  package details 

        // Gatherr Bento
        public List<BentoPackageModel> BentoPackageList { get; set; } = new(); // take 4 
        public List<BentoPackageTransModel> BentoPackageTransList { get; set; } = new(); // take 4 

        // Add on Service
        public List<AdOnServiceModel> AdOnServiceList { get; set; } = new(); // take 4 

        
    }
}
