using System;
using WFAEntitiesAndConcrete.Entities.Abstract;

namespace WFAEntitiesAndConcrete.Entities.Concrete
{
    public class Car : BaseEntities
    {
        public string Brand { get; set; }
        
        public string Model { get; set; }
        
        public decimal Price { get; set; }

        public Car(int id, string brand, string model, decimal price)
        {
            Id = id;
            Brand = brand;
            Model = model;
            Price = price;
        }
    }
}