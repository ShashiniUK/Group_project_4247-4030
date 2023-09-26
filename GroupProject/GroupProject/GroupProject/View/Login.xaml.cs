using GroupProject.Models;
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
using System.Windows.Shapes;

namespace GroupProject.View
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click_AdminLogin(object sender, RoutedEventArgs e)
        {
            var ID = text_username.Text;
            var Password = text_password.Password;

            using (DataBaseContext Dcontext = new DataBaseContext())
            {
                bool CorrectAdminfound = Dcontext.Users.Any(user => user.ID == ID && user.Password == Password);
                if (CorrectAdminfound)
                    {
                        CorrectAdmin();
                        Close();
                    }

                else
                {
                    MessageBox.Show("Incorrect username or passeword!", "Warning!");
                }
            }
        }

        private void Button_Click_NormalUserLogin(object sender, RoutedEventArgs e)
        {
            var ID = text_username.Text;
            var Password = text_password.Password;

            using (DataBaseContext Dcontext = new DataBaseContext())
            {
                bool CorrectAdminfound = Dcontext.Teachers.Any(teacher => teacher.UserName == ID && teacher.Password == Password);
                if (CorrectAdminfound)
                {
                    CorrectNormalUser();
                    Close();
                }

                else
                {
                    MessageBox.Show("Incorrect username or password!", "Warning!");
                }
            }
        }


        public void CorrectAdmin()
        {
            AdminUserRegistration adminView = new AdminUserRegistration();
            adminView.Show();
        }
        public void CorrectNormalUser()
        {
            TeacherDashboard Dashboard = new TeacherDashboard();
            Dashboard.Show();
        }

        private void TextBlock_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            MessageBox.Show("Contact IT Admin", "Error");
        }
    }
}

    
