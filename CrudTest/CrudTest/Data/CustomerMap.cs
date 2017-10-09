using CrudTest.Models;
using System.Data.Entity.ModelConfiguration;

namespace CrudTest.Data
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            ToTable("CUSTOMER");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .HasColumnName("ID");

            Property(c => c.Name)
                .HasColumnName("NAME");

            Property(c => c.Cpf)
                .HasColumnName("CPF");

            Property(c => c.Birth)
                .HasColumnName("BIRTH");

            Property(c => c.Gender)
                .HasColumnName("GENDER");
        }
    }
}