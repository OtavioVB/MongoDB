using Mongo.Application.Models;
using MongoDB.Driver;

namespace Mongo.Application.Infrascructure;

public class DataContext
{
    private IMongoDatabase Database { get; set; }
    private string DatabaseName { get; set; } = "MongoDB";

    public DataContext()
    {
        var mongoClient = new MongoClient("mongodb://localhost:27017");
        Database = mongoClient.GetDatabase(DatabaseName);
    }

    public IMongoCollection<User> Users 
    { 
        get
        {
            return Database.GetCollection<User>("Users");
        }
    }
}
