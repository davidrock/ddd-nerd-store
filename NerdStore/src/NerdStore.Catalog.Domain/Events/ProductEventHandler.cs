using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NerdStore.Catalog.Domain.Events
{
    public class ProductEventHandler : INotificationHandler<ProductLowStockEvent>
    {

        private readonly IProductRepository _productRepository;

        public ProductEventHandler(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public async Task Handle(ProductLowStockEvent notification, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetById(notification.AggregateId);


        }
    }
}
