namespace MeetingsUsers.WpApi.Services
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll();

        Task Insert(T person);

        Task<T> Get(int id);

        Task Update(T person);

        Task Delete(T person);
    }
}