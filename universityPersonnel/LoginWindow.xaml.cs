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
using System.Windows.Shapes;
using universityPersonnel.Models;

namespace universityPersonnel
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    /// 

    public partial class LoginWindow : Window
    {
        private readonly UniversityPersonnelDbContext dbContext;
        public List<UserType> UserTypes { get; set; }

        public User user { get; set; }

        public List<AccessRight> AccessRights { get; set; } = new List<AccessRight>();
        public AccessRight AccessRight { get; set; }

        public List<NameForm> NameForms { get; set; }
        public NameForm NameForm { get; set; }

        public List<User> users { get; set; }
        public List<Staff> Staffs { get; set; }

        public LoginWindow()
        {
           


            dbContext = new UniversityPersonnelDbContext();
  
            Staffs = dbContext.Staff.ToList();
           
            UserTypes = dbContext.UserType.ToList();
            NameForms = dbContext.NameForm.ToList();

            InitializeComponent();
            this.DataContext = this;

        }

        private AccessRight AddAccessRight(bool v1, bool v2, bool v3, bool v4, NameForm nameForm)
        {
            AccessRight = new AccessRight();
            AccessRight.Read = v1;
            AccessRight.Write = v2;
            AccessRight.Edit = v3;
            AccessRight.Delete = v4;

            AccessRight.NameForm = nameForm;
            return AccessRight;
        }


        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            var Email = LoginEmailText.Text;
            var PasswordHash = GetHash(LoginPasswordText.Password);
            User? user = dbContext.User
                .Include(x=>x.AccessRights)
                .Include(x => x.UserType)
                .FirstOrDefault(u => u.Email == Email && u.Password == PasswordHash);
            if (user != null)
            {
                var mainWindow = new MainWindow(dbContext, user);
                mainWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }

        private void registerButton_Click(object sender, RoutedEventArgs e)
        {

            var Email = RegisterEmailText.Text;

            if (dbContext.User.Count(x => x.Email == Email) == 0)
            {
                if(RegisterPasswordConfirmText.Password == RegisterPasswordText.Password) { 
                var PasswordHash = GetHash(RegisterPasswordText.Password);
                User user = new User();
                user.Email = Email;
                user.Password = PasswordHash;
                user.UserType = UserTypes.Single(x => x.Type == "user");

                    for (int i = 0; i < 9; i++) {
                        AccessRights.Add(AddAccessRight(false, false, false, false, NameForms[i]));
                    }

                    //user.AccessRights.AddRange(NameForms.Select(x => AddAccessRight(true, false, false, false, x)));
                    
         

                    user.AccessRights = AccessRights;
                    dbContext.Add(user);
                    try
                {
                    dbContext.SaveChanges();

                }
                catch (DbUpdateException exception)
                {
                    MessageBox.Show(exception.Message);
                }

                var mainWindow = new MainWindow(dbContext, user);
                mainWindow.Show();
                Close();
                } else
                {
                    MessageBox.Show("Пароли не совпадают");
                }
            } else
            {
                MessageBox.Show("Такой эмаил уже есть");
            }
            
        }

        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }
    }
}
