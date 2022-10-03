using CROSSOVER_FRONT.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CROSSOVER_FRONT.Controllers
{
    public class CrearCuentaController : Controller
    {
        // GET: CrearCuenta
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GenerarCuenta(CreateUsuarioModel.obj data)
        {
            try
            {
                string url = "http://localhost:55858/api/create";

                var client = new RestClient(url);
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");

                JObject body = new JObject();
                body.Add("name", data.name);
                body.Add("email", data.email);
                body.Add("password", data.password);

                request.AddParameter("application/json", body, ParameterType.RequestBody);

                IRestResponse response = client.Execute(request);

                var resp = JsonConvert.DeserializeObject<CreateUsuarioModel.ENTR_Header>(response.Content);

                return Json(new { respuesta = "ok", resp });
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
                return Json(e.Message);
            }
        }
    }
}