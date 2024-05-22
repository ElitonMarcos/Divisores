using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Divisores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivisorController : ControllerBase
    {
        [HttpPost]
        public IActionResult Decompor([FromBody] int number)
        {
            if (number <= 0)
            {
                return BadRequest("O número deve ser maior que zero.");
            }

            var result = new
            {
                Number = number,
                Divisores = GetDivisores(number),
                DivisoresPrimos = GetDivisoresPrimos(number)
            };

            return Ok(result);
        }

        private List<int> GetDivisores(int n)
        {
            List<int> divisores = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    divisores.Add(i);
                }
            }
            return divisores;
        }

        private List<int> GetDivisoresPrimos(int n)
        {
            List<int> divisoresPrimos = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0 && Primo(i))
                {
                    divisoresPrimos.Add(i);
                }
            }
            return divisoresPrimos;
        }

        private bool Primo(int n)
        {
            if (n <= 1)
                return false;
            for (int divisor = 2; divisor <= Math.Sqrt(n); divisor++)
            {
                if (n % divisor == 0)
                    return false;
            }
            return true;
        }
    }
}

