using System;
using System.Threading.Tasks;

namespace HotelBookSystem.Data
{
    public interface IDataClient
    {
        IEquatable<T> Query<T>();
        Task<Guid> Insert<T>(T document);
        Task CreateDatabase(string name = "BookingSystem");
        Task CreateCollection<T>();
    }
}