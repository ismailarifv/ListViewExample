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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ListViewExample
{
    public partial class Form1 : Form
    {
        SqlConnection db = new SqlConnection(@"Data Source=DESKTOP-6I3C0B5\SQLEXPRESS;initial catalog=schoolDb;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try {
                db.Open();
                MessageBox.Show("Bağlantı gerçekleşti","Sql Bağlantısı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                db.Close();
            } catch (Exception errorMessage){
                MessageBox.Show(errorMessage.Message, "Bağlantı Gerçekleşemedi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

           
           



            listView1.View = View.Details;

            listView1.FullRowSelect = true;
            listView1.Columns.Add("Id", 10);
            listView1.Columns.Add("Name", 100);
            listView1.Columns.Add("Surname", 100);
            listView1.Columns.Add("Age", 10);
            listView1.Columns.Add("Status", 50);

            string[] erhanInformation = { "1", "Erhan", "Kaya", "33", "Active"};

            listView1.Items.Add(new ListViewItem(erhanInformation));


            status_cmbx.SelectedIndex = 0;


            listView2.View = View.Details;

            listView2.FullRowSelect = true;
            listView2.Columns.Add("Id", 50);
            listView2.Columns.Add("Name", 100);
            listView2.Columns.Add("Surname", 100);
            listView2.Columns.Add("Age", 50);
            listView2.Columns.Add("CassesId", 50);
            listView2.Columns.Add("Status", 50);

        }
        int id = 1;
        private void add_btn_Click(object sender, EventArgs e)
        {
            id++;
            string[] userInformation = new string[5];

            userInformation[0] = id.ToString();
            userInformation[1] = name_txt.Text;
            userInformation[2] = surname_txt.Text;
            userInformation[3] = age_nupd.Value.ToString();
            userInformation[4] = status_cmbx.SelectedItem.ToString();

            listView1.Items.Add(new ListViewItem(userInformation));

            MessageBox.Show("Kullanıcı Ekleme Başarılı",
                "Add User",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void getUser_btn_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            db.Open();

            string query = "select * from Students";
            SqlCommand sqlCommand = new SqlCommand(query, db);
            //SqlDataReader reader = sqlCommand.ExecuteReader();

            //while (reader.Read())
            //{
            // string[] studentInformation = { reader["Id"].ToString(),
            // reader["Name"].ToString(),
            // reader["Surname"].ToString(),
            // reader["Age"].ToString(),
            // reader["ClassesId"].ToString(),
            // reader["Status"].ToString(),
            // };
            // listView2.Items.Add(new ListViewItem(studentInformation));
            //}

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                string[] studentInformation = { dr["Id"].ToString(),
                    dr["Name"].ToString(),
                    dr["Surname"].ToString(),
                    dr["Age"].ToString(),
                    dr["ClassesId"].ToString(),
                    dr["Status"].ToString(),
                    };
                listView2.Items.Add(new ListViewItem(studentInformation));
            }


            db.Close();
        }
    

    }
}
