using EFCoreRelationshipsTutorial.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreRelationshipsTutorial.Data.Mappings
{
    public class StudentMapping : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => new { x.Id, x.StoreId });

            // Configuring the relationship keys 1 x 1
            builder.HasOne<StudentAddress>(s => s.Address)
            .WithOne(ad => ad.Student)
            .HasForeignKey<StudentAddress>(ad => new { ad.AddressOfStudentId, ad.AddressOfStudentStoreId })
            .HasConstraintName("ForeignKey_Student_StudentAddress")
            .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}