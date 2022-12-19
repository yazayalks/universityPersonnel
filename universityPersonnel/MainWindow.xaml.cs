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
        UniversityPersonnelDbContext db;

        public Penaltie Penaltie { get; set; }
        public Encouragement Encouragement { get; set; }
        public List<PenaltieType> PenaltieTypes { get; set; }
        public List<EncouragementType> EncouragementTypes { get; set; }
        public List<Penaltie> Penalties { get; set; }
        public MainWindow()
        {
            db = new UniversityPersonnelDbContext();
            PenaltieTypes = db.PenaltieType.ToList();
            EncouragementTypes = db.EncouragementType.ToList();
            Penalties = db.Penaltie.Include(x => x.PenaltieType).ToList();

            this.DataContext = this;
            InitializeComponent();
            PenaltieTypesColumn.ItemsSource = PenaltieTypes;

            RefreshStaff();
            RefreshSubdivision();
            RefreshSpeciality();
            //RefreshPenaltie();
            RefreshJobTitle();
            RefreshMovement();
            RefreshEmploymentBook();
            RefreshEncouragement();
         

            SubdivisionGrid.ItemsSource = db.Subdivision.Local.ToBindingList(); // устанавливаем привязку к кэшу
            SpecialityGrid.ItemsSource = db.Speciality.Local.ToBindingList(); // устанавливаем привязку к кэшу
            PreviousVentureGrid.ItemsSource = db.PreviousVenture.Local.ToBindingList(); // устанавливаем привязку к кэшу
            //PenaltieGrid.ItemsSource = db.Penaltie.Local.ToBindingList(); // устанавливаем привязку к кэшу
            JobTitleGrid.ItemsSource = db.JobTitle.Local.ToBindingList(); // устанавливаем привязку к кэшу
            MovementGrid.ItemsSource = db.Movement.Local.ToBindingList(); // устанавливаем привязку к кэшу
            EmploymentBookGrid.ItemsSource = db.EmploymentBook.Local.ToBindingList(); // устанавливаем привязку к кэшу
            EncouragementGrid.ItemsSource = db.Encouragement.Local.ToBindingList(); // устанавливаем привязку к кэшу

            this.Closing += MainWindow_Closing;


        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Dispose();
        }

   
        private void SaveSubdivisionButton_Click(object sender, RoutedEventArgs e)
        {

            db.SaveChanges();
        }
        private void SaveSpecialityButton_Click(object sender, RoutedEventArgs e)
        {

            db.SaveChanges();
        }
        private void SavePreviousVentureButton_Click(object sender, RoutedEventArgs e)
        {

            db.SaveChanges();
        }
        private void SavePenaltieButton_Click(object sender, RoutedEventArgs e)
        {

            db.SaveChanges();
        }
        private void SaveJobTitleButton_Click(object sender, RoutedEventArgs e)
        {

            db.SaveChanges();
        }
        private void SaveMovementButton_Click(object sender, RoutedEventArgs e)
        {

            db.SaveChanges();
        }
        private void SaveEmploymentBookButton_Click(object sender, RoutedEventArgs e)
        {

            db.SaveChanges();
        }
        private void SaveEncouragementButton_Click(object sender, RoutedEventArgs e)
        {

            db.SaveChanges();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (staffGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < staffGrid.SelectedItems.Count; i++)
                {
                    Staff staff = staffGrid.SelectedItems[i] as Staff;
                    if (staff != null)
                    {
                        db.Staff.Remove(staff);
                    }
                }
            }

            db.SaveChanges();
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
                        db.Subdivision.Remove(subdivision);
                    }
                }
            }

            db.SaveChanges();
        } 
        private void DeleteEncouragementButton_Click(object sender, RoutedEventArgs e)
        {
            if (EncouragementGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < EncouragementGrid.SelectedItems.Count; i++)
                {
                    Encouragement encouragement = EncouragementGrid.SelectedItems[i] as Encouragement;
                    if (encouragement != null)
                    {
                        db.Encouragement.Remove(encouragement);
                    }
                }
            }

            db.SaveChanges();
        }

        private void DeletePenaltieButton_Click(object sender, RoutedEventArgs e)
        {
            if (PenaltieGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < PenaltieGrid.SelectedItems.Count; i++)
                {
                    Penaltie penaltie = PenaltieGrid.SelectedItems[i] as Penaltie;
                    if (penaltie != null)
                    {
                        db.Penaltie.Remove(penaltie);
                    }
                }
            }

            db.SaveChanges();
        }
        private void DeleteEmploymentBookButton_Click(object sender, RoutedEventArgs e)
        {
            if (PenaltieGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < PenaltieGrid.SelectedItems.Count; i++)
                {
                    Penaltie penaltie = PenaltieGrid.SelectedItems[i] as Penaltie;
                    if (penaltie != null)
                    {
                        db.Penaltie.Remove(penaltie);
                    }
                }
            }

            db.SaveChanges();
        }
        private void DeleteMovementButton_Click(object sender, RoutedEventArgs e)
        {
            if (MovementGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < MovementGrid.SelectedItems.Count; i++)
                {
                    Movement movement = MovementGrid.SelectedItems[i] as Movement;
                    if (movement != null)
                    {
                        db.Movement.Remove(movement);
                    }
                }
            }

            db.SaveChanges();
        }

        private void DeletePreviousVentureButton_Click(object sender, RoutedEventArgs e)
        {
            if (PreviousVentureGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < PreviousVentureGrid.SelectedItems.Count; i++)
                {
                    PreviousVenture previousVenture = PreviousVentureGrid.SelectedItems[i] as PreviousVenture;
                    if (previousVenture != null)
                    {
                        db.PreviousVenture.Remove(previousVenture);
                    }
                }
            }

            db.SaveChanges();
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
                        db.JobTitle.Remove(jobTitle);
                    }
                }
            }

            db.SaveChanges();
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
                        db.Speciality.Remove(speciality);
                    }
                }
            }

            db.SaveChanges();
        }



        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void StaffGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void RefreshStaff()
        {
            staffGrid.ItemsSource = db.Staff.Include(x => x.AcademicDegree).Include(x => x.AcademicTitle).Include(x => x.Encouragement).Include(x => x.JobTitle).Include(x => x.Speciality).Include(x => x.Subdivision).Include(x => x.Movement).Include(x => x.Penaltie).Include(x => x.PreviousVenture).Include(x => x.EmploymentBook).ToList();
            staffGrid.Items.Refresh();
        }

        private void RefreshPenaltie()
        {
            PenaltieGrid.ItemsSource = db.Penaltie.Include(x => x.PenaltieType).ToList();
            PenaltieGrid.Items.Refresh();
        }

        private void RefreshSubdivision()
        {
            SubdivisionGrid.ItemsSource = db.Subdivision.ToList();
            SubdivisionGrid.Items.Refresh();
        }

        private void RefreshEmploymentBook()
        {
            EmploymentBookGrid.ItemsSource = db.EmploymentBook.ToList();
            EmploymentBookGrid.Items.Refresh();
        }
        private void RefreshJobTitle()
        {
            JobTitleGrid.ItemsSource = db.JobTitle.ToList();
            JobTitleGrid.Items.Refresh();
        }  
        private void RefreshEncouragement()
        {
            EncouragementGrid.ItemsSource = db.Encouragement.Include(x => x.EncouragementType).ToList();
            EncouragementGrid.Items.Refresh();
        }
        private void RefreshSpeciality()
        {
            SpecialityGrid.ItemsSource = db.Speciality.ToList();
            SpecialityGrid.Items.Refresh();
        }  
      private void RefreshMovement()
        {
            MovementGrid.ItemsSource = db.Movement.ToList();
            MovementGrid.Items.Refresh();
        }  
      
        private void addStaffButton_Click(object sender, RoutedEventArgs e)
        {
            AddStaffWindow addStaffWindow = new AddStaffWindow(db);
            addStaffWindow.ShowDialog();
            RefreshStaff();
        }
   


        private void editStaffButton_Click(object sender, RoutedEventArgs e)
        {
            int count = staffGrid.SelectedItems.Count;
            if (count == 1)
            {
                var editStaffWindow = new EditStaffWindow((Staff)staffGrid.SelectedItems[0], db);
                editStaffWindow.ShowDialog();
                RefreshStaff();
            }
        }

  

    }
}