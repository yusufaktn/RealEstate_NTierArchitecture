using RealEstate.DataAccessLayer.Abstract;
using RealEstate.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        Context context = new Context();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = context.Set<T>();

        }

        public void Delete(T t)
        {
            var deletedEntity = context.Entry(t);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }



        public T GetByID(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public List<T> GetList()
        {
            return _object.ToList();
        }

        public void Insert(T t)
        {
            var adeddEntity = context.Entry(t);
            adeddEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T t)
        {
            var updateEntity = context.Entry(t);
            updateEntity.State = EntityState.Modified;
            context.SaveChanges();

        }
    }
}

//IGenericDAL interface'i CRUD işlemleri için kullanılacak. Bu interface'i implemente eden GenericRepository sınıfı ise bu işlemleri yapacak.
//Yani basitçe IGenericDAL sınıfındaki metotlar burada karşılık bulacak.
//Bunları adım adım sıralarsak diğer interfacerler :1 IGenericDAL :2  GenericRepository:3
