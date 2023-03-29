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
using NewPrakt5.kladbiweDataSetTableAdapters;


namespace NewPrakt5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        LoginDataTableAdapter adapter = new LoginDataTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var allLogins = adapter.GetData().Rows;
            bool found = false;
            for (int i = 0; i < allLogins.Count; i++)
                if (allLogins[i][2].ToString() == LoginTbx.Text &&
                    allLogins[i][3].ToString() == PasswordTbx.Password)

                {
                    found = true;
                    int roleid = (int)allLogins[i][1];
                    switch (roleid)
                    {  
                        case 1:
                            FirstWindow role = new FirstWindow();
                            role.Show();
                            break;
                        case 2:
                            SecondWindow second = new SecondWindow();
                            second.Show();
                            break;
                    }
                    this.Close();
                }
            if (!found)
            {
                MessageBox.Show("Неверное имя пользователя или пароль");
            }

        }

        
    }
}
