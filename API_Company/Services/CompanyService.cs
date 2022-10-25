using API_Company.Models;
using API_Company.Utils;
using MongoDB.Driver;

namespace API_Company.Services
{
    public class CompanyService
    {
        private readonly IMongoCollection<Company> _company;

        public CompanyService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _company = database.GetCollection<Company>(settings.CompanyCollectionName);
        }
    }
}
