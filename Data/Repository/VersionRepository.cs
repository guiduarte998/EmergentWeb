using Data.Context;
using Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class VersionRepository : IVersionRepository
    {
        private readonly VersionContext _context;

        public VersionRepository(VersionContext context) 
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<SoftwareModelDb> GetAll()
        {
            return _context.SoftwareModel.ToList();
        }
    }
}
