using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp02._07._22.View
{
    public partial class FormEditCountry : Form
    {
        public FormEditCountry()
        {
            InitializeComponent();
        }
        public FormEditCountry(Form form)
        {
            InitializeComponent();
            
        }

        private void FormEditCountry_Load(object sender, EventArgs e)
        {
            BackColor = Color.LightGray;
            btnChange.Enabled = true;
            btnSave.Enabled = false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtNewName.Text!=null&&txtNewCode.Text!=null&&txtNewPopulation.Text!=null)
            {
                FormWorld.dataCountry.Name = txtNewName.Text;
                FormWorld.dataCountry.Code = Convert.ToInt32(txtNewCode.Text);
                FormWorld.dataCountry.Population = Convert.ToInt32(txtNewPopulation.Text);
                foreach(var item in FormWorld.db.Countries)
                {
                    if(txtNameCountry.Text==item.Name)
                    {
                        item.Name = FormWorld.dataCountry.Name;
                        item.InternationalCode = FormWorld.dataCountry.Code;
                        item.Population = FormWorld.dataCountry.Population;
                    }
                    
                }
                
            }
             FormWorld.db.SaveChanges();
            MessageBox.Show("Обновлённые данные сохранены");
            Close();
        }

        private void txtNewName_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void txtNewCode_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void txtNewPopulation_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }
    }
}
