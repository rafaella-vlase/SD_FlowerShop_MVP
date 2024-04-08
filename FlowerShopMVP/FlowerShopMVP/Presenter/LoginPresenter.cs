using FlowerShopMVP.Model.Repository;
using FlowerShopMVP.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopMVP.Presenter
{
    public class LoginPresenter
    {
        private ILoginGUI iloginGUI;
        private UserRepository userRepository;
        private uint floristID;

        public LoginPresenter(ILoginGUI iloginGUI)
        {
            this.iloginGUI = iloginGUI;
            this.userRepository = new UserRepository();
        }


        // Event from View===================================================================
        public void Login()
        {
            try
            {
                string username = this.iloginGUI.GetUsername();
                string password = this.iloginGUI.GetPassword();
                string fid = this.userRepository.GetFloristID(username);

                floristID = Convert.ToUInt32(fid);

                if (username.Length != 0 && password.Length != 0)
                {
                    bool successfulLogin = userRepository.LoginUser(username, password);
                    if (successfulLogin)
                    {
                        string role = userRepository.GetRole(username, password);
                        if (role == "Employee")
                        {
                            showEmployeeGUI();
                        }
                        else if (role == "Manager")
                        {
                            showManagerGUI();
                        }
                        else if (role == "Administrator")
                        {
                            showAdministratorGUI();
                        }
                    }
                    else this.iloginGUI.SetMessage("Error", "Login failed");
                }
                else
                {
                    this.iloginGUI.SetMessage("Error", "Invalid username or password");
                }
            }
            catch
            {
                this.iloginGUI.SetMessage("Error", "Login failed");
            }
        }
        // Presenter Specific================================================================

        private void showEmployeeGUI()
        {
            EmployeeGUI employeeGUI = new EmployeeGUI(floristID);
            employeeGUI.Show();
            this.iloginGUI.HideForm();
        }

        private void showManagerGUI()
        {
            ManagerGUI managerGUI = new ManagerGUI( );
            managerGUI.Show();
            this.iloginGUI.HideForm();
        }

        private void showAdministratorGUI()
        {
            AdminGUI administratorGUI = new AdminGUI();
            administratorGUI.Show();
            this.iloginGUI.HideForm();
        }

    }
}
