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
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;
using System.Xml.Linq;

namespace IOfile
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        private void btndirectory_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\EmployeeData";

                if (Directory.Exists(path))
                {
                    MessageBox.Show("Directory exists");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Directory Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\EmployeeData\employee.text";
                if (File.Exists(path))
                {
                    MessageBox.Show("file exists");

                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("file created");
                }
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


        private void btnwrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\EmployeeData/emp.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write("Convert.ToInt32(txtid.Text");
                bw.Write("txtname.Text");
                bw.Write("Convert.ToDouble32(txtsalary.Text");
                bw.Close();
                fs.Close();
                MessageBox.Show("Add the data");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnread_Click(object sender, EventArgs e)
        {
            try
            {

                FileStream fs = new FileStream(@"D:\EmployeeData/emp.dat", FileMode.Open, FileAccess.Read);
                BinaryWriter bw = new BinaryWriter(fs);
                txtid.Text = ("Convert.ToInt32(txtid.Text");
                txtname.Text = ("txtname.Text");
                txtsalary.Text = ("Convert.ToDouble32(txtsalary.Text");
                bw.Close();
                fs.Close();
                MessageBox.Show("Add the data");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnstreamwrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\EmployeeData\sample.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(textread.Text);
                sw.Close();
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnstreamread_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\EmployeeData\sample.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                textread.Text = sr.ReadToEnd();
                sr.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.id = Convert.ToInt32(txtid.Text);
                employee.name = txtname.Text;
                employee.salary = Convert.ToDouble(txtsalary.Text);
                FileStream fs = new FileStream(@"D:\EmployeeData\empBinary.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, employee);
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnbinaryread_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                FileStream fs = new FileStream(@"D:\EmployeeData\empBinary.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                emp = (Employee)bf.Deserialize(fs);
                fs.Close();
                txtid.Text = emp.id.ToString();
                txtname.Text = emp.name;
                txtsalary.Text = emp.salary.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnxmlwrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.id = Convert.ToInt32(txtid.Text);
                employee.name = txtname.Text;
                employee.salary = Convert.ToDouble(txtsalary.Text);
                FileStream fs = new FileStream(@"D:\EmployeeData\empXml.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Employee));
                xs.Serialize(fs, employee);
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnxmlread_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                FileStream fs = new FileStream(@"D:\EmployeeData\empXml.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Employee));
                emp = (Employee)xs.Deserialize(fs);
                fs.Close();
                txtid.Text = emp.id.ToString();
                txtname.Text = emp.name;
                txtsalary.Text = emp.salary.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsoapwrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.id = Convert.ToInt32(txtid.Text);
                employee.name = txtname.Text;
                employee.salary = Convert.ToDouble(txtsalary.Text);
                FileStream fs = new FileStream(@"D:\EmployeeData\empSoap.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, employee);
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsoapread_Click(object sender, EventArgs e)
        {

            try
            {
                Employee emp = new Employee();
                FileStream fs = new FileStream(@"D:\EmployeeData\empSoap.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                emp = (Employee)sf.Deserialize(fs);
                fs.Close();
                txtid.Text = emp.id.ToString();
                txtname.Text = emp.name;
                txtsalary.Text = emp.salary.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnjsonwrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.id = Convert.ToInt32(txtid.Text);
                employee.name = txtname.Text;
                employee.salary = Convert.ToDouble(txtsalary.Text);
                FileStream fs = new FileStream(@"D:\EmployeeData\empJson.json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize<Employee>(fs, employee);
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnjsonread_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                FileStream fs = new FileStream(@"D:\EmployeeData\empJson.json", FileMode.Open, FileAccess.Read);
                emp = JsonSerializer.Deserialize<Employee>(fs);
                fs.Close();
                txtid.Text = emp.id.ToString();
                txtname.Text = emp.name;
                txtsalary.Text = emp.salary.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}