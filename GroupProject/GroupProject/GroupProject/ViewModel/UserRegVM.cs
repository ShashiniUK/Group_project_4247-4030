using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GroupProject.Models;
using GroupProject.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.ViewModel
{
    public partial class UserRegVM : ObservableObject

    {
        [ObservableProperty]
        public ObservableCollection<NormalUser> Teachers;

        public UserRegVM(ObservableCollection<NormalUser> teachers)
        {
            Teachers = teachers;
        }

        /* [ObservableProperty]
         public string regNo;


         [ObservableProperty]
         public string name;

         [ObservableProperty]
         public string email;
        */

        [ObservableProperty]
        public string password;

        [ObservableProperty]
        public string username;



        //To change the tile





        public UserRegVM(NormalUser u)
        {
            

            Teachers.Add(new NormalUser() { ID = username, Password = password });
            SaveChanges();


        }
        public UserRegVM()
        {

        }










        public NormalUser Teacher { get; private set; }
        public Action CloseAction { get; internal set; }

        [RelayCommand]
        public void Save()
        {




            if (Teacher == null)
            {

                Teacher = new NormalUser()
                {
                    ID=regNo,
                    Name = name,
                    UserName = username,
                    Password = password,
                    Email = email,


                };


            }
            else
            {
                Teacher.ID= regNo;
                Teacher.Name = name;
                Teacher.Email = email;
                Teacher.Password = password;
                Teacher.UserName = username;




            }

            if (Teacher.Name != null)
            {

                CloseAction();
            }

            Login login = new Login(); 
            login.Show();
            


        }
    }
}
