using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;


namespace WindowsFormsFitness
{
    public partial class Administrator : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private Command AdminLoad = new Command();
        private Command tableClient = new Command();
        private Command tableDogovor = new Command();
        private Command tableTovar = new Command();
        public Administrator()
        {
            InitializeComponent();


            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightGreen700, TextShade.WHITE);
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void LoadTable()
        {
            tableClient.LoadData("Select * From client");
            dataGridView1.DataSource = tableClient.MainTable;

            tableDogovor.LoadData("Select * From dogovor");
            dataGridView4.DataSource = tableDogovor.MainTable;

            tableTovar.LoadData("Select * From goods");
            dataGridView2.DataSource = tableTovar.MainTable;
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void payAboniment_Click(object sender, EventArgs e)
        {
            Aboniment abon = new Aboniment();
            abon.Show();

        }

        private void payAboniment2_Click(object sender, EventArgs e)
        {
            Aboniment abon = new Aboniment();
            abon.Show();
        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {
            Aboniment abon = new Aboniment();
            abon.Show();
        }

        private void materialFloatingActionButton3_Click(object sender, EventArgs e)
        {
            Aboniment abon = new Aboniment();
            abon.Show();
        }

        private void materialFloatingActionButton8_Click(object sender, EventArgs e)
        {
            Aboniment abon = new Aboniment();
            abon.Show();
        }

        private void materialFloatingActionButton6_Click(object sender, EventArgs e)
        {
            Aboniment abon = new Aboniment();
            abon.Show();
        }

        private void materialFloatingActionButton5_Click(object sender, EventArgs e)
        {
            Aboniment abon = new Aboniment();
            abon.Show();
        }

        private void materialFloatingActionButton7_Click(object sender, EventArgs e)
        {
            Aboniment abon = new Aboniment();
            abon.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Tovar tovar = new Tovar();
            tovar.Show();
        }

       

        private void search_Click(object sender, EventArgs e)
        {
            Command command = new Command();
            command.LoadData($"Select * From client WHERE surname = '{materialTextBox2.Text}'");
            command.LoadData($"Select * From client WHERE name = '{materialTextBox2.Text}'");
            command.LoadData($"Select * From client WHERE fathername = '{materialTextBox2.Text}'");

            DataRow clientSurname = command.MainTable.Rows[1];
            DataRow clientName = command.MainTable.Rows[2];
            DataRow clientFathername = command.MainTable.Rows[3];
            DataRow clientID = command.MainTable.Rows[0];
            if (clientSurname != null)
            {
                tableClient.LoadData("Select * From client");
                dataGridView1.DataSource = clientSurname;
            }
            else if (clientName != null)
            {
                tableClient.LoadData("Select * From client");
                dataGridView1.DataSource = clientSurname;
            }
            else if (clientFathername != null)
            {
                tableClient.LoadData("Select * From client");
                dataGridView1.DataSource = clientSurname;
            }

       
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadTable();
        }

    }
}
