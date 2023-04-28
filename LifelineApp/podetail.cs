using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Expr;
using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace LifelineApp
{
    public partial class podetail : Form
    {
        public int t, ban;
        public double c, d, fgt, tt, pmr;
        MySqlConnection con = new MySqlConnection("server=115.96.168.103;user=prj131;pwd=prj131@lifeline;database=prj131lifeline;port=3306");
        MySqlDataAdapter da;
        DataTable dt = new DataTable("dlrmaster");
        MySqlCommand cmd;
        MySqlDataReader dr;


        string ProductID = string.Empty;



        public podetail()
        {
            InitializeComponent();
        }

        private void combobox_1p_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobox_1p.SelectedIndex != -1)
            {
                cmd = new MySqlCommand("select id,sgst,cgst from prodlist where name='" + combobox_1p.Text + "'", con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ProductID = dr[0].ToString();
                        c = Double.Parse(dr[1].ToString());
                        d = Double.Parse(dr[2].ToString());
                        tb1.Text = (c + d).ToString();
                        fgt = c + d;
                    }
                    dr.Close();
                }
                dr.Close();
                con.Close();
            }
            textBox_pid.Text = "" + ProductID;
        }

        private void podetail_Load(object sender, EventArgs e)
        {

            product();
            //po_master1 pom = new po_master1(new DataTable());
            //DataGridView dataGridView1 = pom.dataGridView1;

        }

        public void product()
        {
            cmd = new MySqlCommand("select distinct name from prodlist", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    combobox_1p.Items.Add(dr[0].ToString());
                    // a = dr[1].ToString();
                    //string b = dr[2].ToString();
                    //tb1.Text = b;
                    // tb1.Text = (a + b).ToString();
                }
                dr.Close();
            }
            dr.Close();
            con.Close();
            /*cmd = new MySqlCommand("select cgst,sgst from prodlist where name= '" + combobox_1p.Text + "'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    // a = dr[1].ToString();
                    //string a = dr[0].ToString();
                    //string b = dr[1].ToString();
                    int c = Convert.ToInt32(dr[0].ToString());
                    int d = Convert.ToInt32(dr[1].ToString());
                    tb1.Text = (c + d).ToString();
                    // tb1.Text = (a + b).ToString();
                }
                dr.Close();
            }
            dr.Close();
            con.Close();*/
        }

        private void comboBox_d_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 0;
            tt = Double.Parse(textBox_total.Text);
            if (cb1.Text.Equals("Percentage"))
            {
                a = Double.Parse(textBox6_dis.Text);
                a = (a * tt) / 100;

            }
            if (cb1.Text.Equals("Cash"))
            {
                a = Double.Parse(textBox6_dis.Text);
            }

            tt = tt - a;
            fgt = (tt * fgt) / 100;
            fgt = fgt + tt;
            /*con.Open();
            string s = "insert into podetails(drug_id,batch_no,expiry,mrp,rate,qty,total,discount,cgst,sgst,gst_total,free_qty) values('" + textBox_pid.Text + "'," + textBox1_batch.Text + ",'" + textBox2_ex.Text + "','" + textBox3_MRP.Text + "','" + textBox4_rate.Text + "','" + textBox5_qty.Text + "','" + textBox_total.Text + "','" + a + "','" + d + "','" + c + "','" + fgt + "','" + textBox7_free.Text + "')";
            cmd = new MySqlCommand(s, con);*/
            //DataTable dt = new DataTable();

            t = Convert.ToInt32(textBox_pid.Text);
            ban = Convert.ToInt32(textBox1_batch.Text);
            pmr = a;

            /*dt.Columns.Add("po_id");
            dt.Columns.Add("batch_no");
            dt.Columns.Add("expiry");
            dt.Columns.Add("mrp");
            dt.Columns.Add("rate");
            dt.Columns.Add("qty");
            dt.Columns.Add("total");
            dt.Columns.Add("discount");
            dt.Columns.Add("free_qty");
            dt.Rows.Add(textBox_pid.Text, textBox1_batch.Text, textBox2_ex.Text, textBox3_MRP.Text, textBox4_rate.Text, textBox5_qty.Text, textBox_total.Text, a, textBox7_free.Text);
            //po_id,batch_no,expiry,mrp,rate,qty,total,discount,free_qty*/
           // cmd.ExecuteNonQuery();
            

            this.Close();
            //po_master1 p = new po_master1(t,ban,pmr);
            //p.dpm = Convert.ToDouble(textBox_pid.Text);
        }

        private void textBox5_qty_Leave(object sender, EventArgs e)
        {
            if (textBox5_qty.Text.Equals("") || textBox4_rate.Text.Equals(""))
            {
                /*
                int a = Int32.Parse(textBox4_ra te.Text);
                int b = Int32.Parse(textBox5_qty.Text);
                int total = a * b;
                textBox_total.Text = "" + total;
                */
            }
            else
            {
                double a = Double.Parse(textBox4_rate.Text);
                double b = Double.Parse(textBox5_qty.Text);
                double total = a * b;
                textBox_total.Text = total.ToString();
            }
        }

        private void textBox4_rate_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_rate_FontChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_rate_MouseLeave(object sender, EventArgs e)
        {

        }

        private void textBox4_rate_Leave(object sender, EventArgs e)
        {

            if (textBox5_qty.Text.Equals("") || textBox4_rate.Text.Equals(""))
            {
                /*
                int a = Int32.Parse(textBox4_rate.Text);
                int b = Int32.Parse(textBox5_qty.Text);
                int total = a * b;
                textBox_total.Text = "" + total;
                */
            }
            else
            {

                double a = Double.Parse(textBox4_rate.Text);
                double b = Double.Parse(textBox5_qty.Text);
                double total = a * b;
                textBox_total.Text = total.ToString();
            }
        }

        private void textBox5_qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_pid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
