using Microsoft.EntityFrameworkCore;

namespace Lab11MVC.Models
{
    // La clase InvoiceContext hereda de DbContext de Entity Framework Core
    public class InvoiceContext : DbContext
    {
        // Constructor que recibe DbContextOptions, que se usará para configurar el contexto de la base de datos
        public InvoiceContext(DbContextOptions<InvoiceContext> options) : base(options) { }

        // Propiedades DbSet que representan las tablas en la base de datos
        // Cada DbSet representa una tabla y tiene un nombre que coincide con el nombre de la clase
        // Las propiedades DbSet permiten acceder a los datos en las tablas correspondientes
        public DbSet<Customer> Customers { get; set; } // Representa la tabla de clientes
        public DbSet<Product> Products { get; set; } // Representa la tabla de productos
        public DbSet<Invoice> Invoices { get; set; } // Representa la tabla de facturas
        public DbSet<Detail> Details { get; set; } // Representa la tabla de detalles de factura
    }
}
