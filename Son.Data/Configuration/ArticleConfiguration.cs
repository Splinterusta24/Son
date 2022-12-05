using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Son.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Son.Data.Configuration
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.Property(a => a.Content).IsRequired();
            builder.Property(a => a.Title).IsRequired();

            //builder.HasOne<User>().WithMany(u=>u.Articles).HasForeignKey(a=>a.UserId); //Kendin yapabilirsin. Ama gerek yok.
        }
    }
}
