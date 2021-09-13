using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Catalog.Domain
{
    public interface IInventoryService : IDisposable
    {
        Task<bool> CreditStock(Guid productId, int quantity);
        Task<bool> DebitStock(Guid productId, int quantity);
    }
}
