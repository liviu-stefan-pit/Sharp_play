using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_cs.Delegates
{
    public delegate string OperationDelegate(string command);

    public delegate void OperationDelegateMulticast(string name);
}
