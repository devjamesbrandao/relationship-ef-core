using EFCoreRelationshipsTutorial.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreRelationshipsTutorial.Data.Mappings
{
    public class StudentAddressMapping : IEntityTypeConfiguration<StudentAddress>
    {
        public void Configure(EntityTypeBuilder<StudentAddress> builder)
        {
            builder.HasKey(x => x.StudentAddressId);
        }
    }
}