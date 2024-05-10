using Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interface
{
    public interface IVersionRepository
    {
        IEnumerable<SoftwareModelDb> GetAll();
    }
}
