using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{

    // generic constraint -> generic kisit
    // class : referans tip
    // IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    // new() : new'lenebilir olmali. IEntity new'lenemez cunku interface'dir.
    public interface IEntityRepository<T> where T : class, IEntity, new()
        // Design pattern -> Generic Repository Design Pattern.

    {
        //filtre yapilarak getirme islemi de yapilabilir.
        // filtrelemeyi Expression yapar.
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        // filtre verilmezse tum datayi getirir. filter = null yapisi default degerdir.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
