using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_SOLID.OpenClose
{
    public class OpenClose
    {
        public interface IDrink
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            //Este valor es el que se multiplica por el precio (impuesto)
            public decimal Invoice { get; set; }
            //Este metodo es el que se encarga de calcular el precio total 
            public decimal GetPrice();

        }
        public class Water : IDrink
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public decimal Invoice { get; set; }
            public decimal GetPrice() => Price * Invoice;
        }
        public class Sugar : IDrink
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public decimal Invoice { get; set; }
            public decimal GetPrice() => Price * Invoice;
        }
        public class Alcohol : IDrink
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public decimal Invoice { get; set; }
            public decimal Promo { get; set; }
            public decimal GetPrice() => (Price * Invoice) - Promo;
        }

        public class Invoice
        {
            //Ahora recibe una coleccion de elementos que implementan la interfaz IDrink
            public decimal GetTotal(List<IDrink> drinks)
            {
                decimal total = 0;
                foreach (var drink in drinks)
                {
                    //Implementamos el GetPrice por cada elemento de la coleccion
                   total += drink.GetPrice();
                }
                return total;
            }
        }
    }
}
