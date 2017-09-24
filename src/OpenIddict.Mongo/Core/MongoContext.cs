using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenIddict.Mongo.Core
{
    internal class MongoContext : IMongoContext
    {
        private IMongoClient _client { get; set; }
        private IMongoDatabase _database { get; set; }

        public MongoContext(IMongoConnection conn)
        {
            this.Create(conn);
        }
        private void Create(IMongoConnection mongoConn)
        {
            var url = new MongoUrl(mongoConn.connectionString());
            this._client = new MongoClient(url.Url);
            this._database = this._client.GetDatabase(url.DatabaseName);
        }

        IMongoDatabase IMongoContext.Database
        {
            get
            {
                return _database;
            }
        }
    }
}
