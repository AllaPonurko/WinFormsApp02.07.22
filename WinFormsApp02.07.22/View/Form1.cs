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
            if (listBoxCountry != null)
            {
                foreach (var item in listBoxCountry.Items)
                {
                    while (txtName.Text == item.ToString())
                    {
                        MessageBox.Show("Такая страна уже есть!");
                        return;
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
            if (listBoxCity != null)
            {
                foreach (var item in listBoxCity.Items)
                {
                    while (txtNameCity.Text == item.ToString())
                    {
                        MessageBox.Show("Такой город уже есть!");
                        return;
                    }
                }
            }
            try
            {
                while (listBoxCountry.Items == null)
                {
                    MessageBox.Show("Сначала создайте страну!");
                    return;
                }
                while (listBoxCountry.SelectedItem == null)
                {
                    MessageBox.Show("Выберите страну");
                    return;
                }
                
                        city.Name = txtNameCity.Text.ToString();
                        city.Population = Convert.ToInt32(txtPopulationCity.Text);
                        city.Postcode = Convert.ToInt32(txtPostCard.Text);
                        listBoxCity.Items.Add(city.Name);
                        
                        db.Cities.Add(city);
                        
                foreach (var item in db.GetCountries)
                {
                    if (item.Name == listBoxCountry.SelectedItem.ToString())
                    {
                        item.cities.Add(city);
                    }
                }
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            txtName.Text = null;
            txtName.BackColor = Color.Beige;
        }

        private void txtCode_MouseClick(object sender, MouseEventArgs e)
        {
            txtCode.Text = null;
            txtCode.BackColor= Color.Beige;
        }

        private void txtPopulation_MouseClick(object sender, MouseEventArgs e)
        {
            txtPopulation.Text = null;
            txtPopulation.BackColor = Color.Beige;
        }

        private void txtNameCity_DoubleClick(object sender, EventArgs e)
        {
            txtNameCity.Text = null;
            txtNameCity.BackColor = Color.Beige;
        }

        private void txtPostCard_DoubleClick(object sender, EventArgs e)
        {
            txtPostCard.Text = null;
            txtPostCard.BackColor= Color.Beige; 
        }

        private void txtPopulationCity_DoubleClick(object sender, EventArgs e)
        {
            txtPopulationCity.Text = null;
            txtPopulationCity.BackColor = Color.Beige;
        }
    }
    }

