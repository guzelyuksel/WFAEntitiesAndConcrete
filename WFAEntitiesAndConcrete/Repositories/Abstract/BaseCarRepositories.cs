using System.Collections.Generic;
using System.Windows.Forms;
using WFAEntitiesAndConcrete.Entities.Concrete;

namespace WFAEntitiesAndConcrete.Repositories.Abstract
{
    public abstract class BaseCarRepositories
    {
        public abstract void Add(Car car);
        public abstract void Delete(int id);
        public abstract void Update(int id, Car newCar);
        public abstract void Update(int id, string Brand, string Model, decimal Price);
        public abstract Car GetById(int id);
        public abstract List<Car> GetAll();
        public abstract void ClearTextBox(GroupBox groupBox);
    }
}