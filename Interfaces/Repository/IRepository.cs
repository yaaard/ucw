using System.Collections.Generic;

namespace Repository
{
    public interface IRepository<T> where T : class
    {
        /// <returns></returns>
        List<T> GetList();

        /// <param name="id"></param>
        /// <returns></returns>
        T GetItem(int id);

        void Create(T item); 
        void Update(T item); 
        void Delete(int id); 
    }

}
