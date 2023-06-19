namespace kursovaya_fordfulkerson
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCount = new System.Windows.Forms.Button();
            this.buttonEmployees = new System.Windows.Forms.Button();
            this.panelEmployees = new System.Windows.Forms.Panel();
            this.buttonClearEmployees = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonImport = new System.Windows.Forms.Button();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desiredJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDownload = new System.Windows.Forms.Panel();
            this.labelNotification = new System.Windows.Forms.Label();
            this.buttonDownloadCount = new System.Windows.Forms.Button();
            this.buttonDownloadEmployees = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelAddHeader = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.checkBoxMale = new System.Windows.Forms.CheckBox();
            this.checkBoxFemale = new System.Windows.Forms.CheckBox();
            this.comboBoxVacancy = new System.Windows.Forms.ComboBox();
            this.labelVacancy = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.panelResultCount = new System.Windows.Forms.Panel();
            this.buttonResults = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacancyName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacancyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelAddedVacancy = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.panelDownload.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.panelResultCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Teal;
            this.panelMenu.Controls.Add(this.buttonDownload);
            this.panelMenu.Controls.Add(this.buttonAdd);
            this.panelMenu.Controls.Add(this.buttonCount);
            this.panelMenu.Controls.Add(this.buttonEmployees);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 313);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonDownload
            // 
            this.buttonDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDownload.FlatAppearance.BorderSize = 0;
            this.buttonDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownload.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDownload.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDownload.Image = global::kursovaya_fordfulkerson.Properties.Resources.icons8_download_50;
            this.buttonDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDownload.Location = new System.Drawing.Point(0, 180);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(220, 60);
            this.buttonDownload.TabIndex = 4;
            this.buttonDownload.Text = "Выгрузка";
            this.buttonDownload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAdd.Image = global::kursovaya_fordfulkerson.Properties.Resources.icons8_add_50;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(0, 120);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(220, 60);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить работника";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCount
            // 
            this.buttonCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCount.FlatAppearance.BorderSize = 0;
            this.buttonCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCount.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCount.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCount.Image = global::kursovaya_fordfulkerson.Properties.Resources.icons8_count_50;
            this.buttonCount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCount.Location = new System.Drawing.Point(0, 60);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(220, 60);
            this.buttonCount.TabIndex = 2;
            this.buttonCount.Text = "Расчет";
            this.buttonCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEmployees.FlatAppearance.BorderSize = 0;
            this.buttonEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployees.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEmployees.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonEmployees.Image = global::kursovaya_fordfulkerson.Properties.Resources.icons8_employee_50;
            this.buttonEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmployees.Location = new System.Drawing.Point(0, 0);
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Size = new System.Drawing.Size(220, 60);
            this.buttonEmployees.TabIndex = 1;
            this.buttonEmployees.Text = "Работники";
            this.buttonEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEmployees.UseVisualStyleBackColor = true;
            this.buttonEmployees.Click += new System.EventHandler(this.buttonEmployees_Click);
            // 
            // panelEmployees
            // 
            this.panelEmployees.Controls.Add(this.buttonClearEmployees);
            this.panelEmployees.Controls.Add(this.label3);
            this.panelEmployees.Controls.Add(this.buttonImport);
            this.panelEmployees.Controls.Add(this.dataGridViewEmployees);
            this.panelEmployees.Location = new System.Drawing.Point(220, 0);
            this.panelEmployees.Name = "panelEmployees";
            this.panelEmployees.Size = new System.Drawing.Size(761, 313);
            this.panelEmployees.TabIndex = 1;
            // 
            // buttonClearEmployees
            // 
            this.buttonClearEmployees.BackColor = System.Drawing.Color.Teal;
            this.buttonClearEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearEmployees.FlatAppearance.BorderSize = 0;
            this.buttonClearEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearEmployees.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearEmployees.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonClearEmployees.Location = new System.Drawing.Point(205, 276);
            this.buttonClearEmployees.Name = "buttonClearEmployees";
            this.buttonClearEmployees.Size = new System.Drawing.Size(120, 25);
            this.buttonClearEmployees.TabIndex = 15;
            this.buttonClearEmployees.Text = "Очистить";
            this.buttonClearEmployees.UseVisualStyleBackColor = false;
            this.buttonClearEmployees.Click += new System.EventHandler(this.buttonClearEmployees_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(18, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Работники";
            // 
            // buttonImport
            // 
            this.buttonImport.BackColor = System.Drawing.Color.Teal;
            this.buttonImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonImport.FlatAppearance.BorderSize = 0;
            this.buttonImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImport.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonImport.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonImport.Location = new System.Drawing.Point(344, 276);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(120, 25);
            this.buttonImport.TabIndex = 14;
            this.buttonImport.Text = "Импорт";
            this.buttonImport.UseVisualStyleBackColor = false;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstName,
            this.lastName,
            this.gender,
            this.desiredJob});
            this.dataGridViewEmployees.Location = new System.Drawing.Point(18, 32);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.Size = new System.Drawing.Size(446, 225);
            this.dataGridViewEmployees.TabIndex = 3;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "Имя";
            this.firstName.Name = "firstName";
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Фамилия";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.HeaderText = "Пол";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // desiredJob
            // 
            this.desiredJob.HeaderText = "Желаемая вакансия";
            this.desiredJob.Name = "desiredJob";
            this.desiredJob.ReadOnly = true;
            // 
            // panelDownload
            // 
            this.panelDownload.Controls.Add(this.labelNotification);
            this.panelDownload.Controls.Add(this.buttonDownloadCount);
            this.panelDownload.Controls.Add(this.buttonDownloadEmployees);
            this.panelDownload.Controls.Add(this.label4);
            this.panelDownload.Location = new System.Drawing.Point(220, 0);
            this.panelDownload.Name = "panelDownload";
            this.panelDownload.Size = new System.Drawing.Size(761, 313);
            this.panelDownload.TabIndex = 15;
            // 
            // labelNotification
            // 
            this.labelNotification.AutoSize = true;
            this.labelNotification.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNotification.Location = new System.Drawing.Point(80, 196);
            this.labelNotification.Name = "labelNotification";
            this.labelNotification.Size = new System.Drawing.Size(0, 16);
            this.labelNotification.TabIndex = 16;
            // 
            // buttonDownloadCount
            // 
            this.buttonDownloadCount.BackColor = System.Drawing.Color.Teal;
            this.buttonDownloadCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDownloadCount.FlatAppearance.BorderSize = 0;
            this.buttonDownloadCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownloadCount.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDownloadCount.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDownloadCount.Location = new System.Drawing.Point(222, 153);
            this.buttonDownloadCount.Name = "buttonDownloadCount";
            this.buttonDownloadCount.Size = new System.Drawing.Size(146, 25);
            this.buttonDownloadCount.TabIndex = 15;
            this.buttonDownloadCount.Text = "Скачать расчет";
            this.buttonDownloadCount.UseVisualStyleBackColor = false;
            this.buttonDownloadCount.EnabledChanged += new System.EventHandler(this.buttonDownloadCount_EnabledChanged);
            this.buttonDownloadCount.Click += new System.EventHandler(this.buttonDownloadCount_Click);
            // 
            // buttonDownloadEmployees
            // 
            this.buttonDownloadEmployees.BackColor = System.Drawing.Color.Teal;
            this.buttonDownloadEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDownloadEmployees.FlatAppearance.BorderSize = 0;
            this.buttonDownloadEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownloadEmployees.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDownloadEmployees.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDownloadEmployees.Location = new System.Drawing.Point(222, 105);
            this.buttonDownloadEmployees.Name = "buttonDownloadEmployees";
            this.buttonDownloadEmployees.Size = new System.Drawing.Size(146, 25);
            this.buttonDownloadEmployees.TabIndex = 14;
            this.buttonDownloadEmployees.Text = "Скачать работников";
            this.buttonDownloadEmployees.UseVisualStyleBackColor = false;
            this.buttonDownloadEmployees.EnabledChanged += new System.EventHandler(this.buttonDownloadEmployees_EnabledChanged);
            this.buttonDownloadEmployees.Click += new System.EventHandler(this.buttonDownloadEmployees_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(18, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Выгрузка";
            // 
            // labelAddHeader
            // 
            this.labelAddHeader.AutoSize = true;
            this.labelAddHeader.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddHeader.Location = new System.Drawing.Point(18, 9);
            this.labelAddHeader.Name = "labelAddHeader";
            this.labelAddHeader.Size = new System.Drawing.Size(164, 20);
            this.labelAddHeader.TabIndex = 0;
            this.labelAddHeader.Text = "Добавить работника";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstName.Location = new System.Drawing.Point(19, 69);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(220, 18);
            this.textBoxFirstName.TabIndex = 1;
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxFirstName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Пол";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLastName.Location = new System.Drawing.Point(293, 69);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(220, 18);
            this.textBoxLastName.TabIndex = 3;
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastName.Location = new System.Drawing.Point(293, 50);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(56, 16);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Фамилия";
            // 
            // checkBoxMale
            // 
            this.checkBoxMale.AutoSize = true;
            this.checkBoxMale.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxMale.Location = new System.Drawing.Point(22, 129);
            this.checkBoxMale.Name = "checkBoxMale";
            this.checkBoxMale.Size = new System.Drawing.Size(78, 20);
            this.checkBoxMale.TabIndex = 7;
            this.checkBoxMale.Text = "Мужской";
            this.checkBoxMale.UseVisualStyleBackColor = true;
            this.checkBoxMale.CheckedChanged += new System.EventHandler(this.checkBoxMale_CheckedChanged_1);
            // 
            // checkBoxFemale
            // 
            this.checkBoxFemale.AutoSize = true;
            this.checkBoxFemale.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxFemale.Location = new System.Drawing.Point(123, 129);
            this.checkBoxFemale.Name = "checkBoxFemale";
            this.checkBoxFemale.Size = new System.Drawing.Size(75, 20);
            this.checkBoxFemale.TabIndex = 8;
            this.checkBoxFemale.Text = "Женский";
            this.checkBoxFemale.UseVisualStyleBackColor = true;
            this.checkBoxFemale.CheckedChanged += new System.EventHandler(this.checkBoxFemale_CheckedChanged);
            // 
            // comboBoxVacancy
            // 
            this.comboBoxVacancy.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxVacancy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVacancy.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxVacancy.FormattingEnabled = true;
            this.comboBoxVacancy.Location = new System.Drawing.Point(293, 129);
            this.comboBoxVacancy.Name = "comboBoxVacancy";
            this.comboBoxVacancy.Size = new System.Drawing.Size(220, 25);
            this.comboBoxVacancy.TabIndex = 10;
            this.comboBoxVacancy.SelectedIndexChanged += new System.EventHandler(this.comboBoxVacancy_SelectedIndexChanged);
            // 
            // labelVacancy
            // 
            this.labelVacancy.AutoSize = true;
            this.labelVacancy.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVacancy.Location = new System.Drawing.Point(293, 110);
            this.labelVacancy.Name = "labelVacancy";
            this.labelVacancy.Size = new System.Drawing.Size(114, 16);
            this.labelVacancy.TabIndex = 11;
            this.labelVacancy.Text = "Желаемая вакансия";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Teal;
            this.buttonSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSubmit.Enabled = false;
            this.buttonSubmit.FlatAppearance.BorderSize = 0;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSubmit.Location = new System.Drawing.Point(123, 263);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(120, 25);
            this.buttonSubmit.TabIndex = 12;
            this.buttonSubmit.Text = "Создать";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.EnabledChanged += new System.EventHandler(this.buttonSubmit_EnabledChanged);
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Teal;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonClear.Location = new System.Drawing.Point(293, 263);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(120, 25);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.labelAddedVacancy);
            this.panelAdd.Controls.Add(this.label6);
            this.panelAdd.Controls.Add(this.button1);
            this.panelAdd.Controls.Add(this.buttonClear);
            this.panelAdd.Controls.Add(this.buttonSubmit);
            this.panelAdd.Controls.Add(this.labelVacancy);
            this.panelAdd.Controls.Add(this.comboBoxVacancy);
            this.panelAdd.Controls.Add(this.checkBoxFemale);
            this.panelAdd.Controls.Add(this.checkBoxMale);
            this.panelAdd.Controls.Add(this.labelLastName);
            this.panelAdd.Controls.Add(this.textBoxLastName);
            this.panelAdd.Controls.Add(this.label1);
            this.panelAdd.Controls.Add(this.label2);
            this.panelAdd.Controls.Add(this.textBoxFirstName);
            this.panelAdd.Controls.Add(this.labelAddHeader);
            this.panelAdd.Location = new System.Drawing.Point(220, 0);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(761, 313);
            this.panelAdd.TabIndex = 1;
            // 
            // panelResultCount
            // 
            this.panelResultCount.Controls.Add(this.buttonResults);
            this.panelResultCount.Controls.Add(this.label5);
            this.panelResultCount.Controls.Add(this.dataGridViewResults);
            this.panelResultCount.Location = new System.Drawing.Point(220, 0);
            this.panelResultCount.Name = "panelResultCount";
            this.panelResultCount.Size = new System.Drawing.Size(761, 313);
            this.panelResultCount.TabIndex = 14;
            // 
            // buttonResults
            // 
            this.buttonResults.BackColor = System.Drawing.Color.Teal;
            this.buttonResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResults.FlatAppearance.BorderSize = 0;
            this.buttonResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResults.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResults.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonResults.Location = new System.Drawing.Point(205, 276);
            this.buttonResults.Name = "buttonResults";
            this.buttonResults.Size = new System.Drawing.Size(120, 25);
            this.buttonResults.TabIndex = 13;
            this.buttonResults.Text = "Рассчитать";
            this.buttonResults.UseVisualStyleBackColor = false;
            this.buttonResults.EnabledChanged += new System.EventHandler(this.buttonResults_EnabledChanged);
            this.buttonResults.Click += new System.EventHandler(this.buttonResults_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Расчет";
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.employeeFirstName,
            this.vacancyName1});
            this.dataGridViewResults.Location = new System.Drawing.Point(88, 35);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.Size = new System.Drawing.Size(348, 235);
            this.dataGridViewResults.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID работника";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // employeeFirstName
            // 
            this.employeeFirstName.HeaderText = "Имя работника";
            this.employeeFirstName.Name = "employeeFirstName";
            this.employeeFirstName.ReadOnly = true;
            // 
            // vacancyName1
            // 
            this.vacancyName1.HeaderText = "Вакансия";
            this.vacancyName1.Name = "vacancyName1";
            this.vacancyName1.ReadOnly = true;
            // 
            // vacancyName
            // 
            this.vacancyName.HeaderText = "Вакансия";
            this.vacancyName.Name = "vacancyName";
            // 
            // employeeName
            // 
            this.employeeName.HeaderText = "Имя работника";
            this.employeeName.Name = "employeeName";
            // 
            // employeeID
            // 
            this.employeeID.HeaderText = "ID работника";
            this.employeeID.Name = "employeeID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(293, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 25);
            this.button1.TabIndex = 14;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.EnabledChanged += new System.EventHandler(this.button1_EnabledChanged);

            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(18, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Добавленные вакансии";
            // 
            // labelAddedVacancy
            // 
            this.labelAddedVacancy.AutoSize = true;
            this.labelAddedVacancy.BackColor = System.Drawing.Color.CadetBlue;
            this.labelAddedVacancy.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddedVacancy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAddedVacancy.Location = new System.Drawing.Point(19, 196);
            this.labelAddedVacancy.Name = "labelAddedVacancy";
            this.labelAddedVacancy.Size = new System.Drawing.Size(0, 16);
            this.labelAddedVacancy.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(761, 313);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.panelEmployees);
            this.Controls.Add(this.panelDownload);
            this.Controls.Add(this.panelResultCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelEmployees.ResumeLayout(false);
            this.panelEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.panelDownload.ResumeLayout(false);
            this.panelDownload.PerformLayout();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelResultCount.ResumeLayout(false);
            this.panelResultCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonEmployees;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.Panel panelEmployees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn desiredJob;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Panel panelDownload;
        private System.Windows.Forms.Button buttonDownloadCount;
        private System.Windows.Forms.Button buttonDownloadEmployees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelAddHeader;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.CheckBox checkBoxMale;
        private System.Windows.Forms.CheckBox checkBoxFemale;
        private System.Windows.Forms.ComboBox comboBoxVacancy;
        private System.Windows.Forms.Label labelVacancy;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacancyName;
        private System.Windows.Forms.Panel panelResultCount;
        private System.Windows.Forms.Button buttonResults;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacancyName1;
        private System.Windows.Forms.Label labelNotification;
        private System.Windows.Forms.Button buttonClearEmployees;
        private System.Windows.Forms.Label labelAddedVacancy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

