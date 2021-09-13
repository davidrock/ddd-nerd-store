using NerdStore.Catalog.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Catalog.Application.Services
{
    public interface IProductAppService
    {
        Task<IEnumerable<ProductViewModel>> GetByCategoryCode(int codigo);
        Task<ProductViewModel> GetById(Guid id);
        Task<IEnumerable<ProductViewModel>> GetAll();
        Task<IEnumerable<ProductViewModel>> GetCategories();

        Task AddProduct(ProductViewModel productViewModel);
        Task UpdateProduct(ProductViewModel productViewModel);

        Task<ProductViewModel> DebitStock(Guid id, int quantity);
        Task<ProductViewModel> CreditStock(Guid id, int quantity);
    }
}
