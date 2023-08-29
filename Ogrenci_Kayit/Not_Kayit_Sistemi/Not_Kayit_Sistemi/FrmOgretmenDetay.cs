using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Not_Kayit_Sistemi
{
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=MERT;Initial Catalog=DbNotKayit;Integrated Security=True");

        public void IsFailed()
        {
            int failed = 0;
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM TBLDERS  where ORTALAMA <50 OR  ORTALAMA IS NULL;",connection);
            connection.Open();
            failed =Convert.ToInt32(command.ExecuteScalar());
            //MessageBox.Show(failed.ToString());
            lblKalanSayisi.Text = failed.ToString();
            connection.Close();


        }
        public void IsSucces()
        {
            int succes = 0;
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM TBLDERS  where ORTALAMA > 50 ", connection);
            connection.Open();
            succes = Convert.ToInt32(command.ExecuteScalar());
            //MessageBox.Show(succes.ToString());
            lblGecenSayisi.Text = succes.ToString();

            connection.Close();


        }
        public void DataGridViewList()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From TBLDERS", connection);
            DataSet dataset = new DataSet();
            connection.Open();
            adapter.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
            connection.Close();
            
        }
        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            DataGridViewList();
            IsFailed();
            IsSucces();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            string durum;
         

            s1 = Convert.ToDouble(txtSınav1.Text);
            s2 = Convert.ToDouble(txtSınav2.Text);
            s3 = Convert.ToDouble(txtSınav3.Text);
            ortalama = (s1 + s2 + s3) / 3;
            if (ortalama >= 50)
            {
                durum = "True";
            }
            else
            {
                durum = "false";
            }
            lblortalama.Text = Convert.ToString(ortalama);
            connection.Open();
            SqlCommand komut = new SqlCommand("UPDATE TBLDERS SET OGRS1=@P1, OGRS2=@P2, OGRS3=@P3,ORTALAMA=@P4,DURUM=@P5 WHERE OGRNUMARA=@P6", connection);
            komut.Parameters.AddWithValue("@P1", txtSınav1.Text);
            komut.Parameters.AddWithValue("@P2", txtSınav2.Text);
            komut.Parameters.AddWithValue("@P3", txtSınav3.Text);
            komut.Parameters.AddWithValue("@P4", decimal.Parse(lblortalama.Text));
            komut.Parameters.AddWithValue("@p5", durum);
            komut.Parameters.AddWithValue("@P6", msknumara.Text);
            komut.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Öğrenci Notları Güncellendi");
            DataGridViewList();
            IsSucces();
            IsFailed();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into TBLDERS(OGRNUMARA,OGRAD,OGRSOYAD) values (@p1,@p2,@p3)", connection);
            cmd.Parameters.AddWithValue("@p1", msknumara.Text);
            cmd.Parameters.AddWithValue("@p2", txtad.Text);
            cmd.Parameters.AddWithValue("@p3", txtSoyad.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Öğrenci Sisteme Eklendi!");
            DataGridViewList();
            IsSucces();
            IsFailed();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satır = dataGridView1.SelectedCells[0].RowIndex;

            msknumara.Text = dataGridView1.Rows[satır].Cells[1].Value.ToString();
            txtad.Text = dataGridView1.Rows[satır].Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[satır].Cells[3].Value.ToString();


            txtSınav1.Text = dataGridView1.Rows[satır].Cells[4].Value.ToString();
            txtSınav2.Text = dataGridView1.Rows[satır].Cells[5].Value.ToString();
            txtSınav3.Text = dataGridView1.Rows[satır].Cells[6].Value.ToString();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
