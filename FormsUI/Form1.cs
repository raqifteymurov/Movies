using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsUI
{   
    public partial class Form1 : Form
    {
        private ICustomerService _customerService;
        public Form1()
        {
            _customerService = new CustomerManager(new EfCustomerDal());
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }
        private void ClearEntities()
        {
            tbxAgeUpdate.Text = "";
            tbxFirstNameUpdate.Text = "";
            tbxLastNameUpdate.Text = "";
            tbxChosenMovieUpdate.Text = "";

            tbxAgeAdd.Text = "";
            tbxFirstNameAdd.Text = "";
            tbxLastNameAdd.Text = "";
            tbxChosenMovieAdd.Text = "";

        }
        private void LoadCustomers()
        {
            dgwCustomers.DataSource = _customerService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _customerService.Add(new Customer
            {
                FirstName=tbxFirstNameAdd.Text,
                LastName=tbxLastNameAdd.Text,
                Age=Convert.ToInt32(tbxAgeAdd.Text),
                ChosenMovie=tbxChosenMovieAdd.Text
            });
            LoadCustomers();
            MessageBox.Show("ENTITIES ADDED", "MESSAGE: ");
            ClearEntities();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _customerService.Update(new Customer
            {
                Id=(int)dgwCustomers.CurrentRow.Cells[0].Value,
                FirstName=tbxFirstNameUpdate.Text,
                LastName=tbxLastNameUpdate.Text,
                Age=Convert.ToInt32(tbxAgeUpdate.Text),
                ChosenMovie=tbxChosenMovieUpdate.Text
            });
            LoadCustomers();
            MessageBox.Show("ENTITIES UPDATED", "MESSAGE: ");
            ClearEntities();

        }

        private void dgwCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var cells = dgwCustomers.CurrentRow.Cells;
            tbxFirstNameUpdate.Text = cells[1].Value.ToString();
            tbxLastNameUpdate.Text = cells[2].Value.ToString();
            tbxAgeUpdate.Text = cells[3].Value.ToString();
            tbxChosenMovieUpdate.Text = cells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _customerService.Delete(new Customer
            {
                Id=(int)dgwCustomers.CurrentRow.Cells[0].Value
            });
            LoadCustomers();
            MessageBox.Show("ENTITIES DELETED", "MESSAGE: ");
        }

        private void tbxFirstNameSearching_TextChanged(object sender, EventArgs e)
        {
            var text = tbxFirstNameSearching.Text;
            if (!String.IsNullOrEmpty(text))
            {
                dgwCustomers.DataSource = _customerService.GetByFirstName(text);
            }
            else
            {
                LoadCustomers();
            }
        }

        private void tbxLastNameSearching_TextChanged(object sender, EventArgs e)
        {
            var text = tbxLastNameSearching.Text;
            if (!String.IsNullOrEmpty(text))
            {
                dgwCustomers.DataSource = _customerService.GetByLastName(text);
            }
            else
            {
                LoadCustomers();
            }

        }

        private void tbxChosenMovieSearch_TextChanged(object sender, EventArgs e)
        {
            var text = tbxChosenMovieSearch.Text;
            if (!String.IsNullOrEmpty(text))
            {
                dgwCustomers.DataSource = _customerService.GetByChosenMovie(text);
            }
            else
            {
                LoadCustomers();
            }
        }
        private void tbxMinAgeSearching_TextChanged_1(object sender, EventArgs e)
        {
            LoadByAge();
        }

        private void tbxMaxAgeSearching_TextChanged(object sender, EventArgs e)
        {
            LoadByAge();
        }
        private void LoadByAge()
        {
            var minage = tbxMinAgeSearching.Text;
            int min = _customerService.GetMinAge();
            int max = _customerService.GetMaxAge();
            if (!String.IsNullOrEmpty(minage))
            {
                min = Convert.ToInt32(minage);
            }
            var maxage = tbxMaxAgeSearching.Text;
            if (!String.IsNullOrEmpty(maxage))
            {
                max =Convert.ToInt32(maxage);
            }
            dgwCustomers.DataSource = _customerService.GetbyAge(min, max);
        }

       
    }
}
