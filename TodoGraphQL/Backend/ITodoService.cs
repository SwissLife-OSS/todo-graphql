using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend
{
    public interface ITodoService
    {
        IEnumerable<Todo> GetAllAsync();

        Task AddAsync();
    }
}
