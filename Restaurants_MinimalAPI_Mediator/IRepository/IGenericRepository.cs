using Restaurants_MinimalAPI_Mediator.Model;
using System.Linq.Expressions;

namespace Restaurants_MinimalAPI_Mediator.IRepository
{
    public interface IGenericRepository<T> where T : class
    {

       
        void Add(T Entity);
        void Remove(T Entity);
        void Remove(int id); // for primary key individual data Remove 
        void RemoveRange(IEnumerable<T> Entity); //multiple Record Delete/Remove
        T Get(int id); // single record Gett Karan Lai
        //IEnumerable<T> GetAll(  // multiple Record gett karan lai
        //    Expression<Func<T, bool>> filter = null,

        //    // Sorting
        //    Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null,

        //    // Multiple Table
        //    string IncludeProperties = null // Catagory Table , CoverType Table for multiple table addition
        //    );

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, string includeProperties = null);
        T FirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string IncludeProperties = null
            );

        public IEnumerable<T> GetAllCountry();

        void update(T Entity);


    }
}
