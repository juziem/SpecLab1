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

namespace Spec1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public class Fish
        //{
        //    int speed, energy, x, y;

        //    public void move (int x, int y)
        //    {
                
        //    }

        //    public int age()
        //    {
        //        int a = 0;
        //        return a;
        //    }
        //}


        public MainWindow()
        {
            InitializeComponent();

            string s=Console.ReadLine();


            Console.WriteLine(s);
        }
    }
}
