using Mongo.Application.Infrascructure;
using Mongo.Application.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Text;

namespace Mongo.Application;

internal class Program
{
    static void Main(string[] args)
    {
        var dataContext = new DataContext();

        dataContext.Users.InsertOne(new User()
        {
            Identifier = new Guid("110689e7-fcd3-45c5-9b2b-d72d85c49f0f").ToString(),
            Name = "Otávio",
            Surname = "Villas Boas"
        });

        var value = dataContext.Users.Find(p => p.Identifier == "110689e7-fcd3-45c5-9b2b-d72d85c49f0f").FirstOrDefault();
        Console.WriteLine(value.Name);
    }
}