using CRE.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRE.Interfaces
{
    public interface IEthicsEvaluatorServices
    {
        Task<EthicsEvaluator> GetEthicsEvaluatorByIdAsync(int id); // Fetch a single evaluator by id
        Task<IEnumerable<EthicsEvaluator>> GetAllEthicsEvaluatorsAsync(); // Fetch all evaluators
    }
}
