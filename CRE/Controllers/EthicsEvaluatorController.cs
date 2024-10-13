using CRE.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CRE.Controllers
{
    public class EthicsEvaluatorController : Controller
    {
        private readonly IEthicsEvaluatorServices _ethicsEvaluatorServices;

        public EthicsEvaluatorController(IEthicsEvaluatorServices ethicsEvaluatorServices)
        {
            _ethicsEvaluatorServices = ethicsEvaluatorServices;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Dashboard(int id)
        {
            var evaluator = await _ethicsEvaluatorServices.GetEthicsEvaluatorByIdAsync(id);
            if (evaluator == null)
            {
                return NotFound();
            }
            return View(evaluator); // Passing the evaluator to the view
        }

        public IActionResult Evaluation()
        {
            return View();
        }
    }
}
