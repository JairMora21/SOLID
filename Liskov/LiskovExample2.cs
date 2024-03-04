using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_SOLID.Liskov
{

    public static class Program1
    {
        public static void Main(string[] args)
        {
            AbstractSaleWithTaxes sale = new Sale(100, "jair", 10m);
            sale.CalculateTaxes();
            sale.Generate();
            //OUTPUT: Taxes calculate

        }
    }
    public abstract class AbstractSale // T
    {
        protected decimal amount;
        protected string customer;
        //protected decimal taxes;

        public abstract void Generate();
        //public abstract void CalculateTaxes();

    }

    public abstract class AbstractSaleWithTaxes : AbstractSale
    {
        protected decimal taxes;
        public abstract void CalculateTaxes();
    }

    public class Sale : AbstractSaleWithTaxes
    {
        public Sale (decimal amount, string customer, decimal taxes)
        {
            this.amount = amount;
            this.customer = customer;
            this.taxes = taxes;
        }
        public override void CalculateTaxes()
        {
            Console.WriteLine("Taxes calculated");
        }
        public override void Generate()
        {
            Console.WriteLine("Sale generated");
        }
    }

    public  class ForeingSale : AbstractSale
    {
        public ForeingSale(decimal amount, string customer)
        {
            this.amount = amount;
            this.customer = customer;
        }
    
        public override void Generate()
        {
            Console.WriteLine("Sale generated");
        }
    }




}
