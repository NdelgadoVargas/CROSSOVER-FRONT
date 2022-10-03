using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CROSSOVER_FRONT.Models
{
    public class IniciarSesionModel
    {
        public class dataSesion
        {
            public string email { get; set; }
            public int password { get; set; }
            public string token { get; set; }

        }

        public class ENTR_Header
        {
            public string id { get; set; }
            public int code { get; set; }
            public string message { get; set; }
            public ENTR_Body data { get; set; }

        }

        public class ENTR_Body
        {
            public string id { get; set; }
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Token { get; set; }
        }

    }
}