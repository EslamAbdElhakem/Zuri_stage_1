using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace MyWebApplication.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class Stage_1_Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string name, string track)
        {
            try
            {
                 // Get the current day and UTC time
                var currentDay =  DateTime.Now.ToString("dddd");
                var currentTimeUtc = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");

                // Prepare the response data
                var responseData = new Dictionary<string, string>
                {
                    { "slack_name:", name },
                    { "track:", track },
                    { "current_day:", currentDay },
                    { "utc_time:", currentTimeUtc },
                    { "github_file_url", "https://github.com/EslamAbdElhakem/Zuri_stage_1/edit/main/Controllers/Stage_1_Controller.cs" },
                    { "github_repo_url", "https://github.com/EslamAbdElhakem/Zuri_stage_1" },
                    { "statuscode:", "200" },
                };

                // Return the response as JSON
                return Ok(responseData);
            }
            catch (Exception ex)
            {
                // Handle any exceptions and return an appropriate response
                return StatusCode(500, ex.Message);
            }
        }
    }
}
