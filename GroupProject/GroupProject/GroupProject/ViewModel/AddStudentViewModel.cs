using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GroupProject.Models;
using GroupProject.View;

namespace GroupProject.ViewModel
{
    public class AddStudentViewModel : ObservableObject
    {
        private string _fName;
        private string _lName;
        private string _regNo;
        private string _email;
        private double _gpa;

        public string FName
        {
            get => _fName;
            set => SetProperty(ref _fName, value);
        }

        public string LName
        {
            get => _lName;
            set => SetProperty(ref _lName, value);
        }

        public string RegNo
        {
            get => _regNo;
            set => SetProperty(ref _regNo, value);
        }

        public string Email
        {
            get => _email;
            set => SetProperty(ref _email, value);
        }

        public double GPA
        {
            get => _gpa;
            set => SetProperty(ref _gpa, value);
        }

        public ICommand AddStudentCommand { get; }

        public AddStudentViewModel()
        {
            AddStudentCommand = new RelayCommand(AddStudent);
            BackCommand = new RelayCommand(Back);
        }

        private void AddStudent()
        {
            using (var context = new DataBaseContext())
            {
                if (context.Students.Any(s => s.StudentId == RegNo))
                {
                    MessageBox.Show("A student with the same registration number already exists.");
                }
                else
                {
                    context.Students.Add(new Student() { FirstName = FName, LastName = LName, Email = Email, GPA = GPA, StudentId= RegNo });
                    context.SaveChanges();
                    MessageBox.Show("Student Added Successfully!");
                }
            }
        }

        public ICommand BackCommand { get; }






        private void Back()
        {
            TeacherDashboard teacherDashboard = new TeacherDashboard();
            teacherDashboard.Show();
            Application.Current.MainWindow.Close();
        }



    }
}
