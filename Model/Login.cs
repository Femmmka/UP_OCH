﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uchot.Model
{
        public class Login
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Password { get; set; }
            public Login(int Id, string Name, string Password)
            {
                this.Id = Id;
                this.Name = Name;
                this.Password = Password;
            }
        }
    }

