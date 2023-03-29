using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.Xml.Linq;
using NewPrakt5.kladbiweDataSetTableAdapters;

namespace NewPrakt5
{
    /// <summary>
    /// Логика взаимодействия для FirstWindow.xaml
    /// </summary>
    public partial class FirstWindow : Window
    {
        roleTableAdapter Role = new roleTableAdapter();
        EmployeeTableAdapter Sotrydniki = new EmployeeTableAdapter();
        LoginDataTableAdapter Dannie = new LoginDataTableAdapter();

        public FirstWindow()
        {
            InitializeComponent();
            RoleDG.ItemsSource = Role.GetData();
            SotrydnikiDG.ItemsSource = Sotrydniki.GetData();
            DannieDG.ItemsSource = Dannie.GetData();

            

            SotrydnikiCbx.ItemsSource= Role.GetData();
            SotrydnikiCbx.DisplayMemberPath= "Name";
            SotrydnikiCbx.SelectedValuePath= "id";

            PrivyazkaCbx.ItemsSource= Sotrydniki.GetData();
            PrivyazkaCbx.DisplayMemberPath = "last_name";
            PrivyazkaCbx.SelectedValuePath= "id";
        }

        private void AddBt_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(IdTbx.Text, out int idDannie))
            {
                MessageBox.Show("Ошибка! Введите число в поле 'id' ");
                return;
            }

