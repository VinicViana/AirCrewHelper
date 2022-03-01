using System.Linq;

namespace AirCrewHelper_Model.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        void insert(T obj);
        T find(int id);
        IQueryable<T> list();
        void remove(T obj);
        void edit(T obj);
    }
}