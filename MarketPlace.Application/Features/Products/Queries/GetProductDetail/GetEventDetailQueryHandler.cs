﻿using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Application.DTOs;
using MarketPlace.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Products.Queries.GetProductDetail

{
    public class GetEventDetailQueryHandler : IRequestHandler<GetEventDetailQuery, ProductDetailViewModel>
    {
        private readonly IAsyncRepository<Product> _eventRepository;
        private readonly IAsyncRepository<Currency> _currencyRepository;
        private readonly IAsyncRepository<Country> _countryRepository;
        private readonly IAsyncRepository<ProductCategory> _productCategoryRepository;
        private readonly IMapper _mapper;

        public GetEventDetailQueryHandler(IMapper mapper, IAsyncRepository<Product> productRepository,
                                                        IAsyncRepository<Currency> currencyRepository,
                                                        IAsyncRepository<Country> countryRepository,
                                                        IAsyncRepository<ProductCategory> productCategoryRepository)
        {
            _mapper = mapper;
            _eventRepository = productRepository;
            _currencyRepository = currencyRepository;
            _countryRepository = countryRepository;
            _productCategoryRepository = productCategoryRepository;
        }

        public async Task<ProductDetailViewModel> Handle(GetEventDetailQuery request, CancellationToken cancellationToken)
        {
            var @product = await _eventRepository.GetByIdAsync(request.Id);
            var productDetailDto = _mapper.Map<ProductDetailViewModel>(product);

            var currency = await _currencyRepository.GetByIdAsync((Guid)@product.CurrencyId);
            var country = await _countryRepository.GetByIdAsync((Guid)@product.ManufacturingCountryId);
            var productCategory = await _productCategoryRepository.GetByIdAsync((Guid)@product.ProductCategoryId);

            productDetailDto.Currency = _mapper.Map<CurrencyDTO>(currency);
            productDetailDto.ManufacturingCountry = _mapper.Map<CountryDTO>(country);
            productDetailDto.ProductCategory = _mapper.Map<ProductCategoryDTO>(productCategory);

            return productDetailDto;
        }
    }
}
