using DomainModel;
using Repository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL.Repository
{
    public class MessageRepositorySQL : IRepository<Message>
    {
        private readonly zContext db;

        public MessageRepositorySQL(zContext dbcontext)
        {
            db = dbcontext;
        }

        public List<Message> GetList()
        {
            return db.zcontextMessage.ToList();
        }

        public Message GetItem(int id)
        {
            return db.zcontextMessage.Find(id);
        }

        public void Create(Message item)
        {
            db.zcontextMessage.Add(item);
        }

        public void Update(Message item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var message = db.zcontextMessage.Find(id);
            if (message != null)
            {
                db.zcontextMessage.Remove(message);
            }
        }
    }
}
