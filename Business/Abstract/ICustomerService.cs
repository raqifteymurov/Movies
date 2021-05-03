using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
  public  interface ICustomerService
    {
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
        Customer GetbyId(int id);
        List<Customer> GetAll();
        List<Customer> GetByFirstName(string firstName);
        List<Customer> GetByLastName(string lastName);
        List<Customer> GetByChosenMovie(string chosenmovie);
        List<Customer> GetbyAge(int min, int max);
        int GetMinAge();
        int GetMaxAge();
    }
}

