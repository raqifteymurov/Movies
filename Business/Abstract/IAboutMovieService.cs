using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAboutMovieService
    {
        void Add(AboutMovie movie);
        void Update(AboutMovie movie);
        void Delete(AboutMovie movie);
        AboutMovie GetById(int id);
        List<AboutMovie> GetAll();

    }
}
