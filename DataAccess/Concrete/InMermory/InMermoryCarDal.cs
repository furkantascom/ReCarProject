using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMermory
{
    public class InMermoryCarDal:ICarDal
    {
        List<Car> _car;
        public InMermoryCarDal()
        {
            //sql server
            _car = new List<Car> { 
            new Car{Id=1,BrandId=1, ColorId=1, DailyPrice=50000, Description="opel", ModelYear=2021},
            new Car{Id=2,BrandId=2, ColorId=2, DailyPrice=70000, Description="wolswogen", ModelYear=2022},
            new Car{Id=3,BrandId=2, ColorId=1, DailyPrice=95000, Description="fiat", ModelYear=2023}
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _car.First(c=>c.Id == car.Id);
            _car.Remove(CarToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _car.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _car.First(c => c.Id == car.Id);
            CarToUpdate.Id = car.Id;
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;
            CarToUpdate.ModelYear = car.ModelYear;

        }
    }
}
