using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APILearning11.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Orders : ControllerBase
    {
        static List<string> orderList = new();

        [HttpPost]

        public void AddOrder(string order)
        { 
            
            orderList.Add(order);
            Console.WriteLine($"{order} order added succesfully");
        }

        [HttpGet]

        public List<string> Get()
        {
            
            return orderList;
        }


        [HttpDelete]

        public void Delete(string order)
        {
          orderList.Remove(order);
          Console.WriteLine($"{order} order deleted succesfully");

        }

        
        [HttpPut]
        public void Update(string oldOrder, string newOrder) //Orta Boy Filtre, Orta Boy Filtre Kahve
        {
            int index = orderList.IndexOf(oldOrder);
            orderList[index] = newOrder;
            Console.WriteLine($"{oldOrder} order updated to {newOrder} successfully.");
        }
    }


}
