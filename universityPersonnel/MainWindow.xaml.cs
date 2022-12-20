using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
using universityPersonnel.Models;
using universityPersonnel.View;

namespace universityPersonnel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        UniversityPersonnelDbContext dbContext;
        public Penaltie Penaltie { get; set; }
        public Encouragement Encouragement { get; set; }
       
        public List<EncouragementType> EncouragementTypes { get; set; }
        public User User { get; set; }
        public List<User> Users { get; set; }

        public List<PenaltieType> PenaltieTypes { get; set; }
        public List<UserType> UserTypes { get; set; }
        public List<Penaltie> Penalties { get; set; }
        public List<AccessRight> AccessRights { get; set; }
        public List<Staff> Staffs { get; set; }
        public MainWindow(UniversityPersonnelDbContext dbContext, User user)
        {
            this.dbContext = dbContext;
            // AccessRights = dbContext.AccessRight.Include(x => x.User == user).ToList();

       

            this.DataContext = this;
            InitializeComponent();
            UserTypes = dbContext.UserType.ToList();
            UserTypesColumn.ItemsSource = UserTypes;

            var AccessRights = dbContext.AccessRight
                .Where(x => x.User.Id == user.Id)
                .ToList();

            this.User = user;
            if(user.UserType.Type == "admin")
            {
                RefreshAdmin();

            } else
            {
                AdminItem.Visibility = System.Windows.Visibility.Hidden;
                AdminItemGrid.Visibility = System.Windows.Visibility.Hidden;
            }


            var staffAcess = AccessRights.Single(x=>x.NameForm == dbContext.NameForm.Single(x => x.Name == "StaffForm"));

            var subdivisionAcess = AccessRights.Single(x => x.NameForm == dbContext.NameForm.Single(x => x.Name == "SubdivisionForm"));

            var specialityAcess = AccessRights.Single(x => x.NameForm == dbContext.NameForm.Single(x => x.Name == "SpecialityForm")); 

            var jobTitleAcess = AccessRights.Single(x => x.NameForm == dbContext.NameForm.Single(x => x.Name == "JobTitleForm"));

            if (!staffAcess.Read) {
                staffItem.Visibility = Visibility.Hidden;
                staffItemGrid.Visibility = Visibility.Hidden;
            }
           
            addStaffButton.IsEnabled = staffAcess.Write;
            editStaffButton.IsEnabled = staffAcess.Edit;
            deleteStaffButton.IsEnabled = staffAcess.Delete;
           

            if (!subdivisionAcess.Read)
            {
                SubdivisionItem.Visibility = Visibility.Hidden;
                SubdivisionItemGrid.Visibility = Visibility.Hidden;
            }

            SubdivisionGrid.IsReadOnly = !subdivisionAcess.Edit;
            SubdivisionGrid.CanUserAddRows = subdivisionAcess.Write;
            deleteSubdivisionButton.IsEnabled = subdivisionAcess.Delete;
            SubdivisionGrid.CanUserDeleteRows = subdivisionAcess.Delete;


            if (!specialityAcess.Read)
            {
                SpecialityItem.Visibility = Visibility.Hidden;
                SpecialityItemGrid.Visibility = Visibility.Hidden;
            }

            SpecialityGrid.IsReadOnly = !specialityAcess.Edit;
            SpecialityGrid.CanUserAddRows = specialityAcess.Write;
            deleteSpecialityButton.IsEnabled = specialityAcess.Delete;
            SpecialityGrid.CanUserDeleteRows = specialityAcess.Delete;

            if (!jobTitleAcess.Read)
            {
                JobTitleItem.Visibility = Visibility.Hidden;
                JobTitleItemGrid.Visibility = Visibility.Hidden;
            }

            JobTitleGrid.IsReadOnly = !jobTitleAcess.Edit;
            JobTitleGrid.CanUserAddRows = jobTitleAcess.Write;
            deleteJobTitleButton.IsEnabled = jobTitleAcess.Delete;
            JobTitleGrid.CanUserDeleteRows = jobTitleAcess.Delete;

            RefreshStaff();
           
            RefreshSubdivision();
            RefreshSpeciality();
            RefreshJobTitle();

            
            SubdivisionGrid.ItemsSource = dbContext.Subdivision.Local.ToBindingList(); // устанавливаем привязку к кэшу
            SpecialityGrid.ItemsSource = dbContext.Speciality.Local.ToBindingList(); // устанавливаем привязку к кэшу
            JobTitleGrid.ItemsSource = dbContext.JobTitle.Local.ToBindingList(); // устанавливаем привязку к кэшу

            this.Closing += MainWindow_Closing;


        }
        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var loginWindow = new LoginWindow();
            loginWindow.Show();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            dbContext.SaveChanges();
        }
        private void DeleteStaffButton_Click(object sender, RoutedEventArgs e)
        {
            if (StaffGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < StaffGrid.SelectedItems.Count; i++)
                {
                    Staff staff = StaffGrid.SelectedItems[i] as Staff;
                    if (staff != null)
                    {
                        
                        dbContext.Staff.Remove(staff);

                    }
                }
                dbContext.SaveChanges();
                RefreshStaff();
            }

            
          
        }
        private void DeleteSubdivisionButton_Click(object sender, RoutedEventArgs e)
        {
            if (SubdivisionGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < SubdivisionGrid.SelectedItems.Count; i++)
                {
                    Subdivision subdivision = SubdivisionGrid.SelectedItems[i] as Subdivision;
                    if (subdivision != null)
                    {
                        dbContext.Subdivision.Remove(subdivision);
                    }
                }
            }

            dbContext.SaveChanges();
        }

        private void DeleteJobTitleButton_Click(object sender, RoutedEventArgs e)
        {
            if (JobTitleGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < JobTitleGrid.SelectedItems.Count; i++)
                {
                    JobTitle jobTitle = JobTitleGrid.SelectedItems[i] as JobTitle;
                    if (jobTitle != null)
                    {
                        dbContext.JobTitle.Remove(jobTitle);
                    }
                }
            }

            dbContext.SaveChanges();
        }

        private void DeleteSpecialityButton_Click(object sender, RoutedEventArgs e)
        {
            if (SpecialityGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < SpecialityGrid.SelectedItems.Count; i++)
                {
                    Speciality speciality = SpecialityGrid.SelectedItems[i] as Speciality;
                    if (speciality != null)
                    {
                        dbContext.Speciality.Remove(speciality);
                    }
                }
            }

            dbContext.SaveChanges();
        }

        private void RefreshStaff()
        {

            var s = searchTextBox.Text.ToLower();

            StaffGrid.ItemsSource = dbContext.Staff
                .AsSplitQuery()
                .Include(x => x.AcademicDegree)
                .Include(x => x.AcademicTitle)
                .Include(x => x.JobTitle)
                .Include(x => x.Speciality)
                .Include(x => x.Subdivision)
                .Include(x => x.PreviousVentures)
                .Include(x => x.EmploymentBooks)
                .Include(x => x.Movements)  
                .Include(x => x.Encouragements)
                .Include(x => x.Penalties)
                .Where(x=>x.Name.ToLower().Contains(s) || x.Surname.ToLower().Contains(s) || x.Middlename.ToLower().Contains(s) || x.PlaceBirth.ToLower().Contains(s) || x.Phone.ToLower().Contains(s) || x.Subdivision.Name.ToLower().Contains(s))
                .ToList();
            StaffGrid.Items.Refresh();
        }

        private void RefreshAdmin()
        {
            AdminGrid.ItemsSource = dbContext.User
            .AsSplitQuery()
            .Include(x => x.AccessRights)
            .Include(x => x.UserType)
            .ToList();
            AdminGrid.Items.Refresh();
        }

        private void RefreshSubdivision()
        {
            SubdivisionGrid.ItemsSource = dbContext.Subdivision.ToList();
            SubdivisionGrid.Items.Refresh();
        }


        private void RefreshJobTitle()
        {
            JobTitleGrid.ItemsSource = dbContext.JobTitle.ToList();
            JobTitleGrid.Items.Refresh();
        }

        private void RefreshSpeciality()
        {
            SpecialityGrid.ItemsSource = dbContext.Speciality.ToList();
            SpecialityGrid.Items.Refresh();
        }

        private void AddStaffButton_Click(object sender, RoutedEventArgs e)
        {
            AddStaffWindow addStaffWindow = new AddStaffWindow(dbContext);
            addStaffWindow.ShowDialog();
            RefreshStaff();
        }

        private void EditStaffButton_Click(object sender, RoutedEventArgs e)
        {
            int count = StaffGrid.SelectedItems.Count;
            if (count == 1)
            {
                var editStaffWindow = new EditStaffWindow((Staff)StaffGrid.SelectedItems[0], dbContext, User);
                editStaffWindow.ShowDialog();
                RefreshStaff();
            }
        }

        private void searchStaffButton_Click(object sender, RoutedEventArgs e)
        {
            RefreshStaff();
        }

        private void recoverPasswordButton_Click(object sender, RoutedEventArgs e)
        {

            var oldPassword = OldPasswordTexBox.Password;
            var newPassword = NewPasswordTexBox.Password;
            var confirmPassword = ConfirmPasswordTexBox.Password;
            if (User.Password == GetHash(oldPassword))
            {
                if(newPassword == confirmPassword)
                {
                    var PasswordHash = GetHash(newPassword);
                    User.Password = PasswordHash;
                    dbContext.SaveChanges();
                    OldPasswordTexBox.Password = string.Empty;
                    NewPasswordTexBox.Password = string.Empty;
                    ConfirmPasswordTexBox.Password = string.Empty;
                    MessageBox.Show("Пароль успешно изменён!");

                } else
                {
                    MessageBox.Show("Новые пароли не совпадают");
                }

            } else
            {
                MessageBox.Show("Старый пароль введён неправильный");
            }

        }

        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

        private void editUserButton_Click(object sender, RoutedEventArgs e)
        {
            int count = AdminGrid.SelectedItems.Count;
            if (count == 1)
            {
                var editUserWindow = new EditUserWindow(dbContext, (User)AdminGrid.SelectedItems[0]);
                editUserWindow.ShowDialog();
                RefreshAdmin();
            }
        }

    }
}