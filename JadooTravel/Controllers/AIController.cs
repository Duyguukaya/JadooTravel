using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;

namespace JadooTravelCore.Controllers
{
    [AllowAnonymous]
    public class AiController : Controller
    {
        private readonly string myapikey = "";

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetPlaces(string city)
        {
            if (string.IsNullOrEmpty(city))
                return Json(new { success = false, error = "Lütfen bir şehir giriniz!" });

            string prompt = $"Sen bir seyahat rehberisin. '{city}' şehrinde gezilecek en önemli 10 yeri listele. Her yer için başlık ve kısa açıklama ekle. Format: 'Başlık - Açıklama'";

            try
            {
                using var client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {myapikey}");

                var requestBody = new
                {
                    model = "gpt-4o-mini",
                    messages = new[] { new { role = "user", content = prompt } },
                    max_tokens = 1000
                };

                var content = new StringContent(JsonSerializer.Serialize(requestBody), Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://api.openai.com/v1/chat/completions", content);

                if (!response.IsSuccessStatusCode)
                {
                    var errorText = await response.Content.ReadAsStringAsync();
                    return Json(new { success = false, error = errorText });
                }

                string responseString = await response.Content.ReadAsStringAsync();
                using var doc = JsonDocument.Parse(responseString);
                var root = doc.RootElement;

                var results = new List<string>();
                if (root.TryGetProperty("choices", out JsonElement choices) && choices.GetArrayLength() > 0)
                {
                    var message = choices[0].GetProperty("message").GetProperty("content").GetString();
                    results = message.Split('\n', StringSplitOptions.RemoveEmptyEntries)
                                     .Select(x => x.Trim())
                                     .Take(10)
                                     .ToList();
                }

                return Json(new { success = true, city, results });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, error = ex.Message });
            }
        }
    }
}
