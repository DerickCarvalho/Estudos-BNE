using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaceGrafica
{
    public partial class Login : Form
    {
        AdmPage adminPage;
        DataTable table = new DataTable();
        public Login(AdmPage adm)
        {
            InitializeComponent();
            adminPage = adm;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = userName.Text;
            string passowrd = passWord.Text;

            if (username == "" || passowrd == "")
            {
                MessageBox.Show("CAMPO(S) VAZIO(S)!");
                userName.Focus();
                return;
            }

            // Sempre usar o apostrofo antes das aspas para poder concatenar strings.
            string sql = "SELECT * FROM usu_adm WHERE usu_login='" + username + "' AND usu_pass='" + passowrd + "'";
            table = dataBase.GenericSearch(sql);

            if (table.Rows.Count == 1 )
            {
                MessageBox.Show("USUÁRIO LOGADO COM SUCESSO!");
                adminPage.adminName = table.Rows[0].ItemArray[1].ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("USUÁRIO NÃO ENCONTRADO!");
            }
        }
    }
}
