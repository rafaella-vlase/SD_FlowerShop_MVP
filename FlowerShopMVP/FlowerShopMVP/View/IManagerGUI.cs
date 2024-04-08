using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopMVP.View
{
    public interface IManagerGUI: IGUI
    {
       void SetFloristID(uint floristID);

       uint GetFloristID();

       void SetFlowerID(uint flowerID);

       uint GetFlowerID();

       void SetType(string type);

       string GetType();

       void SetColor(string color);

       string GetColor();

       void SetPrice(float price);

       float GetPrice();

       void SetStock(int stock);

       int GetStock();

       void SetAvailability(string isAvailable);

       string GetAvailability();

       void ResetSelectedCriterionFilterBy();

       string GetSelectedCriterionFilterBy();

       void ResetSelectedCriterion();

       string GetSelectedCriterion();

       int GetSelectedFlower();

       string GetSelectedFlowerID();

       void AddRowDgvFlowerTable(DataGridViewRow row);

       DataGridViewRow GetFirstSelectedRow();

       void ResetDgvFlowerTable();

       DataGridViewRowCollection GetDgvFlowerRows();

       string GetSearchedInformation();

       int GetSelectedRowsNumber();
    }
}
