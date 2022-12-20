using Microsoft.EntityFrameworkCore;
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

        public List<PenaltieType> PenaltieTypes { get; set; }
        public List<Penaltie> Penalties { get; set; }
        public List<AccessRight> AccessRights { get; set; }
        public List<Staff> Staffs { get; set; }
        public MainWindow(UniversityPersonnelDbContext dbContext, User user)
        {
            this.dbContext = dbContext;
            Staffs = dbContext.Staff.ToList();
           // AccessRights = dbContext.AccessRight.Include(x => x.User == user).ToList();

            this.DataContext = this;
            InitializeComponent();
            var a = user;

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
            dbContext.Dispose();
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
                        Staffs.Remove(staff);
                        dbContext.Staff.Remove(staff);
                        StaffGrid.Items.Refresh();
                    }
                }
            }

            dbContext.SaveChanges();
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
                .ToList();
            StaffGrid.Items.Refresh();
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
                var editStaffWindow = new EditStaffWindow((Staff)StaffGrid.SelectedItems[0], dbContext);
                editStaffWindow.ShowDialog();
                RefreshStaff();
            }
        }
    }
}