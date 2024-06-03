using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uchot.Model
{
    public class Equipment
    {
        public int id { get; set; }
        public string name { get; set; }
        public string photo { get; set; }
        public int inventory_number { get; set; }
        public int auditorium_id { get; set; }
        public int responsible_user_id { get; set; }
        public decimal cost { get; set; }
        public int status_id { get; set; }
        public Equipment(int id, string name, string photo, int inventory_number, int auditorium_id, int responsible_user_id, decimal cost, int status_id)
        {
            this.id = id;
            this.name = name;
            this.photo = photo;
            this.inventory_number = inventory_number;
            this.auditorium_id = auditorium_id;
            this.responsible_user_id = responsible_user_id;
            this.cost = cost;
            this.status_id = status_id;
        }
    }
}
