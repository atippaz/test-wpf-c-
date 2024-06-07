using Microsoft.Win32;
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

namespace test
{
    /// <summary>
    /// Interaction logic for CardUpload.xaml
    /// </summary>
    public partial class CardUpload : UserControl
    {
        public CardUpload()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.DefaultExt = ".png"; // Required file extension 
            fileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png"; // Optional file extensions
            if (fileDialog.ShowDialog() == true)
            {
                image.Source = new BitmapImage(new Uri(fileDialog.FileName));
                btn_upload.Visibility = Visibility.Hidden;
            }
        }
    }
}