            object id = (PrivyazkaCbx.SelectedItem as DataRowView).Row[0];
            Dannie.InsertQueryDannie(Convert.ToInt32(IdTbx.Text), Convert.ToInt32(id), LoginTbx.Text, PasswordTbx.Text);
            DannieDG.ItemsSource = Dannie.GetData();
            
        }

        private void DannieDG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DannieDG.SelectedItem as DataRowView != null)         
            {
                IdTbx.Text = Convert.ToString((DannieDG.SelectedItem as DataRowView).Row[0]);
                PrivyazkaCbx.SelectedValue = Convert.ToInt32((DannieDG.SelectedItem as DataRowView).Row[1]);
                LoginTbx.Text = Convert.ToString((DannieDG.SelectedItem as DataRowView).Row[2]);
                PasswordTbx.Text = Convert.ToString((DannieDG.SelectedItem as DataRowView).Row[3]);               
            }
        }

        private void YdalitBt_Click(object sender, RoutedEventArgs e)
        {
           
            object id = (DannieDG.SelectedItem as DataRowView).Row[0];
            Dannie.DeleteQueryDannie(Convert.ToInt32(id));
            DannieDG.ItemsSource = Dannie.GetData();
        }

        private void IzmenitBt_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(IdTbx.Text, out int idDannie))
            {
                MessageBox.Show("Ошибка! Введите число в поле 'id' ");
                return;
            }
            object id = (DannieDG.SelectedItem as DataRowView).Row[0];
            Dannie.UpdateQueryDannie(Convert.ToInt32(IdTbx.Text), Convert.ToInt32(PrivyazkaCbx.Text), (LoginTbx.Text), (PasswordTbx.Text), Convert.ToInt32(id));
            DannieDG.ItemsSource = Dannie.GetData();
        }

        private void AddBtRole_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(IdTbxRole.Text, out int idRole))
            {
                MessageBox.Show("Ошибка! Введите число в поле 'id' ");
                return;
            }
            Role.InsertQueryRole(Convert.ToInt32(IdTbxRole.Text), RoleTbx.Text);
            RoleDG.ItemsSource = Role.GetData();
        }

        private void RoleDG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RoleDG.SelectedItem as DataRowView != null)
            {
                IdTbxRole.Text = Convert.ToString((RoleDG.SelectedItem as DataRowView).Row[0]);
                RoleTbx.Text = Convert.ToString((RoleDG.SelectedItem as DataRowView).Row[1]);
            }
        }

        private void IzmenitBtRole_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(IdTbxRole.Text, out int idRole))
            {
                MessageBox.Show("Ошибка! Введите число в поле 'id' ");
                return;
            }
            object id = (RoleDG.SelectedItem as DataRowView).Row[0];
            Role.UpdateQueryRole(Convert.ToInt32(IdTbxRole.Text), (RoleTbx.Text), Convert.ToInt32(id));
            RoleDG.ItemsSource = Role.GetData();
        }

        private void YdalitBtRole_Click(object sender, RoutedEventArgs e)
        {
            
            object id = (RoleDG.SelectedItem as DataRowView).Row[0];
            Role.DeleteQueryRole(Convert.ToInt32(id));
            RoleDG.ItemsSource = Role.GetData();
        }

        private void AddSotrydnikiBt_Click(object sender, RoutedEventArgs e)
        {
         

            if (!int.TryParse(IdTbxSotrydniki.Text, out int idSotrydniki))
            {
                MessageBox.Show("Ошибка! Введите число в поле 'id' ");
                return;
            }
            if (int.TryParse(  FamiliyaTbx.Text, out int Familiya))
            {
                MessageBox.Show("Ошибка! Введите Фамилию! ");
                return;
            }
            if (int.TryParse(ImyaTbx.Text, out int Imya))
            {
                MessageBox.Show("Ошибка! Введите Фамилию! ");
                return;
            }
            if (int.TryParse(OtchestvoTbx.Text, out int Otchestvo))
            {
                MessageBox.Show("Ошибка! Введите Фамилию! ");
                return;
            }

            object id = (SotrydnikiCbx.SelectedItem as DataRowView).Row[0];
            Sotrydniki.InsertQuerySotrydniki(Convert.ToInt32(IdTbxSotrydniki.Text),Convert.ToString(FamiliyaTbx.Text), ImyaTbx.Text, OtchestvoTbx.Text, Convert.ToInt32(id));
            SotrydnikiDG.ItemsSource = Sotrydniki.GetData();
        }

        private void SotrydnikiDG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SotrydnikiDG.SelectedItem as DataRowView != null)
            {
                IdTbxSotrydniki.Text = Convert.ToString((SotrydnikiDG.SelectedItem as DataRowView).Row[0]);
                FamiliyaTbx.Text = Convert.ToString((SotrydnikiDG.SelectedItem as DataRowView).Row[1]);
                ImyaTbx.Text = Convert.ToString((SotrydnikiDG.SelectedItem as DataRowView).Row[2]);
                OtchestvoTbx.Text = Convert.ToString((SotrydnikiDG.SelectedItem as DataRowView).Row[3]);
                SotrydnikiCbx.SelectedValue = Convert.ToInt32((SotrydnikiDG.SelectedItem as DataRowView).Row[4]);
               

            }
        }

        private void IzmenitSotrydnikiBt_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(IdTbxSotrydniki.Text, out int idSotrydniki))
            {
                MessageBox.Show("Ошибка! Введите число в поле 'id' ");
                return;
            }
            if (int.TryParse(FamiliyaTbx.Text, out int Familiya))
            {
                MessageBox.Show("Ошибка! Введите Фамилию! ");
                return;
            }
            if (int.TryParse(ImyaTbx.Text, out int Imya))
            {
                MessageBox.Show("Ошибка! Введите Фамилию! ");
                return;
            }
            if (int.TryParse(OtchestvoTbx.Text, out int Otchestvo))
            {
                MessageBox.Show("Ошибка! Введите Фамилию! ");
                return;
            }
            object id = (SotrydnikiCbx.SelectedItem as DataRowView).Row[0];
            object id1 = (SotrydnikiDG.SelectedItem as DataRowView).Row[0];
            Sotrydniki.UpdateQuerySotrydniki(Convert.ToInt32(IdTbxSotrydniki.Text), FamiliyaTbx.Text, ImyaTbx.Text, OtchestvoTbx.Text, Convert.ToInt32(id), Convert.ToInt32(id1));
            SotrydnikiDG.ItemsSource = Sotrydniki.GetData();
        }

        private void YdalitSotrydnikiBt_Click(object sender, RoutedEventArgs e)
        {
            
            object id = (SotrydnikiDG.SelectedItem as DataRowView).Row[0];
            Sotrydniki.DeleteQuerySotrydniki(Convert.ToInt32(id));
            SotrydnikiDG.ItemsSource = Sotrydniki.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
