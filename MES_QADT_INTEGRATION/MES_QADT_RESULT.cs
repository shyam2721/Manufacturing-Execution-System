using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES_QADT_INTEGRATION
{
    public partial class MES_QADT_RESULT : UserControl
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        DataSet ds = null;
        SqlDataAdapter sda = null;
        int i = 0;
        double lsl, usl, actual;
        public MES_QADT_RESULT()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true; //new
            dataGridView1.CellFormatting += dataGridView1_CellFormatting; //new
        }
        private void MES_QADT_RESULT_Load(object sender, EventArgs e)
        {
            QADT_RESULT_DataShow();
        }
        private void QADT_RESULT_DataShow()
        {
            ds = new DataSet();
            con = new SqlConnection("Data Source=LAPTOP-D75E4G8P\\SQLEXPRESS;Initial Catalog=mesdb;Integrated Security=True");
            try
            {
                con.Open();
                cmd = new SqlCommand("SP_QADT_RESULT_Show", con);
                cmd.CommandType = CommandType.StoredProcedure;
                sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {

                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                double lsl = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
                double usl = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
                double actual = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[9].Value);

                if (actual >= lsl && actual <= usl)
                {
                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[i].Style.BackColor = Color.Green;
                    }
                }
                else
                {
                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[i].Style.BackColor = Color.Red;
                    }
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
           
        }

        private void GetQADTResultsByHeatNo(string heatno)
        {
            ds = new DataSet();
            con = new SqlConnection("Data Source=LAPTOP-D75E4G8P\\SQLEXPRESS;Initial Catalog=mesdb;Integrated Security=True");
            try
            {
                con.Open();
                cmd = new SqlCommand("SP_GET_QADTResultsByHeatNo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@HeatNo", heatno));
                sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("No data found for the entered heat number.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            string heatNoText = txt_heat.Text.Trim();
            if (!string.IsNullOrEmpty(heatNoText))
            {
                GetQADTResultsByHeatNo(heatNoText);
            }
            else
            {
                MessageBox.Show("Please enter a valid heat number.");
            }
        }
    }
}
