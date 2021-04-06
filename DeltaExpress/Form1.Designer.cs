
namespace DeltaExpress
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbSource = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.cbSourceList = new System.Windows.Forms.ComboBox();
            this.tbMapping = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDestinationTableName = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tbSource.SuspendLayout();
            this.tbMapping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbSource);
            this.tabControl1.Controls.Add(this.tbMapping);
            this.tabControl1.Location = new System.Drawing.Point(21, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(908, 669);
            this.tabControl1.TabIndex = 0;
            // 
            // tbSource
            // 
            this.tbSource.BackColor = System.Drawing.Color.Silver;
            this.tbSource.Controls.Add(this.btnNext);
            this.tbSource.Controls.Add(this.txtFilePath);
            this.tbSource.Controls.Add(this.btnSelectFile);
            this.tbSource.Controls.Add(this.cbSourceList);
            this.tbSource.Location = new System.Drawing.Point(4, 22);
            this.tbSource.Name = "tbSource";
            this.tbSource.Padding = new System.Windows.Forms.Padding(3);
            this.tbSource.Size = new System.Drawing.Size(900, 643);
            this.tbSource.TabIndex = 0;
            this.tbSource.Text = "Source";
            this.tbSource.Click += new System.EventHandler(this.tbSource_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(165, 251);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next >>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(86, 182);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(155, 20);
            this.txtFilePath.TabIndex = 2;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(166, 145);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFile.TabIndex = 1;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbSourceList
            // 
            this.cbSourceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSourceList.FormattingEnabled = true;
            this.cbSourceList.Items.AddRange(new object[] {
            "Select Source Type",
            "CSV",
            "Excel",
            "Azure Synape",
            "SAP"});
            this.cbSourceList.Location = new System.Drawing.Point(86, 97);
            this.cbSourceList.Name = "cbSourceList";
            this.cbSourceList.Size = new System.Drawing.Size(155, 21);
            this.cbSourceList.TabIndex = 0;
            this.cbSourceList.SelectedIndexChanged += new System.EventHandler(this.cbSourceList_SelectedIndexChanged);
            // 
            // tbMapping
            // 
            this.tbMapping.BackColor = System.Drawing.Color.Silver;
            this.tbMapping.Controls.Add(this.dataGridView1);
            this.tbMapping.Controls.Add(this.label1);
            this.tbMapping.Controls.Add(this.txtDestinationTableName);
            this.tbMapping.Location = new System.Drawing.Point(4, 22);
            this.tbMapping.Name = "tbMapping";
            this.tbMapping.Padding = new System.Windows.Forms.Padding(3);
            this.tbMapping.Size = new System.Drawing.Size(900, 643);
            this.tbMapping.TabIndex = 1;
            this.tbMapping.Text = "Mapping";
            this.tbMapping.Enter += new System.EventHandler(this.tbMapping_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 559);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Destination Table Name";
            // 
            // txtDestinationTableName
            // 
            this.txtDestinationTableName.Location = new System.Drawing.Point(179, 24);
            this.txtDestinationTableName.Name = "txtDestinationTableName";
            this.txtDestinationTableName.Size = new System.Drawing.Size(205, 20);
            this.txtDestinationTableName.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 693);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbSource.ResumeLayout(false);
            this.tbSource.PerformLayout();
            this.tbMapping.ResumeLayout(false);
            this.tbMapping.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbSource;
        private System.Windows.Forms.TabPage tbMapping;
        private System.Windows.Forms.ComboBox cbSourceList;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDestinationTableName;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

