using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace APIOperations.Controllers
{
    [Route("api/operations")]
    [ApiController]
    [Produces("application/json")]
    public class OperationsController : Controller
    {
        // POST api/<OperationsController>
        [HttpPost("sum")]
        public IActionResult sum([FromBody] Input input)
        {
            Operations op = new Operations();
            int soma = 0;
            foreach (int element in input.Numbers)
            {
                soma = op.sum(soma, element);
            }

            OperationResult inp = new OperationResult();
            inp.result = soma;


            return Json(inp);
        }

        [HttpPost("average")]

        public IActionResult average([FromBody] Input input)
        {
            Operations op = new Operations();
            int soma = 0;
            foreach (int element in input.Numbers)
            {
                soma = op.sum(soma, element);
            }
            double average = op.divide(soma, input.Numbers.Length);

            OperationResult inp = new OperationResult();
            inp.result = average;

            return Json(inp);

        }

    }

}
