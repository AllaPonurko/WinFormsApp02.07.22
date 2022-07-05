
namespace WinFormsApp02._07._22.View
{
    partial class FormEditCountry
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameCountry = new System.Windows.Forms.TextBox();
            this.txtCodeCountry = new System.Windows.Forms.TextBox();
            this.txtPopulationCountry = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.txtNewCode = new System.Windows.Forms.TextBox();
            this.txtNewPopulation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Штрих код";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Население";
            // 
            // txtNameCountry
            // 
            this.txtNameCountry.Enabled = false;
            this.txtNameCountry.Location = new System.Drawing.Point(83, 54);
            this.txtNameCountry.Name = "txtNameCountry";
            this.txtNameCountry.Size = new System.Drawing.Size(100, 23);
            this.txtNameCountry.TabIndex = 3;
            // 
            // txtCodeCountry
            // 
            this.txtCodeCountry.Enabled = false;
            this.txtCodeCountry.Location = new System.Drawing.Point(83, 94);
            this.txtCodeCountry.Name = "txtCodeCountry";
            this.txtCodeCountry.Size = new System.Drawing.Size(100, 23);
            this.txtCodeCountry.TabIndex = 4;
            // 
            // txtPopulationCountry
            // 
            this.txtPopulationCountry.Enabled = false;
            this.txtPopulationCountry.Location = new System.Drawing.Point(83, 133);
            this.txtPopulationCountry.Name = "txtPopulationCountry";
            this.txtPopulationCountry.Size = new System.Drawing.Size(100, 23);
            this.txtPopulationCountry.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(249, 214);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(108, 214);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "Отменить ";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Старые данные";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Новые данные";
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(224, 54);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(100, 23);
            this.txtNewName.TabIndex = 10;
            this.txtNewName.TextChanged += new System.EventHandler(this.txtNewName_TextChanged);
            // 
            // txtNewCode
            // 
            this.txtNewCode.Location = new System.Drawing.Point(224, 94);
            this.txtNewCode.Name = "txtNewCode";
            this.txtNewCode.Size = new System.Drawing.Size(100, 23);
            this.txtNewCode.TabIndex = 11;
            this.txtNewCode.TextChanged += new System.EventHandler(this.txtNewCode_TextChanged);
            // 
            // txtNewPopulation
            // 
            this.txtNewPopulation.Location = new System.Drawing.Point(224, 133);
            this.txtNewPopulation.Name = "txtNewPopulation";
            this.txtNewPopulation.Size = new System.Drawing.Size(100, 23);
            this.txtNewPopulation.TabIndex = 12;
            this.txtNewPopulation.TextChanged += new System.EventHandler(this.txtNewPopulation_TextChanged);
            // 
            // FormEditCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 261);
            this.Controls.Add(this.txtNewPopulation);
            this.Controls.Add(this.txtNewCode);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPopulationCountry);
            this.Controls.Add(this.txtCodeCountry);
            this.Controls.Add(this.txtNameCountry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEditCountry";
            this.Text = "Редактирование страны";
            this.Load += new System.EventHandler(this.FormEditCountry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnChange;
        public System.Windows.Forms.TextBox txtNameCountry;
        public System.Windows.Forms.TextBox txtCodeCountry;
        public System.Windows.Forms.TextBox txtPopulationCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.TextBox txtNewCode;
        private System.Windows.Forms.TextBox txtNewPopulation;
    }
}