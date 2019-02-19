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
using Project2;
using Project3;

namespace MultiProjectConfig
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Project2Class1 project2Class1 = new Project2Class1();
            Project3Class1 project3Class1 = new Project3Class1();

            textBox1.Text = project2Class1.MySetting1;
            textBox2.Text = project3Class1.MySetting1;

        }
    }
}
