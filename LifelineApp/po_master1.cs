using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    public partial class po_master1 : Form
    {
        public void updatedata(double tot, double totdis, double gst)
        {
           /* //double gst = 0;
           // con.Open();
            string qry = "select po_id,batch_no,expiry,mrp,rate,qty,total,discount,free_qty from podetails where po_id='" + dpm + "' And batch_no='" + batno + "' and total='" + mrp + "'";
            da = new MySqlDataAdapter(qry, con);
            da.Fill(data);
            DataRow r;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                // Access the current row
                //DataRow r = table.Rows[i];
                r = data.Rows[i];
                DataRow destRow = table.NewRow();
                destRow.ItemArray = r.ItemArray;
                table.Rows.Add(destRow);

                /*DataRow row = dt.Rows[i];
                 
                   
                    newRow["po_id"] = dt.Columns[0];
                    newRow["batch_no"] = dt.Columns[1];
                    newRow["expiry"] = dt.Columns[2];
                    newRow["mrp"] = dt.Columns[3];
                    newRow["rate"] = dt.Columns[4];
                    newRow["qty"] = dt.Columns[5];
                    newRow["total"] = dt.Columns[6];
                    newRow["discount"] = dt.Columns[7];
                    newRow["free_qty"] = dt.Columns[8];


                    

                    // table.Columns.Add(c);
                     
                    //DataColumn dc = table.Columns[i];
                    
                    /*double to = Convert.ToDouble(row[c]);
                    j++;
                    c = table1.Columns[j];
                    double di = Convert.ToDouble(row[c]);
                    //calculating taxable amount
                    double ta = to - di;
                    l7.Text = ta.ToString();
                    // calculating gst
                    j++;
                    c = table1.Columns[j];
                    gst = gst + (ta * Convert.ToDouble(row[c])) / 100;
                    break;
                
                table.Rows.Add(newRow);
            }
            table.Rows.Add(da);*/

            dataGridView1.DataSource = table;
            total = total + tot;
            label5.Text = total.ToString();

            tot_disc = tot_disc + totdis;
            label6.Text = tot_disc.ToString();

            diftotdis = total - totdis;
            label8.Text = diftotdis.ToString();

            gst_tot = gst_tot + gst;
            ft.Text = Math.Round(gst_tot, 2).ToString();

            /*string q = "select sum(total) from podetails";
            cmd = new MySqlCommand(q, con);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            //label5 is for price total
             //Math.Round(Double.Parse(reader.GetString(0)), 2).ToString();
            reader.Close();

            string qs = "select sum(discount) from podetails";
            cmd = new MySqlCommand(qs, con);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader1 = cmd.ExecuteReader();
            reader1.Read();
            //label6 is for total discount   
            
            reader1.Close();
            con.Close();

            double a = Double.Parse(label5.Text);
            double b = Double.Parse(label6.Text);
            //label8 is for total - discount
            
            con.Close();
            //new label for final total
            //getting sum of all total and discount with same gst

            string q1 = "select sum(total),sum(discount),sgst,cgst from podetails group by sgst";
            con.Open();
            DataTable table1 = new DataTable();
            da = new MySqlDataAdapter(q1, con);
            da.Fill(table1);
            for (int i = 0; i < table1.Rows.Count; i++)
            {
                DataRow row = table1.Rows[i];
                for (int j = 0; j < table1.Columns.Count; i++)
                {
                    DataColumn c = table1.Columns[j];
                    double to = Convert.ToDouble(row[c]);
                    j++;
                    c = table1.Columns[j];
                    double di = Convert.ToDouble(row[c]);
                    //calculating taxable amount
                    double ta = to - di;
                    l7.Text = ta.ToString();
                    // calculating gst
                    j++;
                    c = table1.Columns[j];
                    gst = gst + (ta * Convert.ToDouble(row[c])) / 100;
                    break;
                }

            }

            //Final Amount
            double du = Double.Parse(label8.Text);
            gst = gst + gst + du;
            
            con.Close();

            //select sum(total) from prj131lifeline.podetails group by po_id;*/
        }
        MySqlConnection con = new MySqlConnection("server=115.96.168.103;user=prj131;pwd=prj131@lifeline;database=prj131lifeline;port=3306");
        MySqlDataAdapter da;
        MySqlCommand cmd;
        MySqlDataReader dr;
        string DelearID = string.Empty;
        int dpm, batno;
        double mrp,total = 0, tot_disc = 0, diftotdis = 0, gst_tot = 0;
        DataTable table = new DataTable();
        DataTable data = new DataTable();

        public po_master1()
        {

            table.Columns.Add("po_id");
            table.Columns.Add("batch_no");
            table.Columns.Add("expiry");
            table.Columns.Add("mrp");
            table.Columns.Add("rate");
            table.Columns.Add("qty");
            table.Columns.Add("total");
            table.Columns.Add("discount");
            table.Columns.Add("free_qty");
            InitializeComponent();
        }

        private void po_master1_Load(object sender, EventArgs e)
        {


            deler();
            string a;
            MySqlDataReader dr;
            cmd = new MySqlCommand("select count(*) from podetails", con);
            con.Open();
            dr = cmd.ExecuteReader();
            dr.Read();
            if (Convert.ToInt32(dr[0]) != 0)
            {
                con.Close();
               // updatedata();
            }
            con.Close();
        }

        public void deler()
        {
            con.Open();
            cmd = new MySqlCommand("select distinct name from dlrmaster", con);

            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    comboBox2.Items.Add(dr[0].ToString());
                }
                dr.Close();
            }
            dr.Close();
            con.Close();
        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                cmd = new MySqlCommand("select id from dlrmaster where name='" + comboBox2.Text + "'", con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        DelearID = dr[0].ToString();
                    }
                    dr.Close();
                }
                dr.Close();
                con.Close();
            }

            textBox_id.Text = "" + DelearID;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string sup = textBox_id.Text;
            string tr = textBox_trtype.Text;
            string bill = textBox1.Text;
            string date = dateTimePicker1.Text;
            string s = "insert into pomaster(inc_date,sup_id,sup_bill_no,tr_tp) values('" + date + "','" + sup + "','" + bill + "','" + tr + "')";
            cmd = new MySqlCommand(s, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("product details inserted");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            podetail pod = new podetail();
            pod.ShowDialog();
            /*
                        dpm = pod.t;
                        batno = pod.ban;
                        mrp = pod.pmr;*/


            table.Rows.Add(pod.textBox_pid.Text, pod.textBox1_batch.Text, pod.textBox2_ex.Text, pod.textBox3_MRP.Text, pod.textBox4_rate.Text, pod.textBox5_qty.Text, pod.textBox_total.Text, pod.pmr, pod.textBox7_free.Text);

            updatedata(Double.Parse(pod.textBox_total.Text), pod.pmr, pod.fgt);
            pod.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_trtype_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {



                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["po_id"].Value);

                table.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                con.Open();

                //dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                string s = "delete from podetails where po_id='" + id + "'";
                cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Record deleted!");

            }
            else
            {
                MessageBox.Show("Please Select the row first");
            }
        }
    }
}
