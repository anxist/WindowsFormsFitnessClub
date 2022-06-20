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
    public partial class Aboniment : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Aboniment()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightGreen700, TextShade.WHITE);
        }

        private void Aboniment_Load(object sender, EventArgs e)
        {
            Command listAbonimenttype = new Command();
            listAbonimenttype.LoadData("Select * From aboniment");

            materialComboBox1.Items.AddRange(listAbonimenttype.MainTable.AsEnumerable().Select(row => $"{row["tipe"]} {row["month"]} {row["cost"]}").ToArray());

            Command listClient = new Command();
            listClient.LoadData("Select * From client");
            for (int i = 0; i < listClient.MainTable.Rows.Count; i++)
            {
                materialComboBox2.Items.Add(listClient.MainTable.Rows[i][1].ToString());
            }

        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
