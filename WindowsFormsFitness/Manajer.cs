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
    
    public partial class Manajer :MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private Command tableClient = new Command();
        private int selectIndex = 0;
        
        public Manajer()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightGreen700, TextShade.WHITE);
        }

        private void Manajer_Load(object sender, EventArgs e)
        {
        
        }

        private void Manform(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void LoadTable()
        {
            tableClient.LoadData("Select * From client");
            dataGridView1.DataSource = tableClient.MainTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void Delite_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотитее удалить " + dataGridView1[1, selectIndex].Value.ToString() + "?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Command deliteClient  = new Command();
                deliteClient.SendCommand("Delite client WHERE ID_client = " + dataGridView1[0, selectIndex].Value.ToString());
            }
        }
    }
}
