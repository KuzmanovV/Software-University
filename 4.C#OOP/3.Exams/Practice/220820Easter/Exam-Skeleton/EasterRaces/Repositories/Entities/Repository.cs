using System.Collections.Generic;
using System.Linq;
using EasterRaces.Repositories.Contracts;

namespace EasterRaces.Repositories.Entities
{
    public class Repository<T> : IRepository<T>
    {
        private List<T> list;

        public void Add(T model)
        {
            list.Add(model);
        }
        public bool Remove(T model)
        {
            return list.Remove(model);
        }
        public T GetByName(string name)
        {
            return list.FirstOrDefault(t => t.GetType().Name==name);
        }
        public System.Collections.Generic.IReadOnlyCollection<T> GetAll()
        {
            return list;
        }
    }
}