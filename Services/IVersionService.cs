using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IVersionService
    {
        bool IsValidVersion(string version);
        bool IsVersionGreaterThan(string baseVersion, string compareVersion);
    }
}
