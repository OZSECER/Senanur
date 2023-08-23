using MVCWEBUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Evaluation;
using System.Text.Json;
using MVCWEBUI.Models.UrunViewModel;
using System.Text.Json.Nodes;

namespace MVCWEBUI.Controllers
{
    public class UrunController : Controller
    {
        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5270/api");
            var response = await client.GetAsync($"{client.BaseAddress}/Urun/get");
            var json = await response.Content.ReadAsStringAsync();
            var result = string.IsNullOrEmpty(json)? null: JsonObject.Parse(json);
            //var responseRead = await response.Content.ReadAsStringAsync();
            var resultCt = JsonSerializer.Deserialize<UrunIndexViewModel>(/*responseRead*/ result);


           

            return View(resultCt);
        }
    }
}

