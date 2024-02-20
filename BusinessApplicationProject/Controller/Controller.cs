﻿using BusinessApplicationProject.Model;
using BusinessApplicationProject.Repository;
using System.Linq.Expressions;

namespace BusinessApplicationProject.Controller
{
    public class Controller<T> where T : class
    {
        public delegate AppDbContext AppDbContextFactory();
        public delegate Repository<T> RepositoryFactory(AppDbContext context);

        public AppDbContextFactory getContext { get; init; }
        public RepositoryFactory getRepository { get; init; }

        public List<T> GetAllAsync()
        {
            List<T> result = new List<T>();

            using (var context = getContext())
            {
                var repository = getRepository(context);
                result = repository.GetAllAsync().Result.ToList();
            }

            return result;
        }

        public List<T> Find(Expression<Func<T, bool>> condition)
        {
            List<T> result = new List<T>();

            using (var context = getContext())
            {
                var repository = getRepository(context);
                result = repository.Find(condition).ToList();
            }

            return result;
        }
    }
}