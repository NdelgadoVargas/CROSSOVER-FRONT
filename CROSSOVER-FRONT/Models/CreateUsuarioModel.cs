using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CROSSOVER_FRONT.Models
{
    public class CreateUsuarioModel
    {
        public class obj
        {
            public string name { get; set; }
            public string email { get; set; }
            public string password { get; set; }
        }

        public class ENTR_Header
        {
            public int code { get; set; }
            public string message { get; set; }
            public ENTR_Body data { get; set; }
        }

        public class ENTR_Body
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Token { get; set; }
        }

    }
}