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
        private AccountInfoService ais;

        public AccountInfo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ais = new AccountInfoService();

            serialTextBox.Text = ais.serial;

            localComputerNameLabel.Text = Environment.MachineName;

            this.ais.getRemoteInfo();
            remoteComputerNameLabel.Text = this.ais.remoteName;
            adobeAccountTextBox.Text = this.ais.account;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            this.ais.registerWithServer();
        }
    }
}
