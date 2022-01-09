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
using QuanLyQuanCafe.DAO;

namespace QuanLyQuanCafe
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadAccountList();
        }

        void LoadFoodList()
        {
            string query = "SELECT * FROM dbo.food";

            dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { "admin" });

        }

        void LoadAccountList()
        {
            string query = "dbo.USP_GetAccountByUserName @UserName";

            dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { "admin" });

        }

        private void dtgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
