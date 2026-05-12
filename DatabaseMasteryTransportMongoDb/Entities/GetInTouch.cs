using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DatabaseMasteryTransportMongoDb.Entities
{
	public class GetInTouch
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string GetInTouchId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string ImageUrl { get; set; }
		public string SubTitle1 { get; set; }
		public string SubDescription1 { get; set; }
		public string SubTitle2 { get; set; }
		public string SubDescription2 { get; set; }
	}
}
