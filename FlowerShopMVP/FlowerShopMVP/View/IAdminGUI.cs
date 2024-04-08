using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopMVP.View
{
    public interface IAdminGUI : IGUI
    { 
        void SetUserID(uint flowerID);

        uint GetUserID();

        void SetUsername(string username);

        string GetUsername();

        void SetPassword(string password);

        string GetPassword();

        void SetRole(string role);

        string GetRole();

        void SetFloristID(uint floristID);

        uint GetFloristID();

        int GetSelectedUser();

        string GetSelectedUserID();

        void AddRowDgvUserTable(DataGridViewRow row);

        DataGridViewRow GetFirstSelectedRow();

        int GetSelectedRowsNumber();

        void ResetDgvUserTable();

        DataGridViewRowCollection GetDgvUserRows();
    }
}
