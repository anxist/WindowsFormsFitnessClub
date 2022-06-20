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
    public partial class Director : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private Command tableEmp = new Command();
        private Command tableDogovor = new Command(); 
        public Director()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightGreen700, TextShade.WHITE);
        }

        private void Director_Load(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void LoadTable()
        {
            tableEmp.LoadData("Select * From employee");
            dataGridView1.DataSource = tableEmp.MainTable;

            tableDogovor.LoadData("Select * From dogovor");
            dataGridView4.DataSource = tableDogovor.MainTable;
        }

        private void Delite_Click(object sender, EventArgs e)
        {

        }
    }
}
