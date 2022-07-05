
namespace WinFormsApp02._07._22.View
{
    partial class FormEditCity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNewPopulation = new System.Windows.Forms.TextBox();
            this.txtNewCode = new System.Windows.Forms.TextBox();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPopulationCity = new System.Windows.Forms.TextBox();
            this.txtCodeCity = new System.Windows.Forms.TextBox();
            this.txtNameCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNewPopulation
            // 
            this.txtNewPopulation.Location = new System.Drawing.Point(245, 127);
            this.txtNewPopulation.Name = "txtNewPopulation";
            this.txtNewPopulation.Size = new System.Drawing.Size(100, 23);
            this.txtNewPopulation.TabIndex = 25;
            this.txtNewPopulation.TextChanged += new System.EventHandler(this.txtNewPopulation_TextChanged);
            // 
            // txtNewCode
            // 
            this.txtNewCode.Location = new System.Drawing.Point(245, 88);
            this.txtNewCode.Name = "txtNewCode";
            this.txtNewCode.Size = new System.Drawing.Size(100, 23);
            this.txtNewCode.TabIndex = 24;
            this.txtNewCode.TextChanged += new System.EventHandler(this.txtNewCode_TextChanged);
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(245, 48);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(100, 23);
            this.txtNewName.TabIndex = 23;
            this.txtNewName.TextChanged += new System.EventHandler(this.txtNewName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Новые данные";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Старые данные";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(129, 208);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 20;
            this.btnChange.Text = "Отменить ";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(270, 208);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPopulationCity
            // 
            this.txtPopulationCity.Enabled = false;
            this.txtPopulationCity.Location = new System.Drawing.Point(104, 127);
            this.txtPopulationCity.Name = "txtPopulationCity";
            this.txtPopulationCity.Size = new System.Drawing.Size(100, 23);
            this.txtPopulationCity.TabIndex = 18;
            // 
            // txtCodeCity
            // 
            this.txtCodeCity.Enabled = false;
            this.txtCodeCity.Location = new System.Drawing.Point(104, 88);
            this.txtCodeCity.Name = "txtCodeCity";
            this.txtCodeCity.Size = new System.Drawing.Size(100, 23);
            this.txtCodeCity.TabIndex = 17;
            // 
            // txtNameCity
            // 
            this.txtNameCity.Enabled = false;
            this.txtNameCity.Location = new System.Drawing.Point(104, 48);
            this.txtNameCity.Name = "txtNameCity";
            this.txtNameCity.Size = new System.Drawing.Size(100, 23);
            this.txtNameCity.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Население";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Индекс";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Название";
            // 
            // FormEditCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 234);
            this.Controls.Add(this.txtNewPopulation);
            this.Controls.Add(this.txtNewCode);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPopulationCity);
            this.Controls.Add(this.txtCodeCity);
            this.Controls.Add(this.txtNameCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEditCity";
            this.Text = "FormEditCity";
            this.Load += new System.EventHandler(this.FormEditCity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewPopulation;
        private System.Windows.Forms.TextBox txtNewCode;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox txtPopulationCity;
        public System.Windows.Forms.TextBox txtCodeCity;
        public System.Windows.Forms.TextBox txtNameCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}