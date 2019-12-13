using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace TodoGraphQL.Data
{
    public class TodoRepository
    {
        private readonly IMongoCollection<Todo> _todos;

        static TodoRepository()
        {
            var conventionPack = new ConventionPack
            {
                new EnumRepresentationConvention(BsonType.String)
            };

            ConventionRegistry.Register(
                "conventions", conventionPack, t => true);
        }

        public TodoRepository(IMongoDatabase db)
        {
            _todos = db.GetCollection<Todo>("todos");
        }

        public async Task<IEnumerable<Todo>> Get()
        {
            return await _todos
                .AsQueryable()
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task Add(Todo todo)
        {
            await _todos
                .InsertOneAsync(todo)
                .ConfigureAwait(false);
        }
    }
}
