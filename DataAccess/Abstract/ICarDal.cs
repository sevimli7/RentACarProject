using Core.DataAccess;
using Entities.Concrete;
using Entities.Concrete.DTOs.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface ICarDal:IEntityReposityory<Car>
    {
        List<CarDetailDto> GetCarDetails();

    }
}
