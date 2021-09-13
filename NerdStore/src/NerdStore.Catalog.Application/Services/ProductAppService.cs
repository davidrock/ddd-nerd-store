using AutoMapper;
using NerdStore.Catalog.Application.ViewModels;
using NerdStore.Catalog.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Catalog.Application.Services
{
    public class ProductAppService : IProductAppService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        private readonly IStockService _stockService;

        public ProductAppService(IProductRepository productRepository, IMapper mapper, IStockService stockService)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _stockService = stockService;
        }

        public async Task AddProduct(ProductViewModel productViewModel)
        {
            var product = _mapper.Map<Product>(productViewModel);
            _productRepository.Add(product);

            await _productRepository.UnitOfWork.Commit();
        }

        public async Task UpdateProduct(ProductViewModel productViewModel)
        {
            var product = _mapper.Map<Product>(productViewModel);
            _productRepository.Update(product);

            await _productRepository.UnitOfWork.Commit();
        }

        public async Task<ProductViewModel> CreditStock(Guid id, int quantity)
        {
            if (!_stockService.CreditStock(id, quantity).Result)
            {
                throw new CannotUnloadAppDomainException("Cannot credit stock");
            }

            return _mapper.Map<ProductViewModel>(await _productRepository.GetById(id));
        }

        public async Task<ProductViewModel> DebitStock(Guid id, int quantity)
        {
            if (!_stockService.DebitStock(id, quantity).Result)
            {
                throw new CannotUnloadAppDomainException("Cannot debit stock");
            }

            return _mapper.Map<ProductViewModel>(await _productRepository.GetById(id));
        }

        public async Task<IEnumerable<ProductViewModel>> GetAll()
        {
            return _mapper.Map<IEnumerable<ProductViewModel>>(await _productRepository.GetAll());
        }

        public async Task<IEnumerable<ProductViewModel>> GetByCategoryCode(int code)
        {
            return _mapper.Map<IEnumerable<ProductViewModel>>(await _productRepository.GetByCategoryCode(code));
        }

        public async Task<ProductViewModel> GetById(Guid id)
        {
            return _mapper.Map<IEnumerable<ProductViewModel>>(await _productRepository.GetById(id);
        }

        public async Task<IEnumerable<ProductViewModel>> GetCategories()
        {
            return _mapper.Map<IEnumerable<ProductViewModel>>(await _productRepository.GetCategories());
        }

        public void Dispose()
        {
            _productRepository?.Dispose();
            _stockService?.Dispose();
        }

    }
}
