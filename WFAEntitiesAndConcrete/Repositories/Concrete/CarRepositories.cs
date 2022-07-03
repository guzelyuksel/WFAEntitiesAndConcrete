using System.Collections.Generic;
using System.Windows.Forms;
using WFAEntitiesAndConcrete.Entities.Concrete;
using WFAEntitiesAndConcrete.Repositories.Abstract;

namespace WFAEntitiesAndConcrete.Repositories.Concrete
{
    public class CarRepositories : BaseCarRepositories
    {
        public override void Add(Car car)
        {
            SeedData.cars.Add(car);
        }

        public override void Delete(int id)
        {
            foreach (Car car in SeedData.cars)
            {
                if (car.Id == id)
                {
                    SeedData.cars.Remove(car);
                    return;
                }
            }
        }

        public override void Update(int id, Car newCar)
        {
            int index = 0;
            foreach (Car car in SeedData.cars)
            {
                if (car.Id == id)
                {
                    SeedData.cars[index] = newCar;
                    return;
                }
                index++;
            }
        }

        public override void Update(int id, string Brand, string Model, decimal Price)
        {
            foreach (Car car in SeedData.cars)
            {
                if (car.Id == id)
                {
                    car.Brand = Brand;
                    car.Model = Model;
                    car.Price = Price;
                    return;
                }
            }
        }

        public override Car GetById(int id)
        {
            foreach (Car car in SeedData.cars)
                if (car.Id == id)
                    return car;
            return null;
        }

        public override List<Car> GetAll()
        {
            return SeedData.cars;
        }

        public override void ClearTextBox(GroupBox groupBox)
        {
            foreach (var ctrl in groupBox.Controls)
                if (ctrl is TextBox txt)
                    if(txt.Name != "txtSearchId") // id içeren textbox'ı silmemek için
                        txt.Text = "";
        }
    }
}