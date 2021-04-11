using System.Collections.Generic;
using System.Linq;
using AquaShop.Models.Decorations;
using AquaShop.Repositories.Contracts;

namespace AquaShop.Repositories
{
    public class DecorationRepository : IRepository<Decoration>
    {
        private List<Decoration> models;

        public DecorationRepository()
        {
            models = new List<Decoration>();
        }

        public IReadOnlyCollection<Decoration> Models => models.AsReadOnly();
        public void Add(Decoration model)
        {
            models.Add(model);
        }

        public bool Remove(Decoration model)
        {
            return models.Remove(model);
        }

        public Decoration FindByType(string type)
        {
            return models.FirstOrDefault(m => m.GetType().Name == type);
        }
    }
}