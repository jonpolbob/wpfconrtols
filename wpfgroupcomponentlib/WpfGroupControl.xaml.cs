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
    /// Logique d'interaction pour WpfGroupControl.xaml
    /// </summary>
    public partial class WpfGroupControl : UserControl
    {
        public System.Collections.ObjectModel.ObservableCollection<GroupClass> m_laliste = new System.Collections.ObjectModel.ObservableCollection<GroupClass>();


        public Size MeasureString(string s)
        {

            if (string.IsNullOrEmpty(s))
            {
                return new Size(0, 0);
            }

            var TextBlock = new TextBlock()
            {
                Text = "_"+s+"_"
            };

            TextBlock.Measure(new Size(Double.PositiveInfinity, Double.PositiveInfinity));

            return new Size(TextBlock.DesiredSize.Width, TextBlock.DesiredSize.Height);
        }

        public WpfGroupControl()
        {
            InitializeComponent();

            this.LeDataList.ItemsSource = m_laliste;

            m_laliste.Add(new GroupClass
            {
                NumGroup = 0,
                GroupColor = "red",
                GroupName = "default",
                Value1 = "0",
                Value2 = "0"
            }
                        );


            m_laliste.Add(new GroupClass
            {
                NumGroup = 1,
                GroupColor = "Blue",
                GroupName = "group2",
                Value1 = "01",
                Value2 = "toto"
            }
            );

         



        }

        private void LeDataList_Loaded(object sender, RoutedEventArgs e)
        {
            LeDataList.Columns[0].Header = "Num";

            LeDataList.Columns[0].Width = MeasureString(LeDataList.Columns[0].Header.ToString()).Width;
            LeDataList.Columns[1].Header = "Group";
            LeDataList.Columns[2].Header = "Color";
            LeDataList.Columns[3].Visibility = Visibility.Collapsed;
            LeDataList.Columns[4].Visibility = Visibility.Collapsed;
        }
    }
}
