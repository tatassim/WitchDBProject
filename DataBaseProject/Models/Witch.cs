using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProject.Models
{
    public class Witch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Habitats { get; set; }
        public DateTime Birth { get; set; }
        public DateTime DateDeath { get; set; }
        public Coven Coven { get; set; }
        public Habitat Habitat { get; set; }


        public string HabitatName { get { return Habitat != null ? Habitat.Name : null; } }
        public string CovenName { get { return Coven != null ? Coven.Name : null; } }
    }
}
