using MongoDB.Bson.Serialization;

namespace CampManager.Server.Serializers;

public class DateOnlyBsonProvider : IBsonSerializationProvider
{
    public IBsonSerializer GetSerializer(Type type)
    {
        if (type == typeof(DateOnly))
        {
            return new DateOnlyBsonSerializer();
        }

        return null;
    }
}
