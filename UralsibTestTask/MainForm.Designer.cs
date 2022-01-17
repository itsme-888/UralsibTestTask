namespace UralsibTestTask
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bAddClient = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bChangeClient = new System.Windows.Forms.Button();
            this.bDelCurrent = new System.Windows.Forms.Button();
            this.bAddBuyCurrentClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(347, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            this.patronymicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientBindingSource1
            // 
            this.clientBindingSource1.DataSource = typeof(UralsibTestTask.Models.Client);
            // 
            // bAddClient
            // 
            this.bAddClient.Location = new System.Drawing.Point(365, 12);
            this.bAddClient.Name = "bAddClient";
            this.bAddClient.Size = new System.Drawing.Size(244, 23);
            this.bAddClient.TabIndex = 2;
            this.bAddClient.Text = "Добавить клиента";
            this.bAddClient.UseVisualStyleBackColor = true;
            this.bAddClient.Click += new System.EventHandler(this.bAddClient_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(365, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "Просмотреть подробную информацию";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bChangeClient
            // 
            this.bChangeClient.Location = new System.Drawing.Point(365, 98);
            this.bChangeClient.Name = "bChangeClient";
            this.bChangeClient.Size = new System.Drawing.Size(244, 23);
            this.bChangeClient.TabIndex = 4;
            this.bChangeClient.Text = "Изменить выбранного";
            this.bChangeClient.UseVisualStyleBackColor = true;
            this.bChangeClient.Click += new System.EventHandler(this.bChangeClient_Click);
            // 
            // bDelCurrent
            // 
            this.bDelCurrent.Location = new System.Drawing.Point(365, 127);
            this.bDelCurrent.Name = "bDelCurrent";
            this.bDelCurrent.Size = new System.Drawing.Size(244, 23);
            this.bDelCurrent.TabIndex = 5;
            this.bDelCurrent.Text = "Удалить выбранного";
            this.bDelCurrent.UseVisualStyleBackColor = true;
            this.bDelCurrent.Click += new System.EventHandler(this.bDelCurrent_Click);
            // 
            // bAddBuyCurrentClient
            // 
            this.bAddBuyCurrentClient.Location = new System.Drawing.Point(365, 254);
            this.bAddBuyCurrentClient.Name = "bAddBuyCurrentClient";
            this.bAddBuyCurrentClient.Size = new System.Drawing.Size(244, 23);
            this.bAddBuyCurrentClient.TabIndex = 6;
            this.bAddBuyCurrentClient.Text = "Добавить покупку выбранному клиенту";
            this.bAddBuyCurrentClient.UseVisualStyleBackColor = true;
            this.bAddBuyCurrentClient.Click += new System.EventHandler(this.bAddBuyCurrentClient_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 368);
            this.Controls.Add(this.bAddBuyCurrentClient);
            this.Controls.Add(this.bDelCurrent);
            this.Controls.Add(this.bChangeClient);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bAddClient);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список клиентов";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource clientBindingSource1;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private Button bAddClient;
        private Button button2;
        private Button bChangeClient;
        private Button bDelCurrent;
        private Button bAddBuyCurrentClient;
    }
}