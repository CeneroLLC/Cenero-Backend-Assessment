using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cenero.Assessment.Async.Internal;
internal class StaticMethods
{

    public static Task<int> GetCustomerNumber(string customerName)
    {
        return Task.FromResult(12);
    }
}
