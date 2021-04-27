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
        Customer GetbyId(int id);
        List<Customer> GetAll();

    }
}
