using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus.Teaching.PromoCodeFactory.DataAccess.Data
{
    //Инициализация БД
    public interface IDbInitializer
    {
        public void InitializeDb();
    }
}
