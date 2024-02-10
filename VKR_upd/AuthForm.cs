using MySql.Data.MySqlClient;
namespace VKR_upd
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loginTXT = textBox1.Text;
            string passwordTXT = textBox2.Text;

            string connStr = "server=pma.sdlik.ru;port=62002;user=st_8;database=is_8_EKZ;password=123456789;";
            MySqlConnection conn;
            conn = new MySqlConnection(connStr);

            conn.Open();

            string querySql = $"SELECT COUNT(*) FROM Employees WHERE login_users='{loginTXT}' and pass_users='{passwordTXT}' and enabled_users=1";
            MySqlCommand authCom = new MySqlCommand(querySql, conn);
            string result = authCom.ExecuteScalar().ToString();

            if (Convert.ToInt32(result) > 0)
            {
                MessageBox.Show($"User Authorization {loginTXT} Successful");
            }
            else
            {
                MessageBox.Show($"User Authorization {loginTXT} Failed");
                Application.Exit();
            }
            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}