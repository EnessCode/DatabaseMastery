using AutoMapper;
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
		}
	}
}
