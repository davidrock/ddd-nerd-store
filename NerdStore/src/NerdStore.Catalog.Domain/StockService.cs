using NerdStore.Catalog.Domain.Events;
using NerdStore.Core.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Catalog.Domain
{
    public class StockService : IStockService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMediatrHandler _bus;

        public StockService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<bool> CreditStock(Guid productId, int quantity)
        {
            var product = await _productRepository.GetById(productId);

            if (product == null) return false;

            if (!product.CheckStock(quantity)) return false;

            product.CreditStock(quantity);

            _productRepository.Update(product);
            return await _productRepository.UnitOfWork.Commit();
        }

        public async Task<bool> DebitStock(Guid productId, int quantity)
        {
            var product = await _productRepository.GetById(productId);

            if (product == null) return false;

            if (!product.CheckStock(quantity)) return false;

            product.DebitStock(quantity);

            // TODO: use param here
            if (product.Quantity < 10)
            {
                await _bus.PublishEvent(new ProductLowStockEvent(product.Id, product.Quantity));
            }

            _productRepository.Update(product);
            return await _productRepository.UnitOfWork.Commit();
        }

        public void Dispose()
        {
            _productRepository.Dispose();
        }
    }
}
