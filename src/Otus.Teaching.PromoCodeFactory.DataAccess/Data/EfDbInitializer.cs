using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus.Teaching.PromoCodeFactory.DataAccess.Data
{
    //для заполнения БД фейковыми данными
    public class EfDbInitializer
        : IDbInitializer
    {
        private readonly DataContext _dataContext;

        public EfDbInitializer(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void InitializeDb()
        {
            _dataContext.Database.EnsureDeleted();
            _dataContext.Database.EnsureCreated();

            _dataContext.AddRange(FakeDataFactory.Employees);
            _dataContext.SaveChanges();

            _dataContext.AddRange(FakeDataFactory.Preferences);
            _dataContext.SaveChanges();

            _dataContext.AddRange(FakeDataFactory.Customers);
            _dataContext.SaveChanges();
        }
    }
    }

