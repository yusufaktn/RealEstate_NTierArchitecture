using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.DataAccessLayer.Abstract
{
    public interface IGenericDAL<T> where T:class
    {
        void Insert(T t);
        void Update(T t);
        void Delete(T t);
        List<T> GetList();
        T GetByID(Expression<Func<T,bool>>filter);
        List<T> List(Expression<Func<T, bool>> filter);// Şartlı listeleme işlemi.


    }
}

// Diğer Interfaceler bu bu Interface'den miras alacak. Bu sayede CRUD işlemleri için tek bir Interface kullanılacak.
//Bu Interface ise GenericRepository sınıfında implemente edilecek. Bu sayede CRUD işlemleri için tek bir sınıf kullanılacak.