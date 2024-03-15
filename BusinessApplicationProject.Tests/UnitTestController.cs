using BusinessApplicationProject.Controller;
using BusinessApplicationProject.Model;
using BusinessApplicationProject.Repository;
using System.Linq.Expressions;

namespace BusinessApplicationProject.Tests
{
    [TestClass]
    public class UnitTestController
    {
        [TestMethod]
        public void TestFindSingle()
        {
            // Arrange
            var addr = new Address
            {
                Id = 1,
                StreetAddress = "111 W 57th St",
                ZipCode = "NY 10019",
                City = "New York",
                Country = "United States"
            };

            var c = new Controller<Address>
            {
                getContext = () => new AppDbContext(),
                getRepository = ctx => {
                    var r = new AddressRepositoryStub();
                    r.Content.Add(addr);
                    return r;
                }
            };

            // Act
            Address? res = c.FindSingle(x => x.Id == 1);

            // Assert
            Assert.AreEqual(addr, res);
        }
    }

    class AddressRepositoryStub : IRepository<Address>
    {
        public List<Address> Content = new List<Address>();

        public Task AddAsync(Address entity)
        {
            throw new NotImplementedException();
        }

        public List<Address> Find(Expression<Func<Address, bool>> searchTerm)
        {
            var predicate = searchTerm.Compile();
            return Content.Where(predicate).ToList();
        }

        public List<Address> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(Address entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Address entity)
        {
            throw new NotImplementedException();
        }
    }
}