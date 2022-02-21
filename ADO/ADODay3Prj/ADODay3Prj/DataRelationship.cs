using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ADODay3Prj
{
    class DataRelationship
    {
        
			static void Main()
			{
				DataSet dsEmployment = new DataSet("Employment");
				DataTable dtEmployees = new DataTable("Employees");

				DataColumn[] dcEmployees = new DataColumn[5];

				dcEmployees[0] = new DataColumn("EmployeeID",
							 System.Type.GetType("System.Int32"));
				dtEmployees.Columns.Add(dcEmployees[0]);
				dcEmployees[1] = new DataColumn("FirstName",
							 System.Type.GetType("System.String"));
				dtEmployees.Columns.Add(dcEmployees[1]);
				dcEmployees[2] = new DataColumn("LastName",
							 System.Type.GetType("System.String"));
				dtEmployees.Columns.Add(dcEmployees[2]);
				dcEmployees[3] = new DataColumn("Department",
							 System.Type.GetType("System.String"));
				dtEmployees.Columns.Add(dcEmployees[3]);
				dcEmployees[4] = new DataColumn("EmplStatusID",
							 System.Type.GetType("System.Int32"));
				dtEmployees.Columns.Add(dcEmployees[4]);

				DataRow drEmplRecord = dtEmployees.NewRow();
				drEmplRecord["EmployeeID"] = "1";
				drEmplRecord["FirstName"] = "Nikitha";
				drEmplRecord["LastName"] = "J";
				drEmplRecord["Department"] = "Accounting";
				drEmplRecord["EmplStatusID"] = "1";
				dtEmployees.Rows.Add(drEmplRecord);

				drEmplRecord = dtEmployees.NewRow();
				drEmplRecord["EmployeeID"] = "2";
				drEmplRecord["FirstName"] = "Ravi";
				drEmplRecord["LastName"] = "Thakur";
				drEmplRecord["Department"] = "IT";
				drEmplRecord["EmplStatusID"] = "3";
				dtEmployees.Rows.Add(drEmplRecord);

				drEmplRecord = dtEmployees.NewRow();
				drEmplRecord["EmployeeID"] = "3";
				drEmplRecord["FirstName"] = "Shamshuddin";
				drEmplRecord["LastName"] = "N";
				drEmplRecord["Department"] = "Accounting";
				drEmplRecord["EmplStatusID"] = "2";
				dtEmployees.Rows.Add(drEmplRecord);

				drEmplRecord = dtEmployees.NewRow();
				drEmplRecord["EmployeeID"] = "4";
				drEmplRecord["FirstName"] = "Krithika";
				drEmplRecord["LastName"] = "Sharma";
				drEmplRecord["Department"] = "Public Rel";
				drEmplRecord["EmplStatusID"] = "1";
				dtEmployees.Rows.Add(drEmplRecord);

				drEmplRecord = dtEmployees.NewRow();
				drEmplRecord["EmployeeID"] = "5";
				drEmplRecord["FirstName"] = "Sakshi";
				drEmplRecord["LastName"] = "Modase";
				drEmplRecord["Department"] = "Corporate";
				drEmplRecord["EmplStatusID"] = "4";
				dtEmployees.Rows.Add(drEmplRecord);

				drEmplRecord = dtEmployees.NewRow();
				drEmplRecord["EmployeeID"] = "6";
				drEmplRecord["FirstName"] = "Shivam";
				drEmplRecord["LastName"] = "Shukla";
				drEmplRecord["Department"] = "IT";
				drEmplRecord["EmplStatusID"] = "3";
				dtEmployees.Rows.Add(drEmplRecord);

				drEmplRecord = dtEmployees.NewRow();
				drEmplRecord["EmployeeID"] = "7";
				drEmplRecord["FirstName"] = "Prakash";
				drEmplRecord["LastName"] = "T";
				drEmplRecord["Department"] = "Corporate";
				drEmplRecord["EmplStatusID"] = "1";
				dtEmployees.Rows.Add(drEmplRecord);

				drEmplRecord = dtEmployees.NewRow();
				drEmplRecord["EmployeeID"] = "8";
				drEmplRecord["FirstName"] = "Praveen";
				drEmplRecord["LastName"] = "K";
				drEmplRecord["Department"] = "Public Rel";
				drEmplRecord["EmplStatusID"] = "4";
				dtEmployees.Rows.Add(drEmplRecord);

				DataTable dtEmplStatus = new DataTable("EmploymentStatus");

				DataColumn[] dcEmployment = new DataColumn[2];

				dcEmployment[0] = new DataColumn("EmplStatusID",
							 System.Type.GetType("System.Int32"));
				dtEmplStatus.Columns.Add(dcEmployment[0]);
				dcEmployment[1] = new DataColumn("EmplStatus",
							 System.Type.GetType("System.String"));
				dtEmplStatus.Columns.Add(dcEmployment[1]);

				DataRow drEmployment = dtEmplStatus.NewRow();
				drEmployment["EmplStatusID"] = "1";
				drEmployment["EmplStatus"] = "Full Time";
				dtEmplStatus.Rows.Add(drEmployment);

				drEmployment = dtEmplStatus.NewRow();
				drEmployment["EmplStatusID"] = "2";
				drEmployment["EmplStatus"] = "Part Time";
				dtEmplStatus.Rows.Add(drEmployment);

				drEmployment = dtEmplStatus.NewRow();
				drEmployment["EmplStatusID"] = "3";
				drEmployment["EmplStatus"] = "Contractor";
				dtEmplStatus.Rows.Add(drEmployment);

				drEmployment = dtEmplStatus.NewRow();
				drEmployment["EmplStatusID"] = "4";
				drEmployment["EmplStatus"] = "Intern";
				dtEmplStatus.Rows.Add(drEmployment);

				dsEmployment.Tables.Add(dtEmplStatus);
				dsEmployment.Tables.Add(dtEmployees);

				DataColumn colParent =
					 dsEmployment.Tables["EmploymentStatus"].Columns["EmplStatusID"];
				DataColumn colChild =
					 dsEmployment.Tables["Employees"].Columns["EmplStatusID"];
				DataRelation drEmployeeStatus =
					 new DataRelation("EmployeeStatus", colParent, colChild);

				dsEmployment.Relations.Add(drEmployeeStatus);

				Console.WriteLine("===+===================");
				Console.WriteLine("ID | Employment Status");
				Console.WriteLine("---+-------------------");
				foreach (DataRow row in dsEmployment.Tables["EmploymentStatus"].Rows)
					Console.WriteLine(" {0} | {1}", row["EmplStatusID"], row["EmplStatus"]);

				Console.WriteLine("===+=============+===============+===============+=============");
				Console.WriteLine("ID | First Name\t  | Last Name\t  | Department\t  | Empl Status");
				Console.WriteLine("---+-------------+---------------+---------------+-------------");
				foreach (DataRow row in dsEmployment.Tables["Employees"].Rows)
				{
					int iRow = int.Parse(row["EmplStatusID"].ToString());
					DataRow curRecord = dsEmployment.Tables["EmploymentStatus"].Rows[iRow - 1];

					Console.WriteLine(" {0} |  {1}\t     |  {2}\t   |  {3}\t   | {4}",
						row["EmployeeID"], row["FirstName"],
						row["LastName"], row["Department"], curRecord["EmplStatus"]);
				}
				Console.WriteLine("===+=============+===============+===============+=============\n");
				Console.Read();
			}

		}
	}
