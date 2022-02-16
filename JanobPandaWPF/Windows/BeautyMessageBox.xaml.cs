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
using System.Windows.Shapes;

namespace JanobPandaWPF.Windows
{
    /// <summary>
    /// Interaction logic for BeautyMessageBox.xaml
    /// </summary>
    public partial class BeautyMessageBox : Window
    {
        public BeautyMessageBox()
        {
            InitializeComponent();
        }

        private static MessageBoxResult result = MessageBoxResult.Cancel;
        public static MessageBoxResult ShowIt(string message, string title = "Message")
        {
            BeautyMessageBox box = new BeautyMessageBox();

            box.messageTxt.Text = message;
            box.Title = title;
            box.ShowDialog();
            return result;
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            result = MessageBoxResult.OK;
            this.Close();
        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            result = MessageBoxResult.Cancel;
            this.Close();
            var res = MessageBox.Show("drgtrg", "Error", MessageBoxButton.YesNo);

        }
        
    }
}
