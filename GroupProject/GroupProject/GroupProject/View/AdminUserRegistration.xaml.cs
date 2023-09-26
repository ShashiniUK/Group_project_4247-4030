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
    /// Interaction logic for AdminUserRegistration.xaml
    /// </summary>
    public partial class AdminUserRegistration : Window
    {
        public AdminUserRegistration()
        {
            InitializeComponent();
        }

        /*private void Button_Click(object sender, RoutedEventArgs e)
        {
            var username = UserNameTextBox.Text;
            var password = PasswordTextBox.Text;
            using (DataBaseContext context = new DataBaseContext())
            {

                if (context.Teachers.Any(u => u.ID == username))
                {
                    MessageBox.Show("A user with the same username already exists.");
                }
                else
                {
                    context.Teachers.Add(new NormalUser() { UserName = username, Password = password });
                    context.SaveChanges();

                    //UserNameTextBox.Text = "";
                    //PasswordTextBox.Text = "";

                    //ItemList.ItemsSource = context.Users.ToList();
                    MessageBox.Show("User is Added Successfully!");

                }
            }
        } */
    }
}
