using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        /// <summary>
        /// 计算参数结果
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public double Division(int num1, int num2)
        {
            var result = (num1 * 1d) / num2;

            return result;
        }
    }
}
