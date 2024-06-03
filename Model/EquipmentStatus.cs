using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uchot.Model
{
    public class EquipmentStatus
    {
        public int id { get; set; }
        public string name { get; set; }
        public EquipmentStatus(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
