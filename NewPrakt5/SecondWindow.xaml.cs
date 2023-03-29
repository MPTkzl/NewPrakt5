using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;
using NewPrakt5.kladbiweDataSetTableAdapters;

namespace NewPrakt5
{
    /// <summary>
    /// Логика взаимодействия для SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        Seats_SalesTableAdapter Seats = new Seats_SalesTableAdapter();
        
   
        public SecondWindow()
        {
            InitializeComponent();
            PokypkaDG.ItemsSource = Seats.GetData();        
        }

        private void chek_Click(object sender, RoutedEventArgs e)
        {
            if (PokypkaDG.SelectedItem != null)
            {

                DataRowView rowView = (DataRowView)PokypkaDG.SelectedItem;
                string rowData = string.Join(",", rowView.Row.ItemArray);


                string fileName = "chek.txt";
                string filePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);


                using (StreamWriter writer = new StreamWriter(filePath, false))
                {
                    writer.WriteLine(rowData);
                }

                MessageBox.Show("Данные успешно сохранены в чек");
            }
            else
            {
                MessageBox.Show("Выберите строку для сохранения данных");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main= new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
