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

namespace wpfgroupcomponentlib
{
    /// <summary>
    /// Interaction logic for MyColorPicker.xaml
    /// </summary>
    public partial class MyColorPicker : UserControl
    {
        System.Collections.ObjectModel.ObservableCollection<string> m_laliste = new System.Collections.ObjectModel.ObservableCollection<string>();

        public MyColorPicker()
        {
            InitializeComponent();
            this.lalistebuttons.ItemsSource = m_laliste;
            m_laliste.Add("red");
            m_laliste.Add("green");
            m_laliste.Add("Blue");
            m_laliste.Add("Pink");

        }

        public Brush selectedcolorname { set; get; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button lebouton = sender as Button;
            selectedcolorname = lebouton.Background;
            if ((this.Parent as Window) != null)
            {
                (this.Parent as Window).Close();
            }
        }
    }
}
