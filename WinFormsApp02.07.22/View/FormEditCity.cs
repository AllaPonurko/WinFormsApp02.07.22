using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp02._07._22.View
{
    public partial class FormEditCity : Form
    {
        public FormEditCity()
        {
            InitializeComponent();
        }
        public FormEditCity(Form form)
        {
            InitializeComponent();
        }

        private void FormEditCity_Load(object sender, EventArgs e)
        {
            BackColor = Color.LightGray;
            btnChange.Enabled = true;
            btnSave.Enabled = false;
            txtCodeCity.Enabled = false;
            txtNameCity.Enabled = false;
            txtPopulationCity.Enabled = false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNewName.Text != null && txtNewCode.Text != null && txtNewPopulation.Text != null)
                {
                    FormWorld.dataCity.Name = txtNewName.Text;
                    FormWorld.dataCity.Code = Convert.ToInt32(txtNewCode.Text);
                    FormWorld.dataCity.Population = Convert.ToInt32(txtNewPopulation.Text);
                    foreach (var item in FormWorld.db.Cities)
                    {
                        if (txtNameCity.Text == item.Name)
                        {
                            item.Name = FormWorld.dataCity.Name;
                            item.Postcode = FormWorld.dataCity.Code;
                            item.Population = FormWorld.dataCity.Population;
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Не все данные отредактированы");
                    return;
                }
                FormWorld.db.SaveChanges();
                MessageBox.Show("Обновлённые данные сохранены");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
