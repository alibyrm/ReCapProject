using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint: generic kısıt
    //class:  referans tip . class sınıfları yazılabilir.
    //IEntity:IEntity olabilir veya onu implemente eden bir  nesne olabilir.
    //new(): new lenebilr olmalı yani IEntity olamaz çakallık yaptık:)
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //filtreleme için gerekliolan metod Expression<Func<T,bool>> bu metotdu kullanırız.
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //filtrelemeyi isteğe göre yapabilirz filtre vermeyedebiliriz.
        T Get(Expression<Func<T,bool>> filter); //filtreleme zorunlu.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
       
    }
}
