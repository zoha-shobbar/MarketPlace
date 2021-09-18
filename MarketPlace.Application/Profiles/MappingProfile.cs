﻿using AutoMapper;
using MarketPlace.Application.DTOs;
using MarketPlace.Application.Features.Comments.Queries.GetCommentDetail;
using MarketPlace.Application.Features.Countries.Queries.GetCountriesList;
using MarketPlace.Application.Features.Currencies.Queries.GetCurrenciesList;
using MarketPlace.Application.Features.Currencies.Queries.GetCurrencyDetail;
using MarketPlace.Application.Features.Currencies.Queries.GetCurrencyListWithCountries;
using MarketPlace.Application.Features.Galleries.Queries.GetGalleriesList;
using MarketPlace.Application.Features.Galleries.Queries.GetGalleryDetail;
using MarketPlace.Application.Features.Menues.Queries.GetMenuDetail;
using MarketPlace.Application.Features.Menues.Queries.GetMenueByType;
using MarketPlace.Application.Features.Menues.Queries.GetMenuList;
using MarketPlace.Application.Features.PageAndPosts.Queries.GetPageAndPostDetail;
using MarketPlace.Application.Features.Products.Queries.GetProductDetail;
using MarketPlace.Application.Features.Products.Queries.GetProductList;
using MarketPlace.Domain.Entities;

namespace MarketPlace.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Comment, CommentDetailViewModel>().ReverseMap();


            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<Country, CountryListViewModel>().ReverseMap();

            CreateMap<Currency, CurrencyDTO>().ReverseMap();
            CreateMap<Currency, CurrenciesListViewModel>().ReverseMap();
            CreateMap<Currency, CurrencyDetailViewModel>().ReverseMap();
            CreateMap<Currency, CurrencyCountryListViewModel>().ReverseMap();

            CreateMap<Gallery, GalleryDTO>().ReverseMap();
            CreateMap<Gallery, GalleryDetailViewModel>().ReverseMap();
            CreateMap<Gallery, GalleryListViewModel>().ReverseMap();

            CreateMap<Menu, MenuDetailViewModel>().ReverseMap();
            CreateMap<Menu, MenuListViewModel>().ReverseMap();
            CreateMap<Menu, MenuByTypeViewModel>().ReverseMap();

            CreateMap<PageAndPost, PageAndPostDTO>().ReverseMap();
            CreateMap<PageAndPost, PageAndPostDetailViewModel>().ReverseMap();

            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Product, ProductDetailViewModel>().ReverseMap();
            CreateMap<Product, ProductsListViewModel>().ReverseMap();

        }
    }
}