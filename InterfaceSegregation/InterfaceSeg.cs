using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Principios_SOLID.InterfaceSegregation.InterfaceSeg;

namespace Principios_SOLID.InterfaceSegregation
{
    public class InterfaceSeg
    {
        //Se crean las interfaces para las acciones basicas y las acciones editables
        public interface IBasicActions<T>
        {
            public T Get(int id);
            public List<T> GetAll();
            public void Add(T entity);
        }

        public interface IEditableActionsctions<T>
        {
            public void Update(T entity);
            public void Delete(int id);

        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class Sale
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }

    //Se implementan ambas interfaces
    public class UserService : IBasicActions<User>, IEditableActionsctions<User>
    {
        public void Add(User entity)
        {
            Console.WriteLine("Agregando usuario...");
        }

        public void Delete(int id)
        {
            Console.WriteLine("Eliminando usuario...");
        }

        public User Get(int id)
        {
            Console.WriteLine("Obteniendo usuario...");
            return new User();
        }

        public List<User> GetAll()
        {
            Console.WriteLine("Obteniendo todos los usuarios...");
            return new List<User>();
        }

        public void Update(User entity)
        {
            Console.WriteLine("Actualizando usuario...");
        }
    }

    //Solo se implementa la interfaz de acciones basicas
    public class SaleService : IBasicActions<Sale>
    {
        public void Add(Sale entity)
        {
            Console.WriteLine("Agregando venta...");
        }
        public Sale Get(int id)
        {
            Console.WriteLine("Obteniendo venta...");
            return new Sale();
        }
        public List<Sale> GetAll()
        {
            Console.WriteLine("Obteniendo todas las ventas...");
            return new List<Sale>();
        }
    }
}
