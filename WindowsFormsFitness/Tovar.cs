﻿using System;
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
    
    public partial class Tovar : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Tovar()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightGreen700, TextShade.WHITE);
        }

        private void Tovar_Load(object sender, EventArgs e)
        {
            Command listTovar = new Command();
            listTovar.LoadData("Select * From goods");
            for(int i = 0; i < listTovar.MainTable.Rows.Count; i++)
            {
                materialComboBox1.Items.Add(listTovar.MainTable.Rows[i][1].ToString());
            }

            Command listClient = new Command();
            listClient.LoadData("Select * From client");
            for (int i = 0; i < listClient.MainTable.Rows.Count; i++)
            {
                materialComboBox2.Items.Add(listClient.MainTable.Rows[i][1].ToString());
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Command addProdaja = new Command();

           // addProdaja.AddParametr("@ID_goods", SqlDbType.VarChar);

            addProdaja.SendCommand("Insert Into otchet (@ID_goods)");
            MessageBox.Show("Запись добавлена!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

   
    }
}
