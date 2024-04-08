namespace FlowerShopMVP.Model.Repository
{
    using FlowerShopMVP.Model;
    using System;
    using System.Collections.Generic;
    using System.Data;

    public class UserRepository
    {
        private Repository repository;

        public UserRepository()
        {
            this.repository = new Repository();
        }

        public UserRepository(string database)
        {
            this.repository = new Repository(database);
        }


        public bool AddUser(User user)
        {
            string commandSQL = "insert into Users values('";
            commandSQL += user.Username + "','" + user.Password + "','" + user.Role;
            commandSQL += "', " + user.FloristID + ")";
            return this.repository.CommandSQL(commandSQL);
        }

        public bool LoginUser(string username, string password)
        {
            string commandSQL = "SELECT * FROM [Users] WHERE username = '";
            commandSQL += username + "'" + "AND password = '";
            commandSQL += password + "'";
            DataTable userTable = this.repository.GetTable(commandSQL);

            if (userTable != null || userTable.Rows.Count != 0)
            {
                return true;
            }

            return false;
        }

        public string GetRole(string username, string password)
        {
            string commandSQL = "SELECT * FROM [Users] WHERE username = '";
            commandSQL += username + "' AND password = '" + password + "'";
            DataTable userTable = this.repository.GetTable(commandSQL);

            if (userTable != null || userTable.Rows.Count != 0)
            {
                DataRow row = userTable.Rows[0];
                return row["role"].ToString();
            }

            return "";
        }

        public string GetFloristID(string username)
        {
            string commandSQL = "SELECT floristID FROM [Users] WHERE username = '" + username + "'";
            DataTable userTable = this.repository.GetTable(commandSQL);

            if(userTable != null || userTable.Rows.Count != 0)
            {
                DataRow row = userTable.Rows[0];
                return row["floristID"].ToString();
            }

            return "";
        }


        public bool DeleteUser(uint userID)
        {
            string commandSQL = "delete from [Users] where userID = " + userID;
            return this.repository.CommandSQL(commandSQL);
        }

        public bool UpdateUser(User user)
        {
            string commandSQL = "update [Users] set username = '";
            commandSQL += user.Username + "', password = '" + user.Password;
            commandSQL += "', role = '" + user.Role;
            commandSQL += "', floristID = " + user.FloristID;
            commandSQL += " where userID = " + user.UserID;
            return this.repository.CommandSQL(commandSQL);
        }

        public DataTable UserTable()
        {
            string selectSQL = "Select * from [Users] order by userID";
            DataTable userTable = this.repository.GetTable(selectSQL);
            if (userTable == null || userTable.Rows.Count == 0)
                return null;
            return userTable;
        }

        public List<User> UserList()
        {
            DataTable userTable = this.UserTable();
            if (userTable == null)
                return null;
            List<User> list = new List<User>();
            foreach (DataRow dr in userTable.Rows)
            {
                User user = this.convertToUser(dr);
                list.Add(user);
            }
            return list;
        }

        public List<User> UserList_Role(string searchedRole)
        {
            string selectSQL = "Select * from [Users] where role ='";
            selectSQL += searchedRole + "' order by username";
            DataTable userTable = this.repository.GetTable(selectSQL);
            if (userTable == null || userTable.Rows.Count == 0)
                return null;
            List<User> list = new List<User>();
            foreach (DataRow dr in userTable.Rows)
            {
                User user = this.convertToUser(dr);
                list.Add(user);
            }
            return list;
        }

        public User SearchUserByID(string id)
        {
            try
            {
                int ID = Convert.ToInt32(id);
                string searchSQL = "Select * from [Users] where userID = " + ID;
                DataTable userTable = this.repository.GetTable(searchSQL);
                if (userTable == null || userTable.Rows.Count == 0)
                    return null;
                DataRow dr = userTable.Rows[0];
                return this.convertToUser(dr);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<User> SearchUserByUsername(string username)
        {
            string selectSQL = "Select * from [Users] where username ='" + username + "'";
            DataTable userTable = this.repository.GetTable(selectSQL);
            if (userTable == null || userTable.Rows.Count == 0)
                return null;
            List<User> list = new List<User>();
            foreach (DataRow dr in userTable.Rows)
            {
                User user = this.convertToUser(dr);
                list.Add(user);
            }
            return list;
        }

        private User convertToUser(DataRow dataRow)
        {
            int id = (int)dataRow["userID"];
            int floristID = (int)dataRow["floristID"];
            return new User((uint)id, (string)dataRow["username"], (string)dataRow["password"], (string)dataRow["role"], (uint)floristID);
        }

    }
}