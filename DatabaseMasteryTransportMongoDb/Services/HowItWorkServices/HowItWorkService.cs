using AutoMapper;
using DatabaseMasteryTransportMongoDb.Dtos.HowItWorkDtos;
using DatabaseMasteryTransportMongoDb.Entities;
using DatabaseMasteryTransportMongoDb.Settings;
using MongoDB.Driver;

namespace DatabaseMasteryTransportMongoDb.Services.HowItWorkServices
{
	public class HowItWorkService : IHowItWorkService
	{
		private readonly IMongoCollection<HowItWork> _HowItWorkCollection;
		private readonly IMapper _mapper;

		public HowItWorkService(IMapper mapper, IDatabaseSettings _databaseSettings)
		{
			var client = new MongoClient(_databaseSettings.ConnectionString);
			var database = client.GetDatabase(_databaseSettings.DatabaseName);
			_HowItWorkCollection = database.GetCollection<HowItWork>(_databaseSettings.HowItWorkCollectionName);
			_mapper = mapper;
		}

		public async Task CreateHowItWorkAsync(CreateHowItWorkDto createHowItWorkDto)
		{
			var value = _mapper.Map<HowItWork>(createHowItWorkDto);
			await _HowItWorkCollection.InsertOneAsync(value);
		}

		public async Task DeleteHowItWorkAsync(string id)
		{
			await _HowItWorkCollection.DeleteOneAsync(x => x.HowItWorkId == id);
		}

		public async Task<List<ResultHowItWorkDto>> GetAllHowItWorkAsync()
		{
			var values = await _HowItWorkCollection.Find(x => true).ToListAsync();
			return _mapper.Map<List<ResultHowItWorkDto>>(values);
		}

		public async Task<GetHowItWorkByIdDto> GetHowItWorkByIdAsync(string id)
		{
			var value = await _HowItWorkCollection.Find(x => x.HowItWorkId == id).FirstOrDefaultAsync();
			return _mapper.Map<GetHowItWorkByIdDto>(value);
		}

		public async Task UpdateHowItWorkAsync(UpdateHowItWorkDto updateHowItWorkDto)
		{
			var value = _mapper.Map<HowItWork>(updateHowItWorkDto);
			await _HowItWorkCollection.FindOneAndReplaceAsync(x => x.HowItWorkId == updateHowItWorkDto.HowItWorkId, value);
		}
	}
}
