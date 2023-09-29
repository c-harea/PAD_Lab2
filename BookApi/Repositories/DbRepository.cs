using BookApi.Settings;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using Util.Models;

namespace BookApi.Repositories
{
    public class DbRepository<T> : IDbRepository<T> where T : DbDocument
    {
        private readonly IMongoDatabase _db;
        private readonly IMongoCollection<T> _collection;

        public DbRepository(IDbSettings db)
        {
            _db = new MongoClient(db.ConnectionString).GetDatabase(db.DatabaseName);

            string tableName = typeof(T).Name.ToLower();
            _collection = _db.GetCollection<T>(tableName);
        }
        public void DeleteRecord(Guid id)
        {
            
        }

        public List<T> GetAllRecords()
        {
            var records = _collection.Find(new BsonDocument()).ToList();
            return records;
        }

        public T GetRecordById(Guid id)
        {
            throw new NotImplementedException();
        }

        public T InsertRecord(T record)
        {
            throw new NotImplementedException();
        }

        public void UpsertRecord(T record)
        {
            throw new NotImplementedException();
        }
    }
}
