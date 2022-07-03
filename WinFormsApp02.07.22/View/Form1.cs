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
        DbContextWorld db = new DbContextWorld();
        public Country country = new Country();
        public City city = new City();
        private void btnAdd_Click(object sender, EventArgs e)
        { 
            if(listBoxCountry!=null)
            {
                foreach(var item in listBoxCountry.Items)
                {
                    if(txtName.Text==item.ToString())
                    {
                        MessageBox.Show("Такая страна уже есть!");
                    }
                }
            }
            
            try
            {
                country.Name = txtName.Text.ToString();
                country.Population = Convert.ToInt32(txtPopulation.Text);
                country.InternationalCode = Convert.ToInt32(txtCode.Text);
                listBoxCountry.Items.Add(country.Name);
                db.GetCountries.Add(country);
                db.Countries.Add(country);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            foreach (var item in db.GetCountries)
            {
                if (listBoxCountry.Items!= null
                      && listBoxCountry.SelectedItem.ToString() == item.ToString())
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
                //else
                //{
                //    MessageBox.Show("Не выбрана страна!");
                //}
            }
        }

        private void FormWorld_Load(object sender, EventArgs e)
        {
            if (db.Countries != null)
            {
                foreach (var item in db.Countries)
                {
                    listBoxCountry.Items.Add(item.Name);
                }
            }
            if (db.Cities != null)
            {
                foreach (var item in db.Cities)
                {
                    listBoxCity.Items.Add(item.Name);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRemoveCountry_Click(object sender, EventArgs e)
        {
            if(listBoxCountry!=null)
            {
                try
                {

                
                foreach(var item in db.GetCountries)
                {
                    if(listBoxCountry.SelectedItem.ToString()==item.Name&&item.cities!=null)   
                    {
                        db.GetCountries.Remove(item);
                        db.SaveChanges();
                        }
                }
                foreach (var item in db.Countries)
                {
                    if (listBoxCountry.SelectedItem.ToString() == item.Name && item.cities != null)
                    {
                        db.Countries.Remove(item);
                        db.SaveChanges();
                    }
                }
                
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                     listBoxCountry.Items.RemoveAt(listBoxCountry.SelectedIndex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        }
    }

