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
       


        private readonly UniversityPersonnelDbContext dbContext;

        public EditStaffWindow(Staff selectedStaff, UniversityPersonnelDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.Staff = selectedStaff;
            AcademicDegrees = dbContext.AcademicDegree.ToList();
            AcademicTitles = dbContext.AcademicTitle.ToList();
            JobTitles = dbContext.JobTitle.ToList();
            Specialties = dbContext.Speciality.ToList();
            Subdivisions = dbContext.Subdivision.ToList();
        
            this.DataContext = this;
            InitializeComponent();
           
            LoadPhoto(Staff.Photo ?? ProfilePhoto.img);
            //Не могу из SelectedItems вставить поле в форму
            //nameTextBox.Text = a.Name;

        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
           
            try
            {
                dbContext.SaveChanges();

                Close();
            }
            catch (DbUpdateException exception)
            {
                MessageBox.Show(exception.Message);
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
                //textBox1.Text = filename;
            }


        }

        private void LoadPhoto(string base64)
        {
            byte[] binaryData = Convert.FromBase64String(base64);
            BitmapPhoto = new BitmapImage();
            BitmapPhoto.BeginInit();
            //BitmapPhoto.CacheOption = BitmapCacheOption.OnLoad;
            //BitmapPhoto.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            BitmapPhoto.StreamSource = new MemoryStream(binaryData);

            BitmapPhoto.EndInit();
            PhotoImage.Source = BitmapPhoto;
        }
    }
}
