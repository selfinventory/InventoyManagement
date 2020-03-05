using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoyManagement.Models
{
    public class RunModel : DbContext
    {
        
        public RunModel(DbContextOptions<RunModel> options)
            : base(options)
        {
        }

        public DbSet<CustomersModel> Customers { get; set; }
        public DbSet<CompaniesModel> Companies { get; set; }
        public DbSet<BrandsModel> Brands { get; set; }
        public DbSet<FinanceModel> Finances { get; set; }
        public DbSet<InvoicesModel> Invoices { get; set; }
        public DbSet<LaborModel> Labor { get; set; }
        public DbSet<ModelPartsModel> ModelParts { get; set; }
        public DbSet<PartsModel> Parts { get; set; }
        public DbSet<PartsFotoModel> PartsFoto { get; set; }
        public DbSet<PartsGroupModel> PartsGroup { get; set; }
        public DbSet<PaymentModeModel> PaymentMode { get; set; }
        //public DbSet<ServicesModel> Services { get; set; }
        public DbSet<SuppliersModel> Suppliers { get; set; }
       // public DbSet<TransactionsModel> Transaction { get; set; }
        public DbSet<UsersModel> Users { get; set; }
        public DbSet<TaxModel> Tax { get; set; }
    }
}