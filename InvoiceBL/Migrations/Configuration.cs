namespace InvoiceBL.Migrations
{
    using InvoiceBL.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<InvoiceBL.Context.InvoiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(InvoiceBL.Context.InvoiceContext context)
        {
            IList<Customer> defaultStandards = new List<Customer>();

            defaultStandards.Add(new Customer() { ID = 1, Name = "First Standard" });
            defaultStandards.Add(new Customer() { ID = 2, Name = "Second Standard" });
            defaultStandards.Add(new Customer() { ID = 3, Name = "Third Standard" });
            defaultStandards.Add(new Customer() { ID = 4, Name = "four Standard" });

            context.Customers.AddRange(defaultStandards);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
