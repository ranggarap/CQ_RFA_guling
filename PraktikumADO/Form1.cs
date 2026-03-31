using System;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PraktikumADO
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }
        private void Koneksi()
        {
            conn = new SqlConnection(
                "Data Source=LAPTOP-M7PL4IES\\RANGGAFADHILAH;Initial Catalog=DBAkademikADO;Integrated Security=True"
                );
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {

        }
    }
}
