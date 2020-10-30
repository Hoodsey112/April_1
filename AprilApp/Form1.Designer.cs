namespace AprilApp
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addPersonBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.getPersonsBTN = new System.Windows.Forms.Button();
            this.settingsDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.columnsSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pswdTB = new AprilApp.CustomTextBox();
            this.loginTB = new AprilApp.CustomTextBox();
            this.patrNameTB = new AprilApp.CustomTextBox();
            this.firstNameTB = new AprilApp.CustomTextBox();
            this.lastNameTB = new AprilApp.CustomTextBox();
            this.customDataGridView1 = new AprilApp.CustomDataGridView();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createJsonBTN = new System.Windows.Forms.Button();
            this.loadJsonBTN = new System.Windows.Forms.Button();
            this.settingsDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Disconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addPersonBTN
            // 
            this.addPersonBTN.Location = new System.Drawing.Point(12, 70);
            this.addPersonBTN.Name = "addPersonBTN";
            this.addPersonBTN.Size = new System.Drawing.Size(75, 23);
            this.addPersonBTN.TabIndex = 2;
            this.addPersonBTN.Text = "AddPerson";
            this.addPersonBTN.UseVisualStyleBackColor = true;
            this.addPersonBTN.Click += new System.EventHandler(this.addPersonBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата рождения";
            // 
            // birthDate
            // 
            this.birthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDate.Location = new System.Drawing.Point(215, 85);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(83, 20);
            this.birthDate.TabIndex = 10;
            // 
            // getPersonsBTN
            // 
            this.getPersonsBTN.Location = new System.Drawing.Point(12, 99);
            this.getPersonsBTN.Name = "getPersonsBTN";
            this.getPersonsBTN.Size = new System.Drawing.Size(75, 23);
            this.getPersonsBTN.TabIndex = 12;
            this.getPersonsBTN.Text = "GetPersons";
            this.getPersonsBTN.UseVisualStyleBackColor = true;
            this.getPersonsBTN.Click += new System.EventHandler(this.getPersonsBTN_Click);
            // 
            // settingsDGV
            // 
            this.settingsDGV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.columnsSettings});
            this.settingsDGV.Name = "settingsDGV";
            this.settingsDGV.Size = new System.Drawing.Size(174, 26);
            // 
            // columnsSettings
            // 
            this.columnsSettings.Name = "columnsSettings";
            this.columnsSettings.Size = new System.Drawing.Size(173, 22);
            this.columnsSettings.Text = "Настройки колонок";
            this.columnsSettings.Click += new System.EventHandler(this.columnsSettings_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Пароль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Логин";
            // 
            // pswdTB
            // 
            this.pswdTB.EmptyDataCheck = true;
            this.pswdTB.Location = new System.Drawing.Point(416, 32);
            this.pswdTB.Name = "pswdTB";
            this.pswdTB.Size = new System.Drawing.Size(130, 20);
            this.pswdTB.TabIndex = 23;
            // 
            // loginTB
            // 
            this.loginTB.EmptyDataCheck = true;
            this.loginTB.Location = new System.Drawing.Point(416, 6);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(130, 20);
            this.loginTB.TabIndex = 22;
            // 
            // patrNameTB
            // 
            this.patrNameTB.EmptyDataCheck = true;
            this.patrNameTB.Location = new System.Drawing.Point(215, 58);
            this.patrNameTB.Name = "patrNameTB";
            this.patrNameTB.Size = new System.Drawing.Size(130, 20);
            this.patrNameTB.TabIndex = 19;
            // 
            // firstNameTB
            // 
            this.firstNameTB.EmptyDataCheck = true;
            this.firstNameTB.Location = new System.Drawing.Point(215, 32);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(130, 20);
            this.firstNameTB.TabIndex = 18;
            // 
            // lastNameTB
            // 
            this.lastNameTB.EmptyDataCheck = true;
            this.lastNameTB.Location = new System.Drawing.Point(215, 6);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(130, 20);
            this.lastNameTB.TabIndex = 16;
            // 
            // customDataGridView1
            // 
            this.customDataGridView1.AllowUserToAddRows = false;
            this.customDataGridView1.AllowUserToDeleteRows = false;
            this.customDataGridView1.AllowUserToOrderColumns = true;
            this.customDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.customDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lastName,
            this.firstName,
            this.patrName,
            this.bDate,
            this.login,
            this.password});
            this.customDataGridView1.ContextMenuStrip = this.settingsDGV;
            this.customDataGridView1.Location = new System.Drawing.Point(12, 128);
            this.customDataGridView1.Name = "customDataGridView1";
            this.customDataGridView1.RowHeadersVisible = false;
            this.customDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customDataGridView1.Size = new System.Drawing.Size(776, 310);
            this.customDataGridView1.TabIndex = 15;
            this.customDataGridView1.VirtualMode = true;
            this.customDataGridView1.ColumnDisplayIndexChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.customDataGridView1_ColumnDisplayIndexChanged);
            this.customDataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CustomDataGridView1_ColumnHeaderMouseClick);
            this.customDataGridView1.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.customDataGridView1_ColumnWidthChanged);
            this.customDataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.customDataGridView1_KeyDown);
            this.customDataGridView1.MouseEnter += new System.EventHandler(this.customDataGridView1_MouseEnter);
            this.customDataGridView1.MouseLeave += new System.EventHandler(this.customDataGridView1_MouseLeave);
            // 
            // lastName
            // 
            this.lastName.DataPropertyName = "lastName";
            this.lastName.HeaderText = "Фамилия";
            this.lastName.Name = "lastName";
            // 
            // firstName
            // 
            this.firstName.DataPropertyName = "firstName";
            this.firstName.HeaderText = "Имя";
            this.firstName.Name = "firstName";
            // 
            // patrName
            // 
            this.patrName.DataPropertyName = "patrName";
            this.patrName.HeaderText = "Отчество";
            this.patrName.Name = "patrName";
            // 
            // bDate
            // 
            this.bDate.DataPropertyName = "bDate";
            this.bDate.HeaderText = "Дата рождения";
            this.bDate.Name = "bDate";
            // 
            // login
            // 
            this.login.DataPropertyName = "login";
            this.login.HeaderText = "Логин";
            this.login.Name = "login";
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Пароль";
            this.password.Name = "password";
            // 
            // createJsonBTN
            // 
            this.createJsonBTN.Location = new System.Drawing.Point(661, 8);
            this.createJsonBTN.Name = "createJsonBTN";
            this.createJsonBTN.Size = new System.Drawing.Size(127, 23);
            this.createJsonBTN.TabIndex = 24;
            this.createJsonBTN.Text = "Сформировать JSON";
            this.createJsonBTN.UseVisualStyleBackColor = true;
            this.createJsonBTN.Click += new System.EventHandler(this.createJsonBTN_Click);
            // 
            // loadJsonBTN
            // 
            this.loadJsonBTN.Location = new System.Drawing.Point(661, 37);
            this.loadJsonBTN.Name = "loadJsonBTN";
            this.loadJsonBTN.Size = new System.Drawing.Size(127, 23);
            this.loadJsonBTN.TabIndex = 25;
            this.loadJsonBTN.Text = "Загрузить JSON";
            this.loadJsonBTN.UseVisualStyleBackColor = true;
            this.loadJsonBTN.Click += new System.EventHandler(this.loadJsonBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadJsonBTN);
            this.Controls.Add(this.createJsonBTN);
            this.Controls.Add(this.pswdTB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.patrNameTB);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.customDataGridView1);
            this.Controls.Add(this.getPersonsBTN);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addPersonBTN);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.settingsDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addPersonBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.Button getPersonsBTN;
        private System.Windows.Forms.ContextMenuStrip settingsDGV;
        private System.Windows.Forms.ToolStripMenuItem columnsSettings;
        public CustomDataGridView customDataGridView1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private CustomTextBox lastNameTB;
        private CustomTextBox firstNameTB;
        private CustomTextBox patrNameTB;
        private CustomTextBox pswdTB;
        private CustomTextBox loginTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn patrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.Button createJsonBTN;
        private System.Windows.Forms.Button loadJsonBTN;
    }
}

