using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;

namespace ADO.NETAssignment
{

    public partial class Studprofile : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader r = null;
        string constr = " Data Source=(local);Initial Catalog=AssignmentDB;Integrated Security=True;Pooling=False";
        private object RollNo;
        private object txtname;
        private object rbMale;
        private object rbFemale;
        private object department;
        private readonly object course;
        private object semester;
        private object address;
        private object phonenumber;
        private readonly object txtRollNo;

        public Studprofile()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string RollNo = txtbrno.Text;
            string Name = txtbname.Text;
            string gender = " ";
            if (rbmale.Checked)
                gender = rbmale.Text;
            if (rbfemale.Checked)
                gender = rbfemale.Text;
            string department = cbdepartment.SelectedItem.ToString();
            string course = cbcourse.SelectedItem.ToString();
            string semester = cbsemester.SelectedItem.ToString();
            string address = txtbaddress.Text;
            string phonenumber = txtboxphone.Text;
            MessageBox.Show(RollNo + "\n" + Name + "," + gender + "\n" + department + "\n" + course + "\n" + semester + "\n" + address + "\n" + phonenumber);



        }

        private void btnselect_Click(object sender, EventArgs e)
        {

            try
            {
                con = new SqlConnection(constr);
                con.Open();
                string query = "select*from StudentInfo";
                cmd = new SqlCommand(query, con);
                r = cmd.ExecuteReader();
                lbselect.Items.Clear();
                while (r.Read())
                {
                    for (int i = 0; i < r.FieldCount; i++)
                    {
                        lbselect.Items.Add(r[i]);



                    }
                    lbselect.Items.Add("*************");

                }
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }


        }

        private void cbdoj_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                string RollNo = txtbrno.Text;
                con = new SqlConnection(constr);
                con.Open();
                string query = "delete from StudentInfo where RollNo=@rn";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@rn", RollNo);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    MessageBox.Show("DATA DELETED" + res);
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            try
            {
                int RollNo = int.Parse(txtbrno.Text);
                con = new SqlConnection(constr);
                con.Open();


                string query = "select * from StudentInfo where RollNo=@roll";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@roll", RollNo);
                r = cmd.ExecuteReader();
                lbselect.Items.Clear();
                while (r.Read())
                {
                    for (int i = 0; i < r.FieldCount; i++)
                    {
                        lbselect.Items.Add(r[i]);
                    }
                }
                lbselect.Items.Add("************");
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string semester = cbsemester.SelectedItem.ToString();
                string address = txtbaddress.Text;
                //string phonenumber = txtboxphone.Text;
                con = new SqlConnection(constr);
                con.Open();
                string query = "update StudentInfo set Semester=@sem,Address=@addr";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@sem", semester);
                cmd.Parameters.AddWithValue("@addr", address);
                //cmd.Parameters.AddWithValue("@pn", phonenumber);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    MessageBox.Show("DATA UPDATED:" + res);
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}

            
    

