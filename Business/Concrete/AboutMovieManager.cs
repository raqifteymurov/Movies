using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AboutMovieManager : IAboutMovieService
    {
        private IAboutMovieDal _aboutmovieDal;

        public AboutMovieManager(IAboutMovieDal aboutmovieDal)
        {
            _aboutmovieDal = aboutmovieDal;
        }

        public void Add(AboutMovie movie)
        {
            _aboutmovieDal.Add(movie);
        }

        public void Delete(AboutMovie movie)
        {
            _aboutmovieDal.Delete( movie);
        }

        public List<AboutMovie> GetAll()
        {
            return _aboutmovieDal.GetAll();
        }

        public AboutMovie GetById(int id)
        {
            return _aboutmovieDal.Get(s => s.Id == id);
        }

        public void Update(AboutMovie movie)
        {
            _aboutmovieDal.Update(movie);
        }
    }
}
