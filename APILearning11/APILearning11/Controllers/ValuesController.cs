using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APILearning11.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        List<string> nameList = new()
        {
            "Sena",
            "Şeyda",
            "Fatima"
        };

        [HttpGet("[action]")]
        public string GetName()
        {
            return nameList[0];

        }


        [HttpGet("[action]")]
        public int GetTempreture()
        {
            return 18;

        }




    }
}
