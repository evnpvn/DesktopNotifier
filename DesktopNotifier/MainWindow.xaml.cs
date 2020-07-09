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

namespace DesktopNotifier
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //TODO: IF Deep work checkbox is selected THEN notify every half hour
            if(DeepworkCheckbox.IsChecked == true)
            {
                //uncheck all other checkboxes
                ManagementCheckbox.IsChecked = false;
                OffCheckbox.IsChecked = false;
                            
                //activate function to give notifications every hour

                DateTime currentTime = DateTime.Now;

                if(currentTime = )

            }
        }
    }
}
