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
using System.IO;

namespace Zad9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string path = @"D:\FilesForVS";



            System.IO.File.AppendAllText("D:\\TestFile.txt", "Иванов,Иван,Иванович,Ленина,147,38,0,");
            System.IO.File.AppendAllText("D:\\TestFile.txt", "Петров,Петр,Петрович,Ленина,147,38,89106603450,");
            System.IO.File.AppendAllText("D:\\TestFile.txt", "Гыг,Гыг,Гыг,Ленина,147,38,76857465786,");
            System.IO.File.AppendAllText("D:\\TestFile.txt", "Гаг,Гаг,Гаг,Ленина,147,38,0,");


            string student = File.ReadAllText(@"D:\\TestFile.txt");

            int v = 0;
            while(student.Split(',')[v] != "")
            //for (int v = 0; v < 28; v++)
            {

                if (student.Split(',')[v] == "0")
                {
                    textBlock.Text += student.Split(',')[v - 6] + " " + student.Split(',')[v - 5] + " " + student.Split(',')[v - 3] + " " + student.Split(',')[v - 2] + " " + student.Split(',')[v - 1]+ "; \n";
                }
                v++;
            }
            
        }
    }
}

