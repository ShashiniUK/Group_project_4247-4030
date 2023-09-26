using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GroupProject.Models;
using GroupProject.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace GroupProject.ViewModel
{
    class StudentDetailsVM : ObservableObject
    {
        private ObservableCollection<Student> _users;
        private Student _selectedUser;
        

        public ObservableCollection<Student> Users
        {
            get { return _users; }
            set { SetProperty(ref _users, value); }
        }

        public Student SelectedUser
        {
            get { return _selectedUser; }
            set { SetProperty(ref _selectedUser, value); }
        }

        public StudentDetailsVM()
        {
            // Initialize Users property with data from the database
            using (var context = new DataBaseContext())
            {
                Users = new ObservableCollection<Student>(context.Students.ToList());
            }

            BackCommand = new RelayCommand(Back);
        }
        public ICommand BackCommand { get; }






        public void Back()
        {
            TeacherDashboard teacherDashboard1 = new TeacherDashboard();
            teacherDashboard1.Show();
            Application.Current.MainWindow.Close();
        }

    }
}
