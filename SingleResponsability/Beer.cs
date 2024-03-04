using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_SOLID.SingleResponsability
{

    //Responsabilidad de los datos de la cerveza
    public class Beer
    {
        public string Name { get; set; }
        public string Brand { get; set; }

        public Beer(string name, string brand)
        {
            Name = name;
            Brand = brand;
        }
    }

    //Responsabilidad de la base de datos
    public class  BeerDB
    {
        private Beer _beer;

        public BeerDB(Beer beer)
        {
            _beer = beer;
        }

        public void Save()
        {
            Console.WriteLine($"Guardamos {_beer.Name} y {_beer.Brand}");
        }
        
    }

    //Responsabilidad de enviar la cerveza
    public class BeerRequest
    {
        private Beer _beer;

        public BeerRequest(Beer beer)
        {
            _beer = beer;
        }
        public void Send()
        {
            Console.WriteLine($"Enviamos a ese otro lugar {_beer.Name} y {_beer.Brand}");
        }
    }
}
