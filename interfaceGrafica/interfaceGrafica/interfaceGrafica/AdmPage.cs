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
    public partial class AdmPage : Form
    {

        public string adminName = null;
        public AdmPage()
        {
            InitializeComponent();
            Login loginPage = new Login(this);
            loginPage.ShowDialog();

            admName.Text = adminName;
        }
    }
}
