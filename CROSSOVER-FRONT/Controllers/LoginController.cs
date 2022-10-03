using RestSharp;
using System;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using CROSSOVER_FRONT.Models;

namespace CROSSOVER_FRONT.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ingresarSesion(IniciarSesionModel.data data)
        {
            try
            {
                string url = "http://localhost:55858/api/iniciosesion";

                var client = new RestClient(url);
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");

                JObject body = new JObject();
                body.Add("email", data.email);
                body.Add("password", data.password);
                body.Add("token", data.token);

                request.AddParameter("application/json", body, ParameterType.RequestBody);

                IRestResponse response = client.Execute(request);

                var resp = JsonConvert.DeserializeObject<IniciarSesionModel.ENTR_INICIAR>(response.Content);

                return Json(new {respuesta="ok",resp });
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
                return Json(e.Message);
            }
        }


    }
}