#nullable disable
namespace NinjaMobile.Data
{
    public class MenuItem
    {
        public string Title { get; set; }
        public string NormalIcon { get; set; }
        public string ActiveIcon { get; set; }
        public Action Action { get; set; }
    }
}
