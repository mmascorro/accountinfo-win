using accountinfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace accountinfo_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private AccountInfoService ais;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ais.registerWithServer();
        }

        private void doStuff(object sender, RoutedEventArgs e)
        {
            ais = new AccountInfoService();

            serialTextBox.Text = ais.serial;

            localComputerNameLabel.Content = Environment.MachineName;

            ais.getRemoteInfo();
            remoteComputerNameLabel.Content = ais.remoteName;
            adobeAccountTextBox.Text = ais.account;
        }
    }
}
