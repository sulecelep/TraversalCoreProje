using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericUowDal<T> where T : class 
    {
        void Insert(T t);
        void Update(T t);
        void Delete(T t);
        void MultiUpdate(List<T> t); //aynı anda birden fazla kaydı güncellemeye yarar
        T GetByID(int id);
    }
    
}
