using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uchot.Model
{
    public class Auditorium
    {
        public int id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public Auditorium(int id, string name, string code)
        {
            this.id = id;
            this.name = name;
            this.code = code;
        }
    }
}
