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
        public Country country;
        public City city ;
        /// <summary>
        /// добавление страны
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            country = new Country();
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
                db.Countries.Add(country);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// добавление города
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCity_Click(object sender, EventArgs e)
        {
            city = new City();
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
                        
                foreach (var item in db.Countries)
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
    /// <summary>
    /// загрузка формы
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

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
        /// <summary>
        /// выход из приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// удаление страны
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveCountry_Click(object sender, EventArgs e)
        {
            if (listBoxCountry.SelectedItem==null)
            {
                MessageBox.Show("Не выбран элемент для удаления");
            }
            if(listBoxCountry!=null)
            {
                try
                {
                foreach (var item in db.Countries)
                {
                    if (listBoxCountry.SelectedItem.ToString() == item.Name && item.cities == null)
                    {
                        db.Countries.Remove(item);
                        db.SaveChanges();
                    }
                    if(item.cities != null)
                        {
                                 MessageBox.Show("Список городов этой страны не пуст." +
                                        " Сначала удалите все города из списка этой страны.");
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
            
        }

        private void txtCode_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtPopulation_MouseClick(object sender, MouseEventArgs e)
        {
            
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
        /// <summary>
        /// удаление города
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveCity_Click(object sender, EventArgs e)
        {
            while(listBoxCity.Items==null)
                {
                MessageBox.Show("Нет объекта для удаления");
                return;
                }
            while(listBoxCity.SelectedItem==null)
            {
                MessageBox.Show("Не выбран город для удаления");
                return;
            }
            try
            {
                foreach(var item in db.Cities)
                {
                    if(item.Name==listBoxCity.SelectedItem.ToString())
                    {
                             db.Cities.Remove(item);

                        foreach (var item1 in db.Countries)
                        {
                            if (item1.cities.Contains(item))
                            {
                                item1.cities.Remove(item);
                            }
                        }
                    }
                    db.SaveChanges();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtName_DoubleClick(object sender, EventArgs e)
        {
            txtName.Text = null;
            txtName.BackColor = Color.Beige;
        }

        private void txtCode_DoubleClick(object sender, EventArgs e)
        {
            txtCode.Text = null;
            txtCode.BackColor = Color.Beige;
        }

        private void txtPopulation_DoubleClick(object sender, EventArgs e)
        {
            txtPopulation.Text = null;
            txtPopulation.BackColor = Color.Beige;
        }
    }
    }

