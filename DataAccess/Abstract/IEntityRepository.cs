using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public   interface IEntityRepository<T> where T : class,IEntity,new()
    {
        //new(): newlenebilir olmalı ama interface new lenemeyeceği için i entitity i yazmaayız referansa
        //class: referans tip olabilir
        //generic constraint --- generic kısıtlama 
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T  entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
