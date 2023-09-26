using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GroupProject.Models;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace GroupProject.ViewModel
{
    public partial class RemoveStudentVM : ObservableObject
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

        [RelayCommand]
        public void Delete()
        {
            if (SelectedUser != null)
            {
                string name = SelectedUser.FirstName;
                Users.Remove(SelectedUser); // Remove the selected student from the collection
                MessageBox.Show($"{name} is Deleted successfully.", "DELETED");
            }
            else
            {
                MessageBox.Show("Please select a student before deleting.", "Error");
            }
        }

        public RemoveStudentVM()
        {
            // Initialize Users property with data from the database
            using (var context = new DataBaseContext())
            {
                Users = new ObservableCollection<Student>(context.Students.ToList());
            }
        }
    }
}
