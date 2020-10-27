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
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.patrName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.getPersonsBTN = new System.Windows.Forms.Button();
            this.delPersonBTN = new System.Windows.Forms.Button();
            this.settingsDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.columnsSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.customDataGridView1 = new AprilApp.CustomDataGridView();
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
            this.label1.Location = new System.Drawing.Point(232, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фамилия";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(294, 6);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(130, 20);
            this.lastName.TabIndex = 4;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(294, 32);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(130, 20);
            this.firstName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя";
            // 
            // patrName
            // 
            this.patrName.Location = new System.Drawing.Point(294, 59);
            this.patrName.Name = "patrName";
            this.patrName.Size = new System.Drawing.Size(130, 20);
            this.patrName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата рождения";
            // 
            // birthDate
            // 
            this.birthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDate.Location = new System.Drawing.Point(294, 85);
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
            // delPersonBTN
            // 
            this.delPersonBTN.Cursor = System.Windows.Forms.Cursors.Default;
            this.delPersonBTN.Location = new System.Drawing.Point(93, 70);
            this.delPersonBTN.Name = "delPersonBTN";
            this.delPersonBTN.Size = new System.Drawing.Size(75, 23);
            this.delPersonBTN.TabIndex = 13;
            this.delPersonBTN.Text = "DelPerson";
            this.delPersonBTN.UseVisualStyleBackColor = true;
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
            // customDataGridView1
            // 
            this.customDataGridView1.AllowUserToAddRows = false;
            this.customDataGridView1.AllowUserToDeleteRows = false;
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
            this.customDataGridView1.ContextMenuStrip = this.settingsDGV;
            this.customDataGridView1.Location = new System.Drawing.Point(12, 128);
            this.customDataGridView1.Name = "customDataGridView1";
            this.customDataGridView1.RowHeadersVisible = false;
            this.customDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customDataGridView1.Size = new System.Drawing.Size(776, 310);
            this.customDataGridView1.TabIndex = 15;
            this.customDataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CustomDataGridView1_ColumnHeaderMouseClick);
            this.customDataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.customDataGridView1_KeyDown);
            this.customDataGridView1.MouseEnter += new System.EventHandler(this.customDataGridView1_MouseEnter);
            this.customDataGridView1.MouseLeave += new System.EventHandler(this.customDataGridView1_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customDataGridView1);
            this.Controls.Add(this.delPersonBTN);
            this.Controls.Add(this.getPersonsBTN);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.patrName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastName);
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
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox patrName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.Button getPersonsBTN;
        private System.Windows.Forms.Button delPersonBTN;
        private System.Windows.Forms.ContextMenuStrip settingsDGV;
        private System.Windows.Forms.ToolStripMenuItem columnsSettings;
        public CustomDataGridView customDataGridView1;
    }
}

