using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APILearning11.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NamesController : ControllerBase
    {
        static List<string> names = new();
        
        [HttpPost]

        public void Addname(string name)
        {
            names.Add(name);
            Console.WriteLine($"{name} name added succesfully");
        }

        [HttpGet("[action]")]

        public List<string> Getname()
        {
            return names;

        }

        [HttpGet("[action]")]

        public string GetRandomName()
        {
            Random random = new ();
            int randomIndex = random.Next(names.Count);
            return names[randomIndex];

        }
        

    }
}
