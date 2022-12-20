using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using universityPersonnel.Files;
using universityPersonnel.Models;

namespace universityPersonnel.View;

public partial class AddStaffWindow : Window
{
    public Staff Staff { get; set; } = new Staff();
    public BitmapImage BitmapPhoto { get; set; }
  
    public List<string> Genders { get; set; } = new() { "М", "Ж" };
    public List<string> Educations { get; set; } = new() { "Нет образования", "Общее", "Среднее", "Высшее"};
    public List<AcademicDegree> AcademicDegrees { get; set; }

    public List<AcademicTitle> AcademicTitles { get; set; }
    public List<JobTitle> JobTitles { get; set; }
    public List<Speciality> Specialties { get; set; }   
    public List<Subdivision> Subdivisions { get; set; }



    private readonly UniversityPersonnelDbContext dbContext;
    
    public AddStaffWindow(UniversityPersonnelDbContext dbContext)
    {
        this.dbContext = dbContext;

        AcademicDegrees = dbContext.AcademicDegree.ToList();
        AcademicTitles = dbContext.AcademicTitle.ToList();
        JobTitles = dbContext.JobTitle.ToList();
        Specialties = dbContext.Speciality.ToList();
        Subdivisions = dbContext.Subdivision.ToList();
        InitializeComponent(); 
        this.DataContext = this;

        LoadPhoto(Staff.Photo ?? ProfilePhoto.img);
    }

    private void saveButton_Click(object sender, RoutedEventArgs e)
    {
        dbContext.Add(Staff);
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