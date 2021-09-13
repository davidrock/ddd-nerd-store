using AutoMapper;
using NerdStore.Catalog.Application.ViewModels;
using NerdStore.Catalog.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Catalog.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ProductViewModel, Product>()
                .ConstructUsing(x =>
                new Product(
                    x.Name, x.Description, x.Active, x.Price, x.CategoryId, x.Image,
                    new Dimensions(x.Height, x.Width, x.Depth), x.CreatedAt));

            CreateMap<CategoryViewModel, Category>()
                .ConstructUsing(x => new Category(x.Name, x.Code));
        }


    }
}
