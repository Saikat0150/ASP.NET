using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Creating_dataset__namespace__table
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a Dataset,namespace and Student table
            //Name and address column
            DataSet ds = new DataSet("DS");
            ds.Namespace = "StdNamespace";
            DataTable stdTable = new DataTable("NewStudent");
            DataColumn col1 = new DataColumn("Name");
            DataColumn col2 = new DataColumn("Address");
            stdTable.Columns.Add(col1);
            stdTable.Columns.Add(col2);
            ds.Tables.Add(stdTable);
            //Add student Data to the table
            DataRow newRow;
            newRow = stdTable.NewRow();
            newRow["Name"] = "Saikat";
            newRow["Address"] = "Kolkata";
            stdTable.Rows.Add(newRow);
            newRow = stdTable.NewRow();
            newRow["Name"] = "Anshuman";
            newRow["Address"] = "Baruipur";
            stdTable.Rows.Add(newRow);
            newRow = stdTable.NewRow();
            newRow["Name"] = "Preet";
            newRow["Address"] = "Mumbai";
            stdTable.Rows.Add(newRow);
            ds.AcceptChanges();
            //create a new streamWriter
            //Save the date in some file Eg. stdData.xml
            System.IO.StreamWriter myStreamWriter = new System.IO.StreamWriter(@"D:\stdData.xml");
            //Write data to DataSet which actually creates the file
            ds.WriteXml(myStreamWriter);
            myStreamWriter.Close();
            
        }
    }
}
