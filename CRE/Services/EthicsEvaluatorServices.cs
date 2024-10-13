using CRE.Data;
using CRE.Interfaces;
using CRE.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRE.Services
{
    public class EthicsEvaluatorServices : IEthicsEvaluatorServices
    {
        private readonly ApplicationDbContext _context;

        public EthicsEvaluatorServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<EthicsEvaluator> GetEthicsEvaluatorByIdAsync(int id)
        {
            return await _context.EthicsEvaluator
                .Include(e => e.Faculty)
                .ThenInclude(f => f.User)
                .FirstOrDefaultAsync(e => e.ethicsEvaluatorId == id); // Ensure your field name matches the DB schema
        }

        public async Task<IEnumerable<EthicsEvaluator>> GetAllEthicsEvaluatorsAsync()
        {
            return await _context.EthicsEvaluator
                .Include(e => e.Faculty)
                .ThenInclude(f => f.User)
                .ToListAsync();
        }
    }
}
