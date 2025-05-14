using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace NA_Editor.Modules
{
    /// <summary>
    /// Interaction logic for ucMonEdit.xaml
    /// </summary>
    public partial class ucMonEdit : UserControl
    {
        public ucMonEdit()
        {
            InitializeComponent();
        }

        private void Button_AddImage_Click(object sender, RoutedEventArgs e)
        {
            var d = new OpenFileDialog();
            if (d.ShowDialog() == true)
            {
                string fullpath = d.FileName;
                string file = System.IO.Path.GetFileName(fullpath);
                Label_Filename.Content = file;
                Label_Filepath.Content = fullpath;
            }
        }
    }
}
