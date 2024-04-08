using FlowerShopMVP.Model;
using FlowerShopMVP.Model.Repository;
using FlowerShopMVP.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopMVP.Presenter
{
    public class ManagerPresenter
    {
        private IManagerGUI iManagerGUI;
        private FlowerRepository flowerRepository;

        public ManagerPresenter(IManagerGUI iManagerGUI)
        {
            this.iManagerGUI = iManagerGUI;
            this.flowerRepository = new FlowerRepository();
            this.LoadFlowerTable();
        }

        public void LoadFlowerTable()
        {
            try
            {
                this.iManagerGUI.ResetDgvFlowerTable();
                List<Flower> list = flowerRepository.FlowerList();

                if (list != null && list.Count > 0)
                {
                    this.setRowFlowerList(list);
                }
                else
                {
                    this.iManagerGUI.SetMessage("Empty", "There is no flower in your table!");
                }

            }
            catch (Exception exception)
            {
                this.iManagerGUI.SetMessage("Flowers load - exception", exception.ToString());
            }
        }

        private void setRowFlowerList(List<Flower> list)
        {
            foreach (Flower flower in list)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell { Value = flower.FloristID.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = flower.FlowerID.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = flower.Type });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = flower.Color });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = flower.Price.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = flower.Stock.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = flower.IsAvailable });

                this.iManagerGUI.AddRowDgvFlowerTable(row);
            }
        }

        public void AddFlower()
        {
            try
            {
                Flower flower = this.validInformation();
                if (flower != null)
                {
                    bool result = this.flowerRepository.AddFlower(flower);
                    if (result)
                    {
                        this.iManagerGUI.SetMessage("Success!", "Adding was completed successfully!");
                        this.resetFlowerControls();
                        this.iManagerGUI.ResetDgvFlowerTable();
                    }
                    else
                        this.iManagerGUI.SetMessage("Failure!", "Adding was ended with failure!");
                }
            }
            catch (Exception exception)
            {
                this.iManagerGUI.SetMessage("Add - Exception", exception.ToString());
            }
        }

        public void DeleteFlower()
        {
            try
            {
                if (Convert.ToBoolean(this.iManagerGUI.GetSelectedFlower()))
                {
                    uint selectedID = Convert.ToUInt32(this.iManagerGUI.GetSelectedFlowerID());
                    bool result = this.flowerRepository.DeleteFlower(selectedID);
                    if (result)
                    {
                        this.resetFlowerControls();
                        this.iManagerGUI.ResetDgvFlowerTable();
                        this.iManagerGUI.SetMessage("Success!", "Deletion was completed successfully!");
                    }
                    else
                        this.iManagerGUI.SetMessage("Failure!", "Deletion was ended with failure!");
                }
                else
                    this.iManagerGUI.SetMessage("Failure!", "No flower has been selected to be deleted!");
            }
            catch (Exception exception)
            {
                this.iManagerGUI.SetMessage("Delete - Exception", exception.ToString());
            }
        }

        public void UpdateFlower()
        {
            try
            {
                if (Convert.ToBoolean(this.iManagerGUI.GetSelectedFlower()))
                {
                    //uint selectedID = Convert.ToUInt32(this.iEmployeeGUI.GetSelectedCarID());
                    Flower flower = this.validInformation();
                    if (flower != null)
                    {
                        bool result = this.flowerRepository.UpdateFlower(flower);
                        if (result)
                        {
                            this.iManagerGUI.SetMessage("Success!", "Updating was completed successfully!");
                            this.resetFlowerControls();
                            this.iManagerGUI.ResetDgvFlowerTable();
                        }
                        else
                            this.iManagerGUI.SetMessage("Failure!", "Updating was ended with failure!");
                    }
                }
                else
                    this.iManagerGUI.SetMessage("Failure!", "No flower has been selected to be updated!");
            }
            catch (Exception exception)
            {
                this.iManagerGUI.SetMessage("Update - Exception", exception.ToString());
            }
        }

        public void FlowerTable()
        {
            try
            {
                this.iManagerGUI.ResetDgvFlowerTable();
                string selectedOption = this.iManagerGUI.GetSelectedCriterion();
                if (selectedOption != null && selectedOption.Length > 0)
                {
                    if (selectedOption.ToUpper() == "ALL")
                    {
                        this.allFlowers();
                    }
                    else if (selectedOption.ToUpper() == "FILTER BY COLOR AND PRICE")
                    
                        this.FlowerFilterByColorPrice();
                    }
            }
            catch (Exception exception)
            {
                this.iManagerGUI.SetMessage("Flowers - Exception", exception.ToString());
            }
        }


        public void FlowerTableFilterBy()
        {
            try
            {
                this.iManagerGUI.ResetDgvFlowerTable();
                string selectedOption = this.iManagerGUI.GetSelectedCriterionFilterBy();
                if (selectedOption != null && selectedOption.Length > 0)
                {
                    if (selectedOption.ToUpper() == "AVAILABILITY")
                    {
                        string available = this.iManagerGUI.GetAvailability();
                        this.FlowerFilterBy(selectedOption, available);
                    }
                    else if (selectedOption.ToUpper() == "PRICE")
                    {
                        string price = this.iManagerGUI.GetPrice().ToString();
                        this.FlowerFilterBy(selectedOption, price);
                    }
                    else if (selectedOption.ToUpper() == "COLOR")
                    {
                        string color = this.iManagerGUI.GetColor();
                        this.FlowerFilterBy(selectedOption, color);
                    }
                    else if (selectedOption.ToUpper() == "STOCK")
                    {
                        string stock = this.iManagerGUI.GetStock().ToString();
                        this.FlowerFilterBy(selectedOption, stock);
                    }

                }
            }
            catch (Exception exception)
            {
                this.iManagerGUI.SetMessage("Flowers - Exception", exception.ToString());
            }
        }

        public void FlowerFilterBy(string criterion, string value)
        {
            try
            {
                this.iManagerGUI.ResetDgvFlowerTable();


                if (criterion.Length > 0)
                {
                    if (criterion.ToUpper() == "AVAILABILITY")
                    {
                        List<Flower> list = this.flowerRepository.FlowerList_Availability(value);
                        if (list != null)
                        {
                            this.setRowFlowerList(list);
                        }
                        else this.iManagerGUI.SetMessage("Empty", "The flowers from desired availability is empty!");
                    }
                    else if (criterion.ToUpper() == "PRICE")
                    {
                        List<Flower> list = this.flowerRepository.FlowerList_Price(value);
                        if (list != null)
                        {
                            this.setRowFlowerList(list);
                        }
                        else this.iManagerGUI.SetMessage("Empty", "The flowers from desired price is empty!");
                    }
                    else if (criterion.ToUpper() == "COLOR")
                    {
                        List<Flower> list = this.flowerRepository.FlowerList_Color(value);
                        if (list != null)
                        {
                            this.setRowFlowerList(list);
                        }
                        else this.iManagerGUI.SetMessage("Empty", "The flowers from desired color is empty!");
                    }
                    else if (criterion.ToUpper() == "STOCK")
                    {
                        List<Flower> list = this.flowerRepository.FlowerList_Stock(value);
                        if (list != null)
                        {
                            this.setRowFlowerList(list);
                        }
                        else this.iManagerGUI.SetMessage("Empty", "The flowers from desired stock is empty!");
                    }
                }
                else this.iManagerGUI.SetMessage("Empty", "The flowers from desired filter is empty!");
            }
            catch (Exception exception)
            {
                this.iManagerGUI.SetMessage("Flower List - filter by - exception", exception.ToString());
            }
        }

        public void FlowerFilterByColorPrice()
        {
            try
            {
                this.iManagerGUI.ResetDgvFlowerTable();

                List<Flower> list = this.flowerRepository.FlowerList_ColorPrice();
                if (list != null)
                {
                    this.setRowFlowerList(list);
                }  
                else this.iManagerGUI.SetMessage("Empty", "The flowers from desired color and price is empty!");


            }
            catch (Exception exception)
            {
                this.iManagerGUI.SetMessage("Flower List - filter by - exception", exception.ToString());
            }
        }

        public void SearchFlowerByName()
        {
            try
            {
                this.iManagerGUI.ResetDgvFlowerTable();
                this.iManagerGUI.ResetSelectedCriterion();
                string searchedInfo = this.iManagerGUI.GetSearchedInformation();
                if (searchedInfo != null && searchedInfo.Length > 0) Debug.WriteLine(searchedInfo);
                if (searchedInfo != null && searchedInfo.Length > 0)
                {
                    List<Flower> list = new List<Flower>();
                    //Flower flower = this.flowerRepository.SearchFlowerByName(searchedInfo);
                    list = this.flowerRepository.SearchFlowerByType(searchedInfo);
                        if (list != null && list.Count > 0)
                        {
                            this.setRowFlowerList(list);
                        }
                        else
                        {
                            this.iManagerGUI.SetMessage("Empty", "There is no flower according to searched information!");
                        }
                }
                else
                {
                    this.iManagerGUI.SetMessage("Empty", "The searched information is empty!");
                }
            }
            catch (Exception exception)
            {
                this.iManagerGUI.SetMessage("Flowers search - exception", exception.ToString());
            }
        }

        public void SetFlowerControls()
        {
            try
            {
                if (this.iManagerGUI.GetSelectedRowsNumber() > 0)
                {
                    Debug.WriteLine(this.iManagerGUI.GetSelectedRowsNumber());
                    DataGridViewRow drvr = this.iManagerGUI.GetFirstSelectedRow();
                    uint fid = Convert.ToUInt32(drvr.Cells[0].Value);
                    this.iManagerGUI.SetFloristID(fid);

                    uint id = Convert.ToUInt32(drvr.Cells[1].Value);
                    this.iManagerGUI.SetFlowerID(id);

                    string name = drvr.Cells[2].Value.ToString();
                    this.iManagerGUI.SetType(name);

                    string color = drvr.Cells[3].Value.ToString();
                    this.iManagerGUI.SetColor(color);

                    float price = (float)Convert.ToDouble(drvr.Cells[4].Value);
                    this.iManagerGUI.SetPrice(price);

                    int stock = Convert.ToInt32(drvr.Cells[5].Value);
                    this.iManagerGUI.SetStock(stock);

                    string available = drvr.Cells[6].Value.ToString();
                    this.iManagerGUI.SetAvailability(available);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error at row selection!");
            }
        }

        private void allFlowers()
        {
            try
            {
                List<Flower> list = this.flowerRepository.FlowerList();
                if (list != null)
                {
                    this.setRowFlowerList(list);
                }
                else
                {
                    this.iManagerGUI.SetMessage("Empty", "The list of flowers is empty!");
                }
            }
            catch (Exception exception)
            {
                this.iManagerGUI.SetMessage("Flower List - exception", exception.ToString());
            }
        }

        private void resetFlowerControls()
        {
            this.iManagerGUI.SetFlowerID(1);
            this.iManagerGUI.SetFloristID(1);
            this.iManagerGUI.SetType("");
            this.iManagerGUI.SetColor("");
            this.iManagerGUI.SetPrice(1);
            this.iManagerGUI.SetStock(0);
        }

        private Flower validInformation()
        {
            uint id = this.iManagerGUI.GetFlowerID();
            if (id == 0)
            {
                this.iManagerGUI.SetMessage("Incomplete information!", "Flower ID must be a non-zero natural number!");
                return null;
            }

            uint fid = this.iManagerGUI.GetFloristID();
            if (fid == 0)
            {
                this.iManagerGUI.SetMessage("Incomplete information!", "Florist ID must be a non-zero natural number!");
                return null;
            }

            string type = this.iManagerGUI.GetType();
            if (type == null || type.Length == 0)
            {
                this.iManagerGUI.SetMessage("Incomplete information!", "Flower type is empty!");
                return null;
            }
            string color = this.iManagerGUI.GetColor();
            if (color == null || color.Length == 0)
            {
                this.iManagerGUI.SetMessage("Incomplete information!", "Flower color is empty!");
                return null;
            }
            float price = this.iManagerGUI.GetPrice();
            if (price <= 0)
            {
                this.iManagerGUI.SetMessage("Incomplete information!", "Flower price is equal or less than 0!");
                return null;
            }

            int stock = this.iManagerGUI.GetStock();
            if (stock < 0)
            {
                this.iManagerGUI.SetMessage("Incomplete information!", "Flower stock is lower than 0!");
                return null;
            }

            string isAvailable = this.iManagerGUI.GetAvailability();

            return new Flower(id, fid, type, color, price, stock, isAvailable);
        }

        public void Logout()
        {
            try
            {
                LoginGUI loginGUI = new LoginGUI();
                loginGUI.Show();
                this.iManagerGUI.HideForm();
            }
            catch (Exception exception)
            {
                this.iManagerGUI.SetMessage("Logout failed", exception.ToString());
            }
        }

    }
}
