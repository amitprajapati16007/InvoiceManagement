using InvoiceBL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceBL.Context
{
    public class InvoiceContext : DbContext 
    {
        public InvoiceContext() : base("name = MydbConn")
        {
            // Database.SetInitializer(new InvoiceDBInitializer());
            Database.SetInitializer<InvoiceContext>(new DropCreateDatabaseAlways<InvoiceContext>());
        }
        public DbSet<Customer> Customers { get; set; }

       
    }
    public class InvoiceDBInitializer : DropCreateDatabaseAlways<InvoiceContext>
    {
        protected override void Seed(InvoiceContext context)
        {
            
            IList<Customer> defaultStandards = new List<Customer>();

            defaultStandards.Add(new Customer() { ID = 1, Name = "First Standard" });
            defaultStandards.Add(new Customer() { ID = 2, Name = "Second Standard" });
            defaultStandards.Add(new Customer() { ID = 3, Name = "Third Standard" });

            context.Customers.AddRange(defaultStandards);

            base.Seed(context);
        }
    }
}
