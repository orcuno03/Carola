using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carola.EntityLayer.Entities;

namespace Carola.BusinessLayer.Abstract
{
    public interface ICarService : IGenericService<Car>
    {
        Task<List<Car>> TGetAllCarsWithCategoryAsync();
    }
}
