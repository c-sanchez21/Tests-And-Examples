using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bitmaps
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

        private void MenuItem_OpenClick(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            bool? result = openFileDialog.ShowDialog();
            if(result == true)
            {
                string fullpath = openFileDialog.FileName;                
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(fullpath);
                bitmap.EndInit();
                imgViewer.Source = bitmap;
                ShowBitmapArray(bitmap);
            }
        }

        private void ShowBitmapArray(BitmapImage bmp)
        {
            int stride = (int)bmp.PixelWidth * (bmp.Format.BitsPerPixel / 8);
            byte[] pixels = new byte[(int)bmp.PixelHeight * stride];
            bmp.CopyPixels(pixels, stride, 0);
            string dataString = String.Join(" ", pixels);

            //***Previous Tests***
            //glyphImageData.UnicodeString = dataString; //Crashes
            //lblImgData.Content = dataString; //No Wrapping
            //tbImageData.Text = dataString; //Very Slow

            //Rich Text Box seems to work best in this situation.
            rtbImageData.Document.Blocks.Clear();
            rtbImageData.Document.Blocks.Add(new Paragraph(new Run(dataString)));
        }
    }
}