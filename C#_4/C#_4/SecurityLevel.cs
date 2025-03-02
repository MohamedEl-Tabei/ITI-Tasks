using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__4
{
    [Flags]
    internal enum SecurityLevel
    {
        //guest, Developer, secretary and DBA.
        guest=1, Developer=2, secretary=4, DBA=8,
    }
}