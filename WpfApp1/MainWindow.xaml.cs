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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ButtonAddName_Click(Object sender, EventArgs args)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
            {
                lstNames.Items.Add(txtName.Text);
                txtName.Clear();

            }
          
        }
        void OnClick1(object sender, RoutedEventArgs e)
        {
            btn1.Background = Brushes.LightBlue;
        }

        void OnClick2(object sender, RoutedEventArgs e)
        {
            btn2.Background = Brushes.Pink;
        }

        void OnClick3(object sender, RoutedEventArgs e)
        {
            btn1.Background = Brushes.Pink;
            btn2.Background = Brushes.LightBlue;
        }

        
    }
}
