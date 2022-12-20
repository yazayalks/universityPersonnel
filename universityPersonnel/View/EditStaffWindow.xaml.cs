using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using universityPersonnel.Files;
using universityPersonnel.Models;

namespace universityPersonnel
{
    /// <summary>
    /// Логика взаимодействия для EditStaffWindow.xaml
    /// </summary>
    public partial class EditStaffWindow : Window
    {
        public Staff Staff { get; set; }
        public BitmapImage BitmapPhoto { get; set; }

        public List<string> Genders { get; set; } = new() { "М", "Ж" };
        public List<string> Educations { get; set; } = new() { "Среднее", "Высшее" };
        public List<AcademicDegree> AcademicDegrees { get; set; }
        public List<AcademicTitle> AcademicTitles { get; set; }
        public List<JobTitle> JobTitles { get; set; }
        public List<Speciality> Specialties { get; set; }
        public List<Subdivision> Subdivisions { get; set; }

        public List<PenaltieType> PenaltieTypes { get; set; }
        public List<Penaltie> Penalties { get; set; }
        public List<Movement> Movements { get; set; }
        public List<Encouragement> Encouragements { get; set; }
        public List<EncouragementType> EncouragementTypes { get; set; } 
        public List<EmploymentBook> EmploymentBooks { get; set; }
        public List<PreviousVenture> PreviousVentures { get; set; }



        private readonly UniversityPersonnelDbContext dbContext;

        private void DeleteMovementButton_Click(object sender, RoutedEventArgs e)
        {
            if (MovementGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < MovementGrid.SelectedItems.Count; i++)
                {
                    Movement movement = MovementGrid.SelectedItems[i] as Movement;
                    if (movement != null)
                    {
                        Movements.Remove(movement);
                        dbContext.Movement.Remove(movement);
                        MovementGrid.Items.Refresh();
                    }
                }
            }
        }

        public EditStaffWindow(Staff selectedStaff, UniversityPersonnelDbContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.Staff = selectedStaff;
            AcademicDegrees = dbContext.AcademicDegree.ToList();
            AcademicTitles = dbContext.AcademicTitle.ToList();
            JobTitles = dbContext.JobTitle.ToList();
            Specialties = dbContext.Speciality.ToList();
            Subdivisions = dbContext.Subdivision.ToList();

            PenaltieTypes = dbContext.PenaltieType.ToList();
            EncouragementTypes = dbContext.EncouragementType.ToList();

            if (selectedStaff.Penalties == null)
            {
                selectedStaff.Penalties = new List<Penaltie>();
            } 

            Penalties = selectedStaff.Penalties.ToList();

            if (selectedStaff.Movements == null)
            {
                selectedStaff.Movements = new List<Movement>();
            }

            Movements = selectedStaff.Movements.ToList();

            if (selectedStaff.Encouragements == null)
            {
                selectedStaff.Encouragements = new List<Encouragement>();
            }

            Encouragements = selectedStaff.Encouragements.ToList();

            if (selectedStaff.EmploymentBooks == null)
            {
                selectedStaff.EmploymentBooks = new List<EmploymentBook>();
            }

            EmploymentBooks = selectedStaff.EmploymentBooks.ToList();

            if (selectedStaff.PreviousVentures == null)
            {
                selectedStaff.PreviousVentures = new List<PreviousVenture>();
            }

            PreviousVentures = selectedStaff.PreviousVentures.ToList();

            this.DataContext = this;
         
            PenaltieTypesColumn.ItemsSource = PenaltieTypes;
            EncouragementTypesColumn.ItemsSource = EncouragementTypes;


            LoadPhoto(Staff.Photo ?? ProfilePhoto.img);
        }
       

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
           
            try
            {
                this.Staff.Penalties = (List<Penaltie>)PenaltieGrid.ItemsSource;
                this.Staff.Movements = (List<Movement>)MovementGrid.ItemsSource;
                this.Staff.Encouragements = (List<Encouragement>)EncouragementGrid.ItemsSource;
                this.Staff.EmploymentBooks = (List<EmploymentBook>)EmploymentBookGrid.ItemsSource;
                this.Staff.PreviousVentures = (List<PreviousVenture>)PreviousVentureGrid.ItemsSource;
                dbContext.SaveChanges();

                Close();
            }
            catch (DbUpdateException exception)
            {
                MessageBox.Show(exception.Message);
            }
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
                        Penalties.Remove(penaltie);
                        dbContext.Penaltie.Remove(penaltie);
                        PenaltieGrid.Items.Refresh();
                    }
                }
            }   
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
                        PreviousVentures.Remove(previousVenture);
                        dbContext.PreviousVenture.Remove(previousVenture);
                        PreviousVentureGrid.Items.Refresh();
                    }
                }
            }
        }

        private void DeleteEmploymentBookButton_Click(object sender, RoutedEventArgs e)
        {
            if (PenaltieGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < EmploymentBookGrid.SelectedItems.Count; i++)
                {
                    EmploymentBook employmentBook = EmploymentBookGrid.SelectedItems[i] as EmploymentBook;
                    if (employmentBook != null)
                    {
                        EmploymentBooks.Remove(employmentBook);
                        dbContext.EmploymentBook.Remove(employmentBook);
                        EmploymentBookGrid.Items.Refresh();
                    }
                }
            }
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
                        Encouragements.Remove(encouragement);
                        dbContext.Encouragement.Remove(encouragement);
                        EncouragementGrid.Items.Refresh();
                    }
                }
            }
        }



        private void photoButton_Click(object sender, RoutedEventArgs e)
        {

            // Create OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();



            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".png";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";


            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filePath = dlg.FileName;
                byte[] imageArray = System.IO.File.ReadAllBytes(filePath);
                string base64ImageRepresentation = Convert.ToBase64String(imageArray);
                Staff.Photo = base64ImageRepresentation;
                LoadPhoto(Staff.Photo ?? ProfilePhoto.img);
            }


        }

        private void LoadPhoto(string base64)
        {
            byte[] binaryData = Convert.FromBase64String(base64);
            BitmapPhoto = new BitmapImage();
            BitmapPhoto.BeginInit();
            BitmapPhoto.StreamSource = new MemoryStream(binaryData);

            BitmapPhoto.EndInit();
            PhotoImage.Source = BitmapPhoto;
        }
    }
}
