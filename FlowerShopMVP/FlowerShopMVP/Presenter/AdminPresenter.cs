using FlowerShopMVP.Model.Repository;
using FlowerShopMVP.View;
using FlowerShopMVP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FlowerShopMVP.Presenter
{
    public class AdminPresenter
    {
        private IAdminGUI iAdminGUI;
        private UserRepository userRepository;

        public AdminPresenter(IAdminGUI iAdminGUI)
        {
            this.iAdminGUI = iAdminGUI;
            this.userRepository = new UserRepository();
            this.LoadUserTable();
        }

        public void LoadUserTable()
        {
            try
            {
                this.resetUserControls();
                this.iAdminGUI.ResetDgvUserTable();
                List<User> list = userRepository.UserList();

                if (list != null && list.Count > 0)
                {
                    this.setRowUserList(list);
                }
                else
                {
                    this.iAdminGUI.SetMessage("Empty", "There is no user in your table!");
                }

            }
            catch (Exception exception)
            {
                this.iAdminGUI.SetMessage("Users load - exception", exception.ToString());
            }
        }

        public void AddUser()
        {
            try
            {
                User user = this.validInformation();
                if (user != null)
                {
                    bool result = this.userRepository.AddUser(user);
                    if (result)
                    {
                        this.iAdminGUI.SetMessage("Success!", "Adding was completed successfully!");
                        this.resetUserControls();
                        this.iAdminGUI.ResetDgvUserTable();
                    }
                    else
                        this.iAdminGUI.SetMessage("Failure!", "Adding was ended with failure!");
                }
            }
            catch (Exception exception)
            {
                this.iAdminGUI.SetMessage("Add - Exception", exception.ToString());
            }
        }

        public void DeleteUser()
        {
            try
            {
                if (Convert.ToBoolean(this.iAdminGUI.GetSelectedUser()))
                {
                    uint selectedID = Convert.ToUInt32(this.iAdminGUI.GetSelectedUserID());
                    bool result = this.userRepository.DeleteUser(selectedID);
                    if (result)
                    {
                        this.resetUserControls();
                        this.iAdminGUI.ResetDgvUserTable();
                        this.iAdminGUI.SetMessage("Success!", "Deletion was completed successfully!");
                    }
                    else
                        this.iAdminGUI.SetMessage("Failure!", "Deletion was ended with failure!");
                }
                else
                    this.iAdminGUI.SetMessage("Failure!", "No user has been selected to be deleted!");
            }
            catch (Exception exception)
            {
                this.iAdminGUI.SetMessage("Delete - Exception", exception.ToString());
            }
        }

        public void UpdateUser()
        {
            try
            {
                if (Convert.ToBoolean(this.iAdminGUI.GetSelectedUser()))
                {
                    //uint selectedID = Convert.ToUInt32(this.iEmployeeGUI.GetSelectedCarID());
                    User user = this.validInformation();
                    if (user != null)
                    {
                        bool result = this.userRepository.UpdateUser(user);
                        if (result)
                        {
                            this.iAdminGUI.SetMessage("Success!", "Updating was completed successfully!");
                            this.resetUserControls();
                            this.iAdminGUI.ResetDgvUserTable();
                        }
                        else
                            this.iAdminGUI.SetMessage("Failure!", "Updating was ended with failure!");
                    }
                }
                else
                    this.iAdminGUI.SetMessage("Failure!", "No user has been selected to be updated!");
            }
            catch (Exception exception)
            {
                this.iAdminGUI.SetMessage("Update - Exception", exception.ToString());
            }
        }

        public void UserTable()
        {
            try
            {
                this.iAdminGUI.ResetDgvUserTable();
                this.allUsers();
            }
            catch (Exception exception)
            {
                this.iAdminGUI.SetMessage("Users - Exception", exception.ToString());
            }
        }

        public void SetUserControls()
        {
            try
            {
                if (this.iAdminGUI.GetSelectedRowsNumber() > 0)
                {
                    DataGridViewRow drvr = this.iAdminGUI.GetFirstSelectedRow();
                    uint id = Convert.ToUInt32(drvr.Cells[0].Value);
                    this.iAdminGUI.SetUserID(id);
                    string username = drvr.Cells[1].Value.ToString();
                    this.iAdminGUI.SetUsername(username);
                    string password = drvr.Cells[2].Value.ToString();
                    this.iAdminGUI.SetPassword(password);
                    string role = drvr.Cells[3].Value.ToString();
                    this.iAdminGUI.SetRole(role);
                    uint floristID = Convert.ToUInt32(drvr.Cells[4].Value);
                    this.iAdminGUI.SetFloristID(floristID); 
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error at row selection!");
            }
        }

        private void allUsers()
        {
            try
            {
                List<User> list = this.userRepository.UserList();
                if (list != null)
                {
                    this.setRowUserList(list);
                }
                else
                {
                    this.iAdminGUI.SetMessage("Empty", "The list of users is empty!");
                }
            }
            catch (Exception exception)
            {
                this.iAdminGUI.SetMessage("User List - exception", exception.ToString());
            }
        }

        private void setRowUserList(List<User> list)
        {
            foreach (User user in list)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell { Value = user.UserID.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = user.Username });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = user.Password });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = user.Role });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = user.FloristID });
                this.iAdminGUI.AddRowDgvUserTable(row);
            }
        }

        private void resetUserControls()
        {
            this.iAdminGUI.SetUserID(1);
            this.iAdminGUI.SetUsername("");
            this.iAdminGUI.SetPassword("");
            this.iAdminGUI.SetRole("");
            this.iAdminGUI.SetFloristID(1);
        }

        private User validInformation()
        {
            uint id = this.iAdminGUI.GetUserID();
            Debug.Print("User ID: " + id);
            if (id == 0)
            {
                this.iAdminGUI.SetMessage("Incomplete information!", "User ID must be non-zero natural number!");
                return null;
            }
            string username = this.iAdminGUI.GetUsername();
            Debug.Print("Username: " + username);
            if (username == null || username.Length == 0)
            {
                this.iAdminGUI.SetMessage("Incomplete information!", "Username is empty!");
                return null;
            }
            string password = this.iAdminGUI.GetPassword();
            Debug.Print("Password: " + password);
            if (password == null || password.Length == 0)
            {
                this.iAdminGUI.SetMessage("Incomplete information!", "Password is empty!");
                return null;
            }
            string role = this.iAdminGUI.GetRole();
            Debug.Print("Role: " + role);
            if (role == null || role.Length == 0)
            {
                this.iAdminGUI.SetMessage("Incomplete information!", "Role is empty");
                return null;
            }

            uint floristID = this.iAdminGUI.GetFloristID();
            if(floristID < 0)
            {
                this.iAdminGUI.SetMessage("Incomplete information!", "Florist ID must be non-zero natural number!");
                return null;
            }
            return new User(id, username, password, role, floristID);
        }

        public void Logout()
        {
            try
            {
                LoginGUI loginGUI = new LoginGUI();
                loginGUI.Show();
                this.iAdminGUI.HideForm();
            }
            catch (Exception exception)
            {
                this.iAdminGUI.SetMessage("Logout failed", exception.ToString());
            }
        }
    }
}
