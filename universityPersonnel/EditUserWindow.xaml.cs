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
using System.Windows.Shapes;
using universityPersonnel.Models;

namespace universityPersonnel
{
    /// <summary>
    /// Логика взаимодействия для EditUserWindow.xaml
    /// </summary>
    /// 
    public partial class EditUserWindow : Window
    {
        private readonly UniversityPersonnelDbContext dbContext;
        public List<AccessRight> AccessRights { get; set; }
        public List<bool> AccessTypes { get; set; } = new() { true, false };
        public EditUserWindow(UniversityPersonnelDbContext dbContext, User selectedUser)
        {
            this.dbContext = dbContext;
            InitializeComponent();
            DataContext = this;

            AccessRights = selectedUser.AccessRights.ToList();

            //AccessRights = dbContext.AccessRight
            //    .Where(x => x.User.Id == selectedUser.Id)
            //    .ToList();

            AccessRightGrid.ItemsSource = AccessRights;
            
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            dbContext.SaveChanges();
        }

    }
}
