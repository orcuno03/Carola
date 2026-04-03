using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carola.DataAccessLayer.Abstract;
using Carola.DataAccessLayer.Concrete;
using Carola.DataAccessLayer.Repository;
using Carola.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carola.DataAccessLayer.EntityFramework
{
    public class EfCarDal : GenericRepository<Car>, ICarDal
    {
        public EfCarDal(CarolaContext context) : base(context)
        {
        }

        public Task<List<Car>> GetAllCarsWithCategoryAsync()
        {
            var context = new CarolaContext();
            var values = context.Cars.Include(x => x.Category).ToListAsync();
            return values;
        }
    }
}
