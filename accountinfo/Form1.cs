using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace accountinfo
{
    public partial class AccountInfo : Form
    {
        public AccountInfo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AccountInfoService ais = new AccountInfoService();

            serialTextBox.Text = ais.serial;

            computerNameLabel.Text = Environment.MachineName;

            adobeAccountTextBox.Text = ais.registerWithServer();

        }
    }
}
