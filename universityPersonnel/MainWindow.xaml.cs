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

namespace universityPersonnel
{


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {

        UniversityPersonnelDbContext db;
        public MainWindow()
        {
            InitializeComponent();
            db = new UniversityPersonnelDbContext();
            //db.Staff.Include(x=>x.AcademicDegree).Load();


            //db.AcademicDegree.Load(); // загружаем данные.Load(); // загружаем данные


            var a = db.Staff.Include(x => x.AcademicDegree).ToList();

            staffGrid.ItemsSource = db.Staff.Include(x => x.AcademicDegree).ToList();


            // staffGrid.ItemsSource = db.Staff.Include(x => x.AcademicDegree).Local.ToBindingList(); // устанавливаем привязку к кэшу
            //staffGrid.ItemsSource = db.AcademicDegree.Local.ToBindingList(); // устанавливаем привязку к кэшу
            this.Closing += MainWindow_Closing;
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Dispose();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
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

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            int count = staffGrid.SelectedItems.Count;
            if (count == 1) {
                //не могу передать значение SelectedItems
                EditStaffWindow editStaffWindow = new EditStaffWindow(staffGrid.SelectedItems);
            editStaffWindow.Show();
            }
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void StaffGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
