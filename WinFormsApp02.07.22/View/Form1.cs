using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp02._07._22.ApplicationDBContext;
using WinFormsApp02._07._22.Entities;

namespace WinFormsApp02._07._22
{
    public partial class FormWorld : Form
    {
        public FormWorld()
        {
            InitializeComponent();
            
        }
        DbContextWorld db = new DbContextWorld("Data Source=DbWorld.db");
        public Country country = new Country();
        public City city = new City();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                country.Name = txtName.Text.ToString();
                country.Population = Convert.ToInt32(txtPopulation.Text);
                country.InternationalCode = Convert.ToInt32(txtCode.Text);
                listBoxCountry.Items.Add(country.Name);
                this.db.GetCountries.Add(country);
                this.db.Countries.Add(country);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        { foreach (var item in db.GetCountries)
            { if (listBoxCountry.SelectedItem!=null
                    &&listBoxCountry.SelectedItem.ToString () ==item.ToString())
            try
            {
                city.Name = txtNameCity.Text.ToString();
                city.Population = Convert.ToInt32(txtPopulationCity.Text);
                city.Postcode = Convert.ToInt32(txtPostCard.Text);
                listBoxCity.Items.Add(city.Name);
                item.cities.Add(city);
                this.db.Cities.Add(city);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                else
                {
                    MessageBox.Show("Не выбрана страна!");
                }
        }
        }
    }
}
