
namespace WinFormsApp02._07._22
{
    partial class FormWorld
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBoxCountry = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtPopulation = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.labelPopulation = new System.Windows.Forms.Label();
            this.labelList = new System.Windows.Forms.Label();
            this.listBoxCity = new System.Windows.Forms.ListBox();
            this.labelListCity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPopulationCity = new System.Windows.Forms.TextBox();
            this.txtPostCard = new System.Windows.Forms.TextBox();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.txtNameCity = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemoveCountry = new System.Windows.Forms.Button();
            this.btnRemoveCity = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnEditCountry = new System.Windows.Forms.Button();
            this.btnEditCity = new System.Windows.Forms.Button();
            this.btnShowMillion = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnPopulationCountry = new System.Windows.Forms.Button();
            this.btnShowCityInCountry = new System.Windows.Forms.Button();
            this.comboBoxSelect = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxCountry
            // 
            this.listBoxCountry.FormattingEnabled = true;
            this.listBoxCountry.ItemHeight = 15;
            this.listBoxCountry.Location = new System.Drawing.Point(148, 23);
            this.listBoxCountry.Name = "listBoxCountry";
            this.listBoxCountry.Size = new System.Drawing.Size(120, 259);
            this.listBoxCountry.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(148, 303);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 23);
            this.txtName.TabIndex = 1;
            this.txtName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtName_MouseClick);
            this.txtName.DoubleClick += new System.EventHandler(this.txtName_DoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(148, 415);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить страну";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(148, 333);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(120, 23);
            this.txtCode.TabIndex = 3;
            this.txtCode.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCode_MouseClick);
            this.txtCode.DoubleClick += new System.EventHandler(this.txtCode_DoubleClick);
            // 
            // txtPopulation
            // 
            this.txtPopulation.Location = new System.Drawing.Point(148, 362);
            this.txtPopulation.Name = "txtPopulation";
            this.txtPopulation.Size = new System.Drawing.Size(120, 23);
            this.txtPopulation.TabIndex = 4;
            this.txtPopulation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPopulation_MouseClick);
            this.txtPopulation.DoubleClick += new System.EventHandler(this.txtPopulation_DoubleClick);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 303);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 15);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Название";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(3, 332);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(123, 15);
            this.labelCode.TabIndex = 6;
            this.labelCode.Text = "Международный код";
            // 
            // labelPopulation
            // 
            this.labelPopulation.AutoSize = true;
            this.labelPopulation.Location = new System.Drawing.Point(3, 362);
            this.labelPopulation.Name = "labelPopulation";
            this.labelPopulation.Size = new System.Drawing.Size(67, 15);
            this.labelPopulation.TabIndex = 7;
            this.labelPopulation.Text = "Население";
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Location = new System.Drawing.Point(3, 23);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(82, 15);
            this.labelList.TabIndex = 8;
            this.labelList.Text = "Список стран";
            // 
            // listBoxCity
            // 
            this.listBoxCity.FormattingEnabled = true;
            this.listBoxCity.ItemHeight = 15;
            this.listBoxCity.Location = new System.Drawing.Point(462, 23);
            this.listBoxCity.Name = "listBoxCity";
            this.listBoxCity.Size = new System.Drawing.Size(120, 259);
            this.listBoxCity.TabIndex = 9;
            this.listBoxCity.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBoxCity_MouseMove);
            // 
            // labelListCity
            // 
            this.labelListCity.AutoSize = true;
            this.labelListCity.Location = new System.Drawing.Point(352, 22);
            this.labelListCity.Name = "labelListCity";
            this.labelListCity.Size = new System.Drawing.Size(96, 15);
            this.labelListCity.TabIndex = 10;
            this.labelListCity.Text = "Список городов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Население";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Почтовый индекс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Название";
            // 
            // txtPopulationCity
            // 
            this.txtPopulationCity.Location = new System.Drawing.Point(464, 362);
            this.txtPopulationCity.Name = "txtPopulationCity";
            this.txtPopulationCity.Size = new System.Drawing.Size(120, 23);
            this.txtPopulationCity.TabIndex = 14;
            this.txtPopulationCity.DoubleClick += new System.EventHandler(this.txtPopulationCity_DoubleClick);
            // 
            // txtPostCard
            // 
            this.txtPostCard.Location = new System.Drawing.Point(464, 333);
            this.txtPostCard.Name = "txtPostCard";
            this.txtPostCard.Size = new System.Drawing.Size(120, 23);
            this.txtPostCard.TabIndex = 13;
            this.txtPostCard.DoubleClick += new System.EventHandler(this.txtPostCard_DoubleClick);
            // 
            // btnAddCity
            // 
            this.btnAddCity.Location = new System.Drawing.Point(464, 415);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(120, 23);
            this.btnAddCity.TabIndex = 12;
            this.btnAddCity.Text = "Добавить город";
            this.btnAddCity.UseVisualStyleBackColor = true;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // txtNameCity
            // 
            this.txtNameCity.Location = new System.Drawing.Point(464, 303);
            this.txtNameCity.Name = "txtNameCity";
            this.txtNameCity.Size = new System.Drawing.Size(120, 23);
            this.txtNameCity.TabIndex = 11;
            this.txtNameCity.DoubleClick += new System.EventHandler(this.txtNameCity_DoubleClick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(719, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemoveCountry
            // 
            this.btnRemoveCountry.Location = new System.Drawing.Point(319, 258);
            this.btnRemoveCountry.Name = "btnRemoveCountry";
            this.btnRemoveCountry.Size = new System.Drawing.Size(105, 23);
            this.btnRemoveCountry.TabIndex = 19;
            this.btnRemoveCountry.Text = "Удалить страну";
            this.btnRemoveCountry.UseVisualStyleBackColor = true;
            this.btnRemoveCountry.Click += new System.EventHandler(this.btnRemoveCountry_Click);
            // 
            // btnRemoveCity
            // 
            this.btnRemoveCity.Location = new System.Drawing.Point(622, 258);
            this.btnRemoveCity.Name = "btnRemoveCity";
            this.btnRemoveCity.Size = new System.Drawing.Size(100, 23);
            this.btnRemoveCity.TabIndex = 20;
            this.btnRemoveCity.Text = "Удалить город";
            this.btnRemoveCity.UseVisualStyleBackColor = true;
            this.btnRemoveCity.Click += new System.EventHandler(this.btnRemoveCity_Click);
            // 
            // btnEditCountry
            // 
            this.btnEditCountry.Location = new System.Drawing.Point(319, 227);
            this.btnEditCountry.Name = "btnEditCountry";
            this.btnEditCountry.Size = new System.Drawing.Size(105, 23);
            this.btnEditCountry.TabIndex = 21;
            this.btnEditCountry.Text = "Редактировать страну";
            this.btnEditCountry.UseVisualStyleBackColor = true;
            this.btnEditCountry.Click += new System.EventHandler(this.btnEditCountry_Click);
            // 
            // btnEditCity
            // 
            this.btnEditCity.Location = new System.Drawing.Point(622, 227);
            this.btnEditCity.Name = "btnEditCity";
            this.btnEditCity.Size = new System.Drawing.Size(100, 23);
            this.btnEditCity.TabIndex = 22;
            this.btnEditCity.Text = "Редактировать город";
            this.btnEditCity.UseVisualStyleBackColor = true;
            this.btnEditCity.Click += new System.EventHandler(this.btnEditCity_Click);
            // 
            // btnShowMillion
            // 
            this.btnShowMillion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnShowMillion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowMillion.Location = new System.Drawing.Point(622, 4);
            this.btnShowMillion.Name = "btnShowMillion";
            this.btnShowMillion.Size = new System.Drawing.Size(33, 23);
            this.btnShowMillion.TabIndex = 23;
            this.btnShowMillion.UseVisualStyleBackColor = false;
            this.btnShowMillion.Click += new System.EventHandler(this.btnShowMillion_Click);
            this.btnShowMillion.MouseEnter += new System.EventHandler(this.btnShowMillion_MouseEnter);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(700, 33);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(33, 23);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "O";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseEnter += new System.EventHandler(this.btnClear_MouseEnter);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(661, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(622, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnPopulationCountry
            // 
            this.btnPopulationCountry.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPopulationCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPopulationCountry.Location = new System.Drawing.Point(700, 4);
            this.btnPopulationCountry.Name = "btnPopulationCountry";
            this.btnPopulationCountry.Size = new System.Drawing.Size(33, 23);
            this.btnPopulationCountry.TabIndex = 27;
            this.btnPopulationCountry.UseVisualStyleBackColor = false;
            this.btnPopulationCountry.Click += new System.EventHandler(this.btnPopulationCountry_Click);
            this.btnPopulationCountry.MouseEnter += new System.EventHandler(this.btnPopulationCountry_MouseEnter);
            // 
            // btnShowCityInCountry
            // 
            this.btnShowCityInCountry.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnShowCityInCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCityInCountry.Location = new System.Drawing.Point(661, 4);
            this.btnShowCityInCountry.Name = "btnShowCityInCountry";
            this.btnShowCityInCountry.Size = new System.Drawing.Size(33, 23);
            this.btnShowCityInCountry.TabIndex = 28;
            this.btnShowCityInCountry.UseVisualStyleBackColor = false;
            this.btnShowCityInCountry.Click += new System.EventHandler(this.btnShowCityInCountry_Click);
            this.btnShowCityInCountry.MouseEnter += new System.EventHandler(this.btnShowCityInCountry_MouseEnter);
            // 
            // comboBoxSelect
            // 
            this.comboBoxSelect.FormattingEnabled = true;
            this.comboBoxSelect.Location = new System.Drawing.Point(622, 96);
            this.comboBoxSelect.Name = "comboBoxSelect";
            this.comboBoxSelect.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSelect.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(622, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "Информация для показа";
            // 
            // FormWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSelect);
            this.Controls.Add(this.btnShowCityInCountry);
            this.Controls.Add(this.btnPopulationCountry);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShowMillion);
            this.Controls.Add(this.btnEditCity);
            this.Controls.Add(this.btnEditCountry);
            this.Controls.Add(this.btnRemoveCity);
            this.Controls.Add(this.btnRemoveCountry);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPopulationCity);
            this.Controls.Add(this.txtPostCard);
            this.Controls.Add(this.btnAddCity);
            this.Controls.Add(this.txtNameCity);
            this.Controls.Add(this.labelListCity);
            this.Controls.Add(this.listBoxCity);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.labelPopulation);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txtPopulation);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.listBoxCountry);
            this.Name = "FormWorld";
            this.Text = "World";
            this.Load += new System.EventHandler(this.FormWorld_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCountry;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtPopulation;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelPopulation;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.ListBox listBoxCity;
        private System.Windows.Forms.Label labelListCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPopulationCity;
        private System.Windows.Forms.TextBox txtPostCard;
        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.TextBox txtNameCity;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemoveCountry;
        private System.Windows.Forms.Button btnRemoveCity;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnEditCountry;
        private System.Windows.Forms.Button btnEditCity;
        private System.Windows.Forms.Button btnShowMillion;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnPopulationCountry;
        private System.Windows.Forms.Button btnShowCityInCountry;
        private System.Windows.Forms.ComboBox comboBoxSelect;
        private System.Windows.Forms.Label label4;
    }
}

