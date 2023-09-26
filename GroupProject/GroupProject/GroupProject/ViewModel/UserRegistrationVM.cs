using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GroupProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using GroupProject.View;

namespace GroupProject.ViewModel
{
    
        public class UserRegistrationVM : ObservableObject
        {
            private string _username;
            private string _password;
            private string _teacherRegNum;
            private string _email;
            private string _name;

            public string Username
            {
                get => _username;
                set => SetProperty(ref _username, value);
            }

            public string Password
            {
                get => _password;
                set => SetProperty(ref _password, value);
            }

            public string RegNumber
            {
                get => _teacherRegNum;
                set => SetProperty(ref _teacherRegNum, value);
            }

            public string Email
            {
                get => _email;
                set => SetProperty(ref _email, value);
            }

            public string Name
            {
                get => _name;
                set => SetProperty(ref _name, value);
            }


            public ICommand RegisterUserCommand { get; }

            public UserRegistrationVM()
            {
                RegisterUserCommand = new RelayCommand(RegisterUser);
            BackCommand = new RelayCommand(Back);
        }

            private void RegisterUser()
            {
                using (var context = new DataBaseContext())
                {
                    if (context.Teachers.Any(u => u.UserName == Username))
                    {
                        MessageBox.Show("A user with the same username already exists.");
                    }
                    else
                    {
                        context.Teachers.Add(new NormalUser() { UserName = Username, Password = Password, Email = Email, ID = RegNumber, Name = Name });
                        context.SaveChanges();

                        MessageBox.Show("User is Added Successfully!");
                    }
                }
            }

        public ICommand BackCommand { get; }






        private void Back()
        {
            Login teacherDashboard = new Login();
            teacherDashboard.Show();
            Application.Current.MainWindow.Close();
        }
    }
    }

