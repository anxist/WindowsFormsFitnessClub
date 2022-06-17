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
    public partial class Log_in : MaterialForm
    {
        private int CountUnsuccessful = 0;
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Log_in()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightGreen700, TextShade.WHITE);
       
            textBoxCapcha.Visible = false;
            labelCapcha.Visible=false;
            textBoxCapcha.Visible=false;
        
        }



        private void bttnEnter_Click(object sender, EventArgs e)
        {
            Command command = new Command();
            command.LoadData("Select * From log_in WHERE login = '" + textBoxLogin.Text + "' AND password = '" + textBoxPassword.Text + "'");

            if (CountUnsuccessful < 3)
            {

                if (command.MainTable.Rows.Count > 0)
                {
                    MessageBox.Show("Вы вошли под именем " + command.MainTable.Rows[0][3].ToString());
                    LoadForm(command.MainTable.Rows[0][3].ToString());
                }
                else
                {
                    MessageBox.Show("Вы ввели неправильно логин или пароль, попробуйте еще раз.");
                    CountUnsuccessful++;
                    if (CountUnsuccessful >= 3) GenereticCapcha();
                }
            }
            else
            {
                if (command.MainTable.Rows.Count > 0 && textBoxCapcha.Text == labelCapcha.Text)
                {
                    MessageBox.Show("Вы вошли под именем " + command.MainTable.Rows[0][3].ToString());
                    LoadForm(command.MainTable.Rows[0][3].ToString());
                }
                else
                {
                    MessageBox.Show("Вы ввели неправильно логин или пароль, попробуйте еще раз.");
                    GenereticCapcha();
                }
            }
        }   

        private void GenereticCapcha()
        {
            textBoxCapcha.Visible = true;
            labelCapcha.Visible = true;
            textBoxCapcha.Visible = true;

            Random rand = new Random();
            int randNum = rand.Next(1, 5);

            switch (randNum)
            {
                case 1:
                    labelCapcha.Text = "FgcyU";
                    break;
                case 2:
                    labelCapcha.Text = "iHyvT";
                    break;
                case 3:
                    labelCapcha.Text = "nUbYv";
                    break;
                case 4:
                    labelCapcha.Text = "WErft";
                    break;
            }
        }
        private void LoadForm(string _role)
        {
            switch (_role)
            {
                case "Директор":
                    Director diR = new Director();
                    diR.Show();
                    this.Hide();
                    break;
                case "Администратор":
                    Administrator admin = new Administrator();
                    admin.Show();
                    this.Hide();
                    break;
                case "Менеджер":
                    Manajer man = new Manajer();
                    man.Show();
                    this.Hide();
                    break;
            }
        }
    }
}
