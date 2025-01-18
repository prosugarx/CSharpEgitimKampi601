namespace CSharpEgitimKampi601
{
    partial class FrmCustomer
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
            this.btnGetCustomerById = new System.Windows.Forms.Button();
            this.btnCustomerUpdate = new System.Windows.Forms.Button();
            this.btnCustomerCreat = new System.Windows.Forms.Button();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.txtCustomerCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.btnCustomerList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetCustomerById
            // 
            this.btnGetCustomerById.BackColor = System.Drawing.Color.LightGreen;
            this.btnGetCustomerById.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetCustomerById.Location = new System.Drawing.Point(157, 514);
            this.btnGetCustomerById.Name = "btnGetCustomerById";
            this.btnGetCustomerById.Size = new System.Drawing.Size(323, 64);
            this.btnGetCustomerById.TabIndex = 34;
            this.btnGetCustomerById.Text = "Id\'ye Göre Getir";
            this.btnGetCustomerById.UseVisualStyleBackColor = false;
            // 
            // btnCustomerUpdate
            // 
            this.btnCustomerUpdate.BackColor = System.Drawing.Color.LightGreen;
            this.btnCustomerUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerUpdate.Location = new System.Drawing.Point(157, 435);
            this.btnCustomerUpdate.Name = "btnCustomerUpdate";
            this.btnCustomerUpdate.Size = new System.Drawing.Size(323, 64);
            this.btnCustomerUpdate.TabIndex = 33;
            this.btnCustomerUpdate.Text = "Güncelle";
            this.btnCustomerUpdate.UseVisualStyleBackColor = false;
            this.btnCustomerUpdate.Click += new System.EventHandler(this.btnCustomerUpdate_Click);
            // 
            // btnCustomerCreat
            // 
            this.btnCustomerCreat.BackColor = System.Drawing.Color.LightGreen;
            this.btnCustomerCreat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerCreat.Location = new System.Drawing.Point(157, 269);
            this.btnCustomerCreat.Name = "btnCustomerCreat";
            this.btnCustomerCreat.Size = new System.Drawing.Size(323, 64);
            this.btnCustomerCreat.TabIndex = 32;
            this.btnCustomerCreat.Text = "Ekle";
            this.btnCustomerCreat.UseVisualStyleBackColor = false;
            this.btnCustomerCreat.Click += new System.EventHandler(this.btnCustomerCreat_Click);
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.BackColor = System.Drawing.Color.LightGreen;
            this.btnCustomerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerDelete.Location = new System.Drawing.Point(157, 354);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(323, 64);
            this.btnCustomerDelete.TabIndex = 31;
            this.btnCustomerDelete.Text = "Sil";
            this.btnCustomerDelete.UseVisualStyleBackColor = false;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // txtCustomerCity
            // 
            this.txtCustomerCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCustomerCity.Location = new System.Drawing.Point(144, 131);
            this.txtCustomerCity.Name = "txtCustomerCity";
            this.txtCustomerCity.Size = new System.Drawing.Size(352, 27);
            this.txtCustomerCity.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(88, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Şehri:";
            // 
            // txtCustomerSurname
            // 
            this.txtCustomerSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCustomerSurname.Location = new System.Drawing.Point(144, 87);
            this.txtCustomerSurname.Name = "txtCustomerSurname";
            this.txtCustomerSurname.Size = new System.Drawing.Size(352, 27);
            this.txtCustomerSurname.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(16, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Müşteri Soyadı:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCustomerName.Location = new System.Drawing.Point(144, 45);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(352, 27);
            this.txtCustomerName.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(42, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Müşteri Adı:";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCustomerId.Location = new System.Drawing.Point(144, 3);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(352, 27);
            this.txtCustomerId.TabIndex = 20;
            // 
            // btnCustomerList
            // 
            this.btnCustomerList.BackColor = System.Drawing.Color.LightGreen;
            this.btnCustomerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerList.Location = new System.Drawing.Point(157, 189);
            this.btnCustomerList.Name = "btnCustomerList";
            this.btnCustomerList.Size = new System.Drawing.Size(323, 64);
            this.btnCustomerList.TabIndex = 19;
            this.btnCustomerList.Text = "Listele";
            this.btnCustomerList.UseVisualStyleBackColor = false;
            this.btnCustomerList.Click += new System.EventHandler(this.btnCustomerList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Müşteri Id:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(520, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(778, 638);
            this.dataGridView1.TabIndex = 35;
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 656);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGetCustomerById);
            this.Controls.Add(this.btnCustomerUpdate);
            this.Controls.Add(this.btnCustomerCreat);
            this.Controls.Add(this.btnCustomerDelete);
            this.Controls.Add(this.txtCustomerCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCustomerSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.btnCustomerList);
            this.Controls.Add(this.label1);
            this.Name = "FrmCustomer";
            this.Text = "FrmCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetCustomerById;
        private System.Windows.Forms.Button btnCustomerUpdate;
        private System.Windows.Forms.Button btnCustomerCreat;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.TextBox txtCustomerCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Button btnCustomerList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}