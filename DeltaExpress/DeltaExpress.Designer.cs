
namespace DeltaExpress
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabHome = new MetroFramework.Controls.MetroTabPage();
            this.tabSource = new MetroFramework.Controls.MetroTabPage();
            this.tabMapping = new MetroFramework.Controls.MetroTabPage();
            this.tabSchedule = new MetroFramework.Controls.MetroTabPage();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDestinationTableName = new MetroFramework.Controls.MetroTextBox();
            this.btnSourceNext = new MetroFramework.Controls.MetroButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtColumnDelimiter = new MetroFramework.Controls.MetroTextBox();
            this.txtFilePath = new System.Windows.Forms.RichTextBox();
            this.btnSelectFile = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabSource.SuspendLayout();
            this.tabMapping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 33);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Delta Express";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabHome);
            this.tabControl.Controls.Add(this.tabSource);
            this.tabControl.Controls.Add(this.tabMapping);
            this.tabControl.Controls.Add(this.tabSchedule);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 33);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 2;
            this.tabControl.Size = new System.Drawing.Size(782, 588);
            this.tabControl.TabIndex = 1;
            this.tabControl.UseSelectable = true;
            // 
            // tabHome
            // 
            this.tabHome.HorizontalScrollbarBarColor = true;
            this.tabHome.HorizontalScrollbarHighlightOnWheel = false;
            this.tabHome.HorizontalScrollbarSize = 6;
            this.tabHome.Location = new System.Drawing.Point(4, 38);
            this.tabHome.Name = "tabHome";
            this.tabHome.Size = new System.Drawing.Size(774, 546);
            this.tabHome.TabIndex = 1;
            this.tabHome.Text = "Home";
            this.tabHome.VerticalScrollbarBarColor = true;
            this.tabHome.VerticalScrollbarHighlightOnWheel = false;
            this.tabHome.VerticalScrollbarSize = 6;
            // 
            // tabSource
            // 
            this.tabSource.Controls.Add(this.label4);
            this.tabSource.Controls.Add(this.txtDestinationTableName);
            this.tabSource.Controls.Add(this.btnSourceNext);
            this.tabSource.Controls.Add(this.label3);
            this.tabSource.Controls.Add(this.txtColumnDelimiter);
            this.tabSource.Controls.Add(this.txtFilePath);
            this.tabSource.Controls.Add(this.btnSelectFile);
            this.tabSource.Controls.Add(this.label2);
            this.tabSource.Controls.Add(this.metroComboBox1);
            this.tabSource.HorizontalScrollbarBarColor = true;
            this.tabSource.HorizontalScrollbarHighlightOnWheel = false;
            this.tabSource.HorizontalScrollbarSize = 6;
            this.tabSource.Location = new System.Drawing.Point(4, 38);
            this.tabSource.Name = "tabSource";
            this.tabSource.Size = new System.Drawing.Size(774, 546);
            this.tabSource.TabIndex = 2;
            this.tabSource.Text = "Source";
            this.tabSource.VerticalScrollbarBarColor = true;
            this.tabSource.VerticalScrollbarHighlightOnWheel = false;
            this.tabSource.VerticalScrollbarSize = 6;
            this.tabSource.Enter += new System.EventHandler(this.tabMapping_Enter);
            // 
            // tabMapping
            // 
            this.tabMapping.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tabMapping.Controls.Add(this.metroGrid1);
            this.tabMapping.HorizontalScrollbarBarColor = true;
            this.tabMapping.HorizontalScrollbarHighlightOnWheel = false;
            this.tabMapping.HorizontalScrollbarSize = 6;
            this.tabMapping.Location = new System.Drawing.Point(4, 38);
            this.tabMapping.Name = "tabMapping";
            this.tabMapping.Size = new System.Drawing.Size(774, 546);
            this.tabMapping.TabIndex = 3;
            this.tabMapping.Text = "Mapping";
            this.tabMapping.VerticalScrollbarBarColor = true;
            this.tabMapping.VerticalScrollbarHighlightOnWheel = false;
            this.tabMapping.VerticalScrollbarSize = 6;
            this.tabMapping.Enter += new System.EventHandler(this.tabMapping_Enter);
            // 
            // tabSchedule
            // 
            this.tabSchedule.HorizontalScrollbar = true;
            this.tabSchedule.HorizontalScrollbarBarColor = true;
            this.tabSchedule.HorizontalScrollbarHighlightOnWheel = false;
            this.tabSchedule.HorizontalScrollbarSize = 8;
            this.tabSchedule.Location = new System.Drawing.Point(4, 38);
            this.tabSchedule.Name = "tabSchedule";
            this.tabSchedule.Size = new System.Drawing.Size(774, 546);
            this.tabSchedule.TabIndex = 4;
            this.tabSchedule.Text = "Schedule";
            this.tabSchedule.VerticalScrollbarBarColor = true;
            this.tabSchedule.VerticalScrollbarHighlightOnWheel = false;
            this.tabSchedule.VerticalScrollbarSize = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 0);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(774, 546);
            this.metroGrid1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Destination Table Name";
            // 
            // txtDestinationTableName
            // 
            // 
            // 
            // 
            this.txtDestinationTableName.CustomButton.Image = null;
            this.txtDestinationTableName.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtDestinationTableName.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtDestinationTableName.CustomButton.Name = "";
            this.txtDestinationTableName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDestinationTableName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDestinationTableName.CustomButton.TabIndex = 1;
            this.txtDestinationTableName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDestinationTableName.CustomButton.UseSelectable = true;
            this.txtDestinationTableName.CustomButton.Visible = false;
            this.txtDestinationTableName.Lines = new string[0];
            this.txtDestinationTableName.Location = new System.Drawing.Point(262, 313);
            this.txtDestinationTableName.MaxLength = 32767;
            this.txtDestinationTableName.Name = "txtDestinationTableName";
            this.txtDestinationTableName.PasswordChar = '\0';
            this.txtDestinationTableName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDestinationTableName.SelectedText = "";
            this.txtDestinationTableName.SelectionLength = 0;
            this.txtDestinationTableName.SelectionStart = 0;
            this.txtDestinationTableName.ShortcutsEnabled = true;
            this.txtDestinationTableName.Size = new System.Drawing.Size(222, 23);
            this.txtDestinationTableName.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtDestinationTableName.TabIndex = 19;
            this.txtDestinationTableName.UseSelectable = true;
            this.txtDestinationTableName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDestinationTableName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSourceNext
            // 
            this.btnSourceNext.Location = new System.Drawing.Point(262, 379);
            this.btnSourceNext.Name = "btnSourceNext";
            this.btnSourceNext.Size = new System.Drawing.Size(222, 34);
            this.btnSourceNext.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnSourceNext.TabIndex = 18;
            this.btnSourceNext.Text = "Goto Column Mappings >>";
            this.btnSourceNext.UseSelectable = true;
            this.btnSourceNext.Click += new System.EventHandler(this.btnSourceNext_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Column Delimiter";
            // 
            // txtColumnDelimiter
            // 
            // 
            // 
            // 
            this.txtColumnDelimiter.CustomButton.Image = null;
            this.txtColumnDelimiter.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtColumnDelimiter.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtColumnDelimiter.CustomButton.Name = "";
            this.txtColumnDelimiter.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtColumnDelimiter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtColumnDelimiter.CustomButton.TabIndex = 1;
            this.txtColumnDelimiter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtColumnDelimiter.CustomButton.UseSelectable = true;
            this.txtColumnDelimiter.CustomButton.Visible = false;
            this.txtColumnDelimiter.Lines = new string[] {
        ","};
            this.txtColumnDelimiter.Location = new System.Drawing.Point(262, 271);
            this.txtColumnDelimiter.MaxLength = 32767;
            this.txtColumnDelimiter.Name = "txtColumnDelimiter";
            this.txtColumnDelimiter.PasswordChar = '\0';
            this.txtColumnDelimiter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtColumnDelimiter.SelectedText = "";
            this.txtColumnDelimiter.SelectionLength = 0;
            this.txtColumnDelimiter.SelectionStart = 0;
            this.txtColumnDelimiter.ShortcutsEnabled = true;
            this.txtColumnDelimiter.Size = new System.Drawing.Size(222, 23);
            this.txtColumnDelimiter.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtColumnDelimiter.TabIndex = 16;
            this.txtColumnDelimiter.Text = ",";
            this.txtColumnDelimiter.UseSelectable = true;
            this.txtColumnDelimiter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtColumnDelimiter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(262, 176);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(222, 68);
            this.txtFilePath.TabIndex = 15;
            this.txtFilePath.Text = "";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(262, 119);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(222, 34);
            this.btnSelectFile.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnSelectFile.TabIndex = 14;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseSelectable = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Select Source Type";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "CSV",
            "Excel",
            "Azure Synapse",
            "SAP",
            "Dynamics CRM"});
            this.metroComboBox1.Location = new System.Drawing.Point(262, 68);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(222, 29);
            this.metroComboBox1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroComboBox1.TabIndex = 12;
            this.metroComboBox1.UseSelectable = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 621);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabSource.ResumeLayout(false);
            this.tabSource.PerformLayout();
            this.tabMapping.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage tabHome;
        private MetroFramework.Controls.MetroTabPage tabSource;
        private MetroFramework.Controls.MetroTabPage tabMapping;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroTabPage tabSchedule;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txtDestinationTableName;
        private MetroFramework.Controls.MetroButton btnSourceNext;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtColumnDelimiter;
        private System.Windows.Forms.RichTextBox txtFilePath;
        private MetroFramework.Controls.MetroButton btnSelectFile;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
    }
}