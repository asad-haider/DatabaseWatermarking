namespace DatabaseWatermarking
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDatabaseName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboTables = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbRowCount = new System.Windows.Forms.Label();
            this.tbColumnCount = new System.Windows.Forms.Label();
            this.grdTableData = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.comboSeries = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbWatermark = new System.Windows.Forms.TextBox();
            this.btnWatermark = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.comboCompareTable = new System.Windows.Forms.ComboBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdTableData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database Watermarking";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Database: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Server: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter User:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enter Password:";
            // 
            // tbDatabaseName
            // 
            this.tbDatabaseName.Location = new System.Drawing.Point(205, 74);
            this.tbDatabaseName.Name = "tbDatabaseName";
            this.tbDatabaseName.Size = new System.Drawing.Size(223, 20);
            this.tbDatabaseName.TabIndex = 5;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(205, 165);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(223, 20);
            this.tbPassword.TabIndex = 8;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(205, 136);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(223, 20);
            this.tbUsername.TabIndex = 7;
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(205, 105);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(223, 20);
            this.tbServer.TabIndex = 6;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(353, 201);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(302, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "*For Windows Authentication Leave User and Password Blank";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tables:";
            // 
            // comboTables
            // 
            this.comboTables.Enabled = false;
            this.comboTables.FormattingEnabled = true;
            this.comboTables.Location = new System.Drawing.Point(205, 239);
            this.comboTables.Name = "comboTables";
            this.comboTables.Size = new System.Drawing.Size(223, 21);
            this.comboTables.TabIndex = 12;
            this.comboTables.SelectedIndexChanged += new System.EventHandler(this.comboTables_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Total Rows:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Total Columns:";
            // 
            // tbRowCount
            // 
            this.tbRowCount.AutoSize = true;
            this.tbRowCount.Location = new System.Drawing.Point(202, 280);
            this.tbRowCount.Name = "tbRowCount";
            this.tbRowCount.Size = new System.Drawing.Size(49, 13);
            this.tbRowCount.TabIndex = 15;
            this.tbRowCount.Text = "0 Row(s)";
            // 
            // tbColumnCount
            // 
            this.tbColumnCount.AutoSize = true;
            this.tbColumnCount.Location = new System.Drawing.Point(202, 304);
            this.tbColumnCount.Name = "tbColumnCount";
            this.tbColumnCount.Size = new System.Drawing.Size(62, 13);
            this.tbColumnCount.TabIndex = 16;
            this.tbColumnCount.Text = "0 Column(s)";
            // 
            // grdTableData
            // 
            this.grdTableData.AllowUserToAddRows = false;
            this.grdTableData.AllowUserToDeleteRows = false;
            this.grdTableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTableData.Location = new System.Drawing.Point(488, 74);
            this.grdTableData.Name = "grdTableData";
            this.grdTableData.ReadOnly = true;
            this.grdTableData.Size = new System.Drawing.Size(497, 262);
            this.grdTableData.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(485, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Series: ";
            // 
            // comboSeries
            // 
            this.comboSeries.Enabled = false;
            this.comboSeries.FormattingEnabled = true;
            this.comboSeries.Location = new System.Drawing.Point(568, 368);
            this.comboSeries.Name = "comboSeries";
            this.comboSeries.Size = new System.Drawing.Size(149, 21);
            this.comboSeries.TabIndex = 19;
            this.comboSeries.SelectedIndexChanged += new System.EventHandler(this.comboSeries_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(485, 406);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Watermark";
            // 
            // tbWatermark
            // 
            this.tbWatermark.Location = new System.Drawing.Point(568, 403);
            this.tbWatermark.Name = "tbWatermark";
            this.tbWatermark.Size = new System.Drawing.Size(149, 20);
            this.tbWatermark.TabIndex = 21;
            // 
            // btnWatermark
            // 
            this.btnWatermark.Location = new System.Drawing.Point(829, 433);
            this.btnWatermark.Name = "btnWatermark";
            this.btnWatermark.Size = new System.Drawing.Size(75, 23);
            this.btnWatermark.TabIndex = 22;
            this.btnWatermark.Text = "Encrypt";
            this.btnWatermark.UseVisualStyleBackColor = true;
            this.btnWatermark.Click += new System.EventHandler(this.btnWatermark_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(485, 438);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Compare With:";
            // 
            // comboCompareTable
            // 
            this.comboCompareTable.FormattingEnabled = true;
            this.comboCompareTable.Location = new System.Drawing.Point(568, 435);
            this.comboCompareTable.Name = "comboCompareTable";
            this.comboCompareTable.Size = new System.Drawing.Size(149, 21);
            this.comboCompareTable.TabIndex = 25;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(910, 433);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 26;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 519);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.comboCompareTable);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnWatermark);
            this.Controls.Add(this.tbWatermark);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboSeries);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.grdTableData);
            this.Controls.Add(this.tbColumnCount);
            this.Controls.Add(this.tbRowCount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboTables);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbDatabaseName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grdTableData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDatabaseName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboTables;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label tbRowCount;
        private System.Windows.Forms.Label tbColumnCount;
        private System.Windows.Forms.DataGridView grdTableData;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboSeries;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbWatermark;
        private System.Windows.Forms.Button btnWatermark;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboCompareTable;
        private System.Windows.Forms.Button btnDecrypt;
    }
}

