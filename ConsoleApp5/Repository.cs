using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Repository<T> where T : class, IEntity, new()
    {
        private readonly List<T> _items = new List<T>();

        public void Add(T item)
        {
            if (_items.Any(x => x.Id == item.Id))
            {
                throw new InvalidOperationException("Element o tym samym Id już istnieje.");
            }
            _items.Add(item);
        }

        public T GetById(Guid id)
        {
            return _items.FirstOrDefault(x => x.Id == id) ?? throw new KeyNotFoundException("Element nie został znaleziony.");
        }

        public void Update(T item)
        {
            var existingItem = GetById(item.Id);
            if (existingItem == null)
            {
                throw new KeyNotFoundException("Element do aktualizacji nie został znaleziony.");
            }
            _items.Remove(existingItem);
            _items.Add(item);
        }
        public void Remove(Guid id)
        {
            var item = GetById(id);
            _items.Remove(item);
        }

        public List<T> GetAll()
        {
            return new List<T>(_items);
        }

        public List<T> Find(Func<T, bool> predicate)
        {
            return _items.Where(predicate).ToList();
        }
    }
}
