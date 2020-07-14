using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Zadatak_1.Command;
using Zadatak_1.Model;
using Zadatak_1.View;

namespace Zadatak_1.ViewModel
{
    class LoginViewModel : ViewModelBase
    {
        LoginView view;
        

        #region Constructors

        public LoginViewModel(LoginView view)
        {
            this.view = view;
          
        }
        #endregion

        #region Property
                      
        private string userName;
        public string UserName
        {

            get
            {
                return userName;
            }
            set
            {
                userName = value;
                OnPropertyChanged("UserName");
            }
        }

        #endregion

        #region Commands
        private ICommand login;
        /// <summary>
        /// Command login
        /// </summary>
        public ICommand Login
        {
            get
            {
                if (login == null)
                {
                    login = new RelayCommand(LoginExecute);
                }
                return login;
            }
            set { login = value; }
        }
        /// <summary>
        /// Method for checking username and password
        /// </summary>
        /// <param name="o"></param>
        private void LoginExecute(object o)
        {
            try
            {
                string password = (o as PasswordBox).Password;
                if (userName == "Man2019" && password == "Man2019")
                {
                    MainWindow mw = new MainWindow();
                    view.Close();
                    mw.ShowDialog();
                }

                else if (userName == "Mag2019" && password == "Mag2019")
                {
                    StorekeeperView storekeeper = new StorekeeperView();
                    view.Close();
                    storekeeper.Show();
                    return;
                }

                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
        #endregion
    }
}