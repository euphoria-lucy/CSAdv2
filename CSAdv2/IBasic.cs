using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAdv2_31
{
    internal interface IBasic
    {
        int TestInstanceMethod();
        int TestProperty { get; set; }
    }
}