

using NinjaMobile.Models;

namespace NinjaMobile.Data
{
    public class PackageViewerData
    {
        public List<BoxPackageModel> BoxPackageList { get; set; } = new(); // take 4 
        public List<BoxPackageTransModel> BoxPackageTransList { get; set; } = new(); // take 4  package details 


        public List<FeastPackageModel> FeastPackageList { get; set; } = new(); // take 4 
        public List<FeastPackageTransModel> FeastPackageTransList { get; set; } = new(); // take 4  package details 

        public List<BentoPackageModel> BentoPackageList { get; set; } = new(); // take 4 
        public List<BentoPackageTransModel> BentoPackageTransList { get; set; } = new(); // take 4  package details 

        public List<SelectItems> OccasionList { get; set; } = new();  

        public List<AdOnServiceModel> AdOnServiceList { get; set; } = new(); // take 4 
    }
}
