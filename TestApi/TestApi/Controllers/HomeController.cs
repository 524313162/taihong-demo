using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        public double Index(int num1, int num2)
        {
            var result = (num1 * 1d) / num2;

            return result;
        }
    }
}
