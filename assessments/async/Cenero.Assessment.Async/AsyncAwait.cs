using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cenero.Assessment.Async.Internal;

namespace Cenero.Assessment.Async;

/// <summary>
/// 
/// </summary>
internal class AsyncAwait
{

    public int LoadCustomer(string name)
    {
        return 0;
    }

    /// <summary>
    /// Given the method below has several hotpath conditions that loads a customer number for the customers name how the method be refactored to:
    /// - Leverage the JIT to reduce memory allocations for the Task
    /// </summary>
    public async Task<int> LoadNumberAsync(string? name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return 0;
        }

        if (name.Contains("Cenero", StringComparison.CurrentCultureIgnoreCase))
        {
            return 0;
        }

        return await StaticMethods.GetCustomerNumber(name);
    }
}
