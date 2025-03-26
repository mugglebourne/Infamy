//using ;
using Infamy.ServiceDefaults.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Infamy.ServiceDefaults.Models
{
    public class Tool: ITool
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int Mastery { get; set; }
    }
}
