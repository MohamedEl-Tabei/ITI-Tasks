using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApi.BL;

public class Token
{
    public string JWT { get; set; }
    public DateTime Expire { get; set; }
}
