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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.getPersonsBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Disconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addPersonBTN
            // 
            this.addPersonBTN.Location = new System.Drawing.Point(108, 216);
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
            this.label1.Location = new System.Drawing.Point(264, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фамилия";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(326, 80);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(283, 20);
            this.lastName.TabIndex = 4;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(326, 106);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(283, 20);
            this.firstName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя";
            // 
            // patrName
            // 
            this.patrName.Location = new System.Drawing.Point(326, 133);
            this.patrName.Name = "patrName";
            this.patrName.Size = new System.Drawing.Size(283, 20);
            this.patrName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата рождения";
            // 
            // birthDate
            // 
            this.birthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDate.Location = new System.Drawing.Point(326, 159);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(83, 20);
            this.birthDate.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(309, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(380, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // getPersonsBTN
            // 
            this.getPersonsBTN.Location = new System.Drawing.Point(125, 294);
            this.getPersonsBTN.Name = "getPersonsBTN";
            this.getPersonsBTN.Size = new System.Drawing.Size(75, 23);
            this.getPersonsBTN.TabIndex = 12;
            this.getPersonsBTN.Text = "GetPersons";
            this.getPersonsBTN.UseVisualStyleBackColor = true;
            this.getPersonsBTN.Click += new System.EventHandler(this.getPersonsBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.getPersonsBTN);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button getPersonsBTN;
    }
}

