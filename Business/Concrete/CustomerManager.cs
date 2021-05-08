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
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add(Customer customer)
        {
            _customerDal.Add(customer);
        }

        public void Delete(Customer customer)
        {
            _customerDal.Delete(customer);
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public List<Customer> GetbyAge(int min, int max)
        {
            return _customerDal.GetAll(p => p.Age >= min && p.Age <= max);
        }

        public List<Customer> GetByChosenMovie(string chosenmovie)
        {
            return _customerDal.GetAll(p=>p.ChosenMovie.ToLower().Contains(chosenmovie.ToLower()));
        }
        public List<Customer> GetByFirstName(string firstName)
        {
            return _customerDal.GetAll(p => p.FirstName.ToLower().Contains(firstName.ToLower()));
        }

        public Customer GetbyId(int id)
        {
            return _customerDal.Get(p => p.Id == id);
        }
        public List<Customer> GetByLastName(string lastName)
        {
            return _customerDal.GetAll(p => p.LastName.ToLower().Contains(lastName.ToLower()));
        }

        public int GetMaxAge()
        {
            return _customerDal.GetAll().Select(p => p.Age).Max();
        }

        public int GetMinAge()
        {
            return _customerDal.GetAll().Select(p => p.Age).Min();
        }

        public void Update(Customer customer)
        {
            _customerDal.Update(customer);
        }
    }
}
