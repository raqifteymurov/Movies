using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mapping
{
    class AboutMovieMap:EntityTypeConfiguration<AboutMovie>
    {
        public AboutMovieMap()
        {
            ToTable("AboutMovies");
            HasKey(p => p.Id);
            Property(p => p.Name).HasColumnName("Name");
            Property(p => p.Price).HasColumnName("Price");
            Property(p => p.FilmDuration).HasColumnName("FilmDuration");
           
        }
    }
}
