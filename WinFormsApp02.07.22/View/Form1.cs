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
using WinFormsApp02._07._22.View;

namespace WinFormsApp02._07._22
{
    public struct DataCountry
        {
            public string Name;
            public int Code;
            public int Population;
        }
    public struct DataCity
    {
        public string Name;
        public int Code;
        public int Population;

    }
    public partial class FormWorld : Form
    {
        public FormWorld()
        {
            InitializeComponent();

        }
        static public DbContextWorld db = new DbContextWorld();
        public Country country;
        public City city ;
        /// <summary>
        /// статическая переменная для переноса данных
        /// </summary>
         static public DataCountry dataCountry;
         static public DataCity dataCity; 
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
                return;
            }
            if(listBoxCountry!=null)
            {
                try
                {
                foreach (var item in db.Countries)
                {
                    if (listBoxCountry.SelectedItem.ToString() == item.Name && item.cities.Count==0)
                    {
                       db.Countries.Remove(item);
                       db.SaveChanges();
                       listBoxCountry.Items.RemoveAt(listBoxCountry.SelectedIndex);
                    }
                        
                    if(listBoxCountry.SelectedItem.ToString() == item.Name && item.cities.Count!=0)
                        {
                                 MessageBox.Show("Список городов этой страны не пуст." +
                                        " Сначала удалите все города из списка этой страны.");
                            return;
                        }
                }
                
                
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

            if (listBoxCity.Items != null && listBoxCity.SelectedItem != null)
            {
                try
                {
                    foreach (var item1 in db.Countries)
                    {
                         foreach (var item in db.Cities)
                         {
                            if (listBoxCity.SelectedItem.ToString()== item.Name 
                                &&item1.cities.Contains(item))
                            {
                                item1.cities.Remove(item);
                                db.Cities.Remove(item);
                                
                                db.SaveChanges();
                            }
                            
                         }
                    }
                 
                listBoxCity.Items.Remove(listBoxCity.SelectedItem);   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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

        private void listBoxCity_MouseMove(object sender, MouseEventArgs e)
        {
            //try 
            //{
            //    if(listBoxCity.Items!=null&&listBoxCity.SelectedItem!=null)
            //{
            //    foreach(var itemCity in db.Cities)
            //    {
            //        foreach(var itemCountry in db.Countries)
            //        {
            //            if (listBoxCity.SelectedItem.ToString() == itemCity.Name &&
            //                itemCountry.cities.Contains(itemCity))
            //                toolTip1.SetToolTip(listBoxCity, itemCountry.ToString());
            //        }
            //    }
            //}
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }
        /// <summary>
        /// редактирование страны
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditCountry_Click(object sender, EventArgs e)
        {if (listBoxCountry.SelectedItem == null)
            {
                MessageBox.Show("Страна не выбрана");
                return;
            }
            try
                {
                    FormEditCountry country = new FormEditCountry(this);
                    country.Show();
                    foreach(var item in db.Countries)
                    {
                      if(listBoxCountry.SelectedItem.ToString()==item.Name)
                    { 
                        country.txtNameCountry.Text = item.Name;
                        country.txtCodeCountry.Text = item.InternationalCode.ToString();
                        country.txtPopulationCountry.Text = item.Population.ToString();
                    }
                }
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        /// <summary>
        /// редактирование города
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditCity_Click(object sender, EventArgs e)
        {
            if (listBoxCity.SelectedItem == null)
            {
                MessageBox.Show("Город не выбран");
                return;
            }
            try
            {
                FormEditCity city  = new FormEditCity(this);
                city.Show();
                foreach (var item in db.Cities)
                {
                    if (listBoxCity.SelectedItem.ToString() == item.Name)
                    {
                        city.txtNameCity.Text = item.Name;
                        city.txtCodeCity.Text = item.Postcode.ToString();
                        city.txtPopulationCity.Text = item.Population.ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowMillion_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnShowMillion, "Показать города-миллионики");
        }

        private void btnShowMillion_Click(object sender, EventArgs e)
        {
            comboBoxSelect.Items.Clear();
            if (listBoxCity.Items == null)
                MessageBox.Show("Нет городов для показа");
            try
            {
                var towns = (from city in db.Cities
                             where city.Population >= 1000000
                             select city).ToList();
                comboBoxSelect.Items.AddRange(towns.ToArray());

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowCityInCountry_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnShowCityInCountry, "Показать все города выбранной страны");
        }

        private void btnShowCityInCountry_Click(object sender, EventArgs e)
        {
            comboBoxSelect.Items.Clear();
            if (listBoxCountry.Items == null || listBoxCity.Items == null)
                MessageBox.Show("Нет городов для показа");
            if(listBoxCountry.SelectedItem==null)
                MessageBox.Show("Не выбрана страна");
            if(listBoxCountry.SelectedItem != null)
            try
            {
                    foreach(var item in db.Countries)
                    {
                       if(listBoxCountry.SelectedItem.ToString()==item.Name)
                        {
                            comboBoxSelect.Items.AddRange(item.cities.ToArray());
                        }
                    }
                //var town = (from city in db.Cities.Include(c => c.country)
                //            where city.CountryId == country.Id
                //            select city).ToList();
                //comboBoxSelect.Items.AddRange(town.ToArray());

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPopulationCountry_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnPopulationCountry, "Показать численность" +
                " населения выбранной страны");
        }

        private void btnPopulationCountry_Click(object sender, EventArgs e)
        {
            comboBoxSelect.Items.Clear();
            if (listBoxCountry.SelectedItem == null)
                MessageBox.Show("Не выбрана страна");
            if (listBoxCountry.Items == null )
                MessageBox.Show("Список стран пуст!");
            if (listBoxCountry.SelectedItem != null)
                try
                {
                    foreach (var item in db.Countries)
                    {
                        if (listBoxCountry.SelectedItem.ToString() == item.Name)
                        {
                            comboBoxSelect.Items.Add(item.Population.ToString());
                        }
                    }
                    //var c = (from country in db.Countries
                    //            where country.Name == listBoxCountry.SelectedItem.ToString()
                    //         select country.Population).ToString());
                    //comboBoxSelect.Items.Add(c);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

        }

        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnClear, "Oчистить информацию для показа");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboBoxSelect.Items.Clear();
        }
    }
    }

