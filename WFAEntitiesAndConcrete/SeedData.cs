using System.Collections.Generic;
using WFAEntitiesAndConcrete.Entities.Concrete;

namespace WFAEntitiesAndConcrete
{
    public class SeedData
    {
        public static List<Car> cars = new List<Car>()
        {
            new Car(1, "Seat", "Leon", 350),
            new Car(2, "Fiat", "Ford", 250),
            new Car(3, "Honda", "City", 450),
            new Car(4, "BMV", "330", 550)
        };
    }
}
