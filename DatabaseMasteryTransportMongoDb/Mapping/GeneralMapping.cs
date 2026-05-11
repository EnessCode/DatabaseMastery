using AutoMapper;
using DatabaseMasteryTransportMongoDb.Dtos.AboutDtos;
using DatabaseMasteryTransportMongoDb.Dtos.BrandDtos;
using DatabaseMasteryTransportMongoDb.Dtos.OfferDtos;
using DatabaseMasteryTransportMongoDb.Dtos.SliderDtos;
using DatabaseMasteryTransportMongoDb.Entities;

namespace DatabaseMasteryTransportMongoDb.Mapping
{
	public class GeneralMapping : Profile
	{
		public GeneralMapping()
		{
			CreateMap<Slider, ResultSliderDto>().ReverseMap();
			CreateMap<Slider, CreateSliderDto>().ReverseMap();
			CreateMap<Slider, UpdateSliderDto>().ReverseMap();
			CreateMap<Slider, GetSliderByIdDto>().ReverseMap();

			CreateMap<Brand, ResultBrandDto>().ReverseMap();
			CreateMap<Brand, CreateBrandDto>().ReverseMap();
			CreateMap<Brand, UpdateBrandDto>().ReverseMap();
			CreateMap<Brand, GetBrandByIdDto>().ReverseMap();

			CreateMap<Offer, ResultOfferDto>().ReverseMap();
			CreateMap<Offer, CreateOfferDto>().ReverseMap();
			CreateMap<Offer, UpdateOfferDto>().ReverseMap();
			CreateMap<Offer, GetOfferByIdDto>().ReverseMap();

			CreateMap<About, ResultAboutDto>().ReverseMap();
			CreateMap<About, CreateAboutDto>().ReverseMap();
			CreateMap<About, UpdateAboutDto>().ReverseMap();
			CreateMap<About, GetAboutByIdDto>().ReverseMap();
		}
	}
}
