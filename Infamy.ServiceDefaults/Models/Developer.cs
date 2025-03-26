using Infamy.ServiceDefaults.Models;

namespace Infamy.ServiceDefaults.Models
{
    public class Developer: IDeveloper
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? HP { get; set; }
        public int? XP { get; set; }
        public int? Level { get; set; }
    }
}
