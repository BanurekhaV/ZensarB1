using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml;

namespace ADODay3Prj
{
    class ReadWrite_XmL
    {
        static void Main()
        {
            // XMLWriter();
            // XMLWrite_Schema();
            // XMLReader();
            Xml_Read_Schema();
           Console.Read();
        }
        //write data to an xml file using dataset
        static void XMLWriter()
        {
            try
            {
                //create a dataset, namespace and a student table with name and address
                DataSet ds = new DataSet("DSStudent");
                ds.Namespace = "Studentnamespace";
                DataTable stdTable = new DataTable("Student");

                //add columns to the student table
                DataColumn col1 = new DataColumn("Name");
                DataColumn col2 = new DataColumn("Address");
                stdTable.Columns.Add(col1);
                stdTable.Columns.Add(col2);

                ds.Tables.Add(stdTable);

                //add student details to the student table
                DataRow stdrow = stdTable.NewRow();
                stdrow["Name"] = "Pavani";
                stdrow["Address"] = "Hyderabad";
                stdTable.Rows.Add(stdrow);

                stdrow = stdTable.NewRow();
                stdrow["Name"] = "Namitha";
                stdrow["Address"] = "Kolkata";
                stdTable.Rows.Add(stdrow);

                stdrow = stdTable.NewRow();
                stdrow["Name"] = "Arbaz";
                stdrow["Address"] = "Mumbai";
                stdTable.Rows.Add(stdrow);

                stdrow = stdTable.NewRow();
                stdrow["Name"] = "Simi";
                stdrow["Address"] = "Cochin";
                stdTable.Rows.Add(stdrow);

                //accept all changes
                ds.AcceptChanges();

                //create a stream writer and save the data in the studentdata.xml
                System.IO.StreamWriter mywriter = new System.IO.StreamWriter("xxx.xml");
                ds.WriteXml(mywriter);
                mywriter.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception : {0}", e.ToString());
            }
            return;
        }

        static void XMLWrite_Schema()
        {
            try
            {
                //create a dataset, namespace and a student table with name and address
                DataSet ds = new DataSet("DSStudent");
                ds.Namespace = "Studentnamespace";
                DataTable stdTable = new DataTable("Student");

                //add columns to the student table
                DataColumn col1 = new DataColumn("Name");
                DataColumn col2 = new DataColumn("Address");
                stdTable.Columns.Add(col1);
                stdTable.Columns.Add(col2);

                ds.Tables.Add(stdTable);

                //add student details to the student table
                DataRow stdrow = stdTable.NewRow();
                stdrow["Name"] = "Pavani";
                stdrow["Address"] = "Hyderabad";
                stdTable.Rows.Add(stdrow);

                stdrow = stdTable.NewRow();
                stdrow["Name"] = "Namitha";
                stdrow["Address"] = "Kolkata";
                stdTable.Rows.Add(stdrow);

                stdrow = stdTable.NewRow();
                stdrow["Name"] = "Arbaz";
                stdrow["Address"] = "Mumbai";
                stdTable.Rows.Add(stdrow);

                stdrow = stdTable.NewRow();
                stdrow["Name"] = "Simi";
                stdrow["Address"] = "Cochin";
                stdTable.Rows.Add(stdrow);

                //accept all changes
                ds.AcceptChanges();
                XmlTextWriter writer = new XmlTextWriter("xxxschema.xsd",Encoding.UTF8);
                ds.WriteXmlSchema(writer);
                Console.Read();
                return;
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception {0}",e.ToString());
            }
        }

        static void XMLReader()
        {
            //create a dataset object
            DataSet ds = new DataSet();
            ds.ReadXml("xxx.xml");

            foreach(DataTable table in ds.Tables)
            {
                Console.WriteLine(table);
                for(int i=0; i<table.Columns.Count;i++)
                    Console.Write("\t" + table.Columns[i].ColumnName); //headings as Name   Address
                Console.WriteLine();
                foreach(var row in table.AsEnumerable())
                {
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        Console.Write("\t" + row[i]);
                    }
                    Console.WriteLine();
                }
            }

        }

        static void Xml_Read_Schema()
        {
            DataSet ds = new DataSet("New DataSet");
            XmlTextReader myreader = new XmlTextReader("xxx.xml");
            //call readXmlSchema
            ds.ReadXmlSchema(myreader);
            myreader.Close();
            XmlTextWriter tw = new XmlTextWriter(Console.Out);
            ds.WriteXmlSchema(tw);
            Console.ReadLine();
        }
    }
}
