using BusinessApplicationProject.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BusinessApplicationProject.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AppDbContext Context;

        public Repository(AppDbContext context)
        {
            Context = context;
        }

        //public T? GetById(int id)
        //{
        //    return Find(x => x.Id == id).FirstOrDefault();
        //}

        public List<T> GetAll()
        {
            var query = AddIncludes(typeof(T), Context.Set<T>());
            return query.ToList();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> condition)
        {
            var query = AddIncludes(typeof(T), Context.Set<T>());
            return query.Where(condition);
        }

        public async Task AddAsync(T entity)
        {
            await Context.Set<T>().AddAsync(entity);
        }

        public void Remove(T entity)
        {
            Context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            Context.Set<T>().Update(entity);
        }

        public IQueryable<T> AddIncludes(Type type, IQueryable<T> query)
        {
            var includes = GetAllNavigationPropertyNames(typeof(T));

            foreach (var propertyName in includes)
            {
                query = query.Include(propertyName);
            }

            return query;
        }

        public List<string> GetAllNavigationPropertyNames(Type type)
        {
            var res = new List<string>();

            switch (type.Name)
            {
                case nameof(Article):
                    res.Add("Group.Parent");
                    break;

                case nameof(ArticleGroup):
                    res.Add("Parent");
                    break;

                case nameof(Customer):
                    res.Add("CustomerAddress");
                    break;

                case nameof(Invoice):
                    res.Add("BillingAddress");
                    res.Add("OrderInformations.CustomerDetails.CustomerAddress");
                    res.Add("OrderInformations.Positions.ArticleDetails.Group.Parent");
                    break;

                case nameof(Order):
                    res.Add("CustomerDetails.CustomerAddress");
                    res.Add("Positions.ArticleDetails.Group.Parent");
                    break;

                case nameof(Position):
                    res.Add("ArticleDetails.Group.Parent");
                    break;

                default:
                    break;
            }

            return res;
        }
    }
}