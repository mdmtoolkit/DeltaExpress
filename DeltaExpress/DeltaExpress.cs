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
    public partial class Form2 : Form
    {
        public string filename = string.Empty;
        DataSet dtSet = new DataSet();
        string CSVColsRows;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        private void populateMappingGrid()
        {
            if (filename == string.Empty)
                return;

            if (dtSet.Tables.Count > 0)
                return;


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
            dtColumn.ColumnName = "KeyColumn";
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
            metroGrid1.DataSource = bs;
        }

        private void tabMapping_Enter(object sender, EventArgs e)
        {
            populateMappingGrid();
        }

        private void btnSelectFile_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            filename = openFileDialog1.FileName;
            txtFilePath.Text = filename;

            FileInfo fi = new FileInfo(filename);
            txtDestinationTableName.Text = fi.Name.Replace(fi.Extension, "");
        }

        private void btnSourceNext_Click_1(object sender, EventArgs e)
        {
            tabControl.SelectTab("tabMapping");
        }
    }
}
