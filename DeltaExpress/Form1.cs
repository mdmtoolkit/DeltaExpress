using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DeltaExpress
{

    public partial class Form1 : Form
    {
        public string filename;
        // Create a new DataSet  
        DataSet dtSet = new DataSet();
        string CSVColsRows;

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            filename = openFileDialog1.FileName;
            txtFilePath.Text = filename;

        }

        private void tbSource_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbSourceList.SelectedIndex = 0;
            btnSelectFile.Visible = false;
            txtFilePath.Visible = false;
            tabControl1.SelectTab("tbSource");

        }

        private void cbSourceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSourceList.SelectedItem.ToString() == "CSV")
            {
                btnSelectFile.Visible = true;
                txtFilePath.Visible = true;
            }
            else
            {
                btnSelectFile.Visible = false;
                txtFilePath.Visible = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tbMapping");
        }

        private void tbMapping_Enter(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(filename);
            txtDestinationTableName.Text = fi.Name.Replace(fi.Extension, "");
            using (StreamReader sr = File.OpenText(filename))
            {
                CSVColsRows = sr.ReadLine();
            }

                // Create a new DataTable.    
                DataTable custTable = new DataTable("Mappings");
            DataColumn dtColumn;
            DataRow myDataRow;

            

            // Create Name column.    
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(bool);
            dtColumn.ColumnName = "SelectColumn";
            dtColumn.Caption = "Select Column";
            dtColumn.AutoIncrement = false;
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            /// Add column to the DataColumnCollection.  
            custTable.Columns.Add(dtColumn);

            // Create Name column.    
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "SourceColumn";
            dtColumn.Caption = "Source Column";
            dtColumn.AutoIncrement = false;
            dtColumn.ReadOnly = true;
            dtColumn.Unique = false;
            /// Add column to the DataColumnCollection.  
            custTable.Columns.Add(dtColumn);

            // Create Address column.    
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "ColumnDelimeter";
            dtColumn.Caption = "Column Delimeter";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            // Add column to the DataColumnCollection.    
            custTable.Columns.Add(dtColumn);

            // Create Address column.    
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "ColumnType";
            dtColumn.Caption = "Column Data Type";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            // Add column to the DataColumnCollection.    
            custTable.Columns.Add(dtColumn);


            // Create Name column.    
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "DestinationColumn";
            dtColumn.Caption = "Destination Column";
            dtColumn.AutoIncrement = false;
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            /// Add column to the DataColumnCollection.  
            custTable.Columns.Add(dtColumn);

            // Create Name column.    
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(bool);
            dtColumn.ColumnName = "kEYColumn";
            dtColumn.Caption = "Key Column";
            dtColumn.AutoIncrement = false;
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            /// Add column to the DataColumnCollection.  
            custTable.Columns.Add(dtColumn);

            string[] colsList = CSVColsRows.Split(',');

            foreach (string col in colsList)
            { 
                myDataRow = custTable.NewRow();
                myDataRow["SelectColumn"] = true;
                myDataRow["SourceColumn"] = col.Replace("\"", "");
                myDataRow["ColumnDelimeter"] = ",";
                myDataRow["ColumnType"] = "SQLNVARCHAR";
                myDataRow["DestinationColumn"] = col.Replace("\"", "");
                myDataRow["KeyColumn"] = false;

                custTable.Rows.Add(myDataRow);
            }

            // Add custTable to the DataSet.    
            dtSet.Tables.Add(custTable);


            // Create a BindingSource  
            BindingSource bs = new BindingSource();
            bs.DataSource = dtSet.Tables["Mappings"];

            // Bind data to DataGridView.DataSource  
            dataGridView1.DataSource = bs;
        }
    }
}

