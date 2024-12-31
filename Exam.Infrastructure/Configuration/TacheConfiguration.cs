using ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Infrastructure.Configuration
{
    public class TacheConfiguration : IEntityTypeConfiguration<Tache>
    {
        public void Configure(EntityTypeBuilder<Tache> builder)
        {

            builder
  .HasOne(r => r.Sprint)
  .WithMany(p => p.Taches)
  .HasForeignKey(r => r.SprintKey);


            builder
                .HasOne(r => r.Menmbre)
                .WithMany(f => f.Taches)
                .HasForeignKey(r => r.MembreKey);
            builder.HasKey(r => new
            {
                r.Titre,
                r.SprintKey,
                r.MembreKey
            });



        }
    }
}
