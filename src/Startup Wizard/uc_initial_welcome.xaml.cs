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

namespace Asset_and_Maintenance_Management_System.src.Startup_Wizard
{
    /// <summary>
    /// Interaction logic for uc_initial_welcome.xaml
    /// </summary>
    public partial class uc_initial_welcome : UserControl
    {
        public uc_initial_welcome()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        public string[] getTxtInfo()
        {
            string[] info = { txt_compName.Text, txt_fascilCount.Text };
            return info;
        }

        public void resetTxt()
        {
            txt_compName.Clear();
            txt_fascilCount.Clear();
        }
    }
}
