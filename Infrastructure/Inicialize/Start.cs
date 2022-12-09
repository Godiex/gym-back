using Infrastructure.Context;
using Infrastructure.Inicialize.Entities;

namespace Infrastructure.Inicialize
{
    public class Start
    {
        private readonly PersistenceContext _context;
        public Start(PersistenceContext context)
        {
            _context = context;
        }

        public void Inicializar()
        {
            if (!_context.Plans.Any()) InitializePlan.Inicialize(_context);
        }
    }
}