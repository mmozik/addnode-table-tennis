using System;
using System.Collections.Generic;
using System.Text;

namespace AddnodeBalkan.TableTennis.Data.Repository
{
    public abstract class BaseRepository<T>
    {
        protected TableTennisContext db;

        public BaseRepository()
        {
            if(db == null)
            {
                db = new TableTennisContext();
            }
        }

        public abstract IEnumerable<T> Get();
        public abstract void Update(T item);
        public abstract void Delete(T item);
        public abstract void Add(T item);
        
    }
}
