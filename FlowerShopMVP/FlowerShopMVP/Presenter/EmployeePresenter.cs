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
    public class EmployeePresenter
    {
        private IEmployeeGUI iEmployeeGUI;
        private FlowerRepository flowerRepository;
        private uint floristID;

        public EmployeePresenter(IEmployeeGUI iEmployeeGUI, uint floristID)
        {
            this.iEmployeeGUI = iEmployeeGUI;
            this.flowerRepository = new FlowerRepository();
            this.floristID = floristID;
            this.LoadFlowerTableEmployee();
            Debug.Print(floristID.ToString());
        }

        public void LoadFlowerTableEmployee()
        {
            try
            {
                this.iEmployeeGUI.ResetDgvFlowerTable();
                List<Flower> list = flowerRepository.FlowerListEmployee(floristID);

                if (list != null && list.Count > 0)
                {
                    this.setRowFlowerList(list);
                }
                else
                {
                    this.iEmployeeGUI.SetMessage("Empty", "There is no flower in your table!");
                }

            }
            catch (Exception exception)
            {
                this.iEmployeeGUI.SetMessage("Flowers load - exception", exception.ToString());
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
                        this.iEmployeeGUI.SetMessage("Success!", "Adding was completed successfully!");
                        this.iEmployeeGUI.ResetDgvFlowerTable();
                    }
                    else
                        this.iEmployeeGUI.SetMessage("Failure!", "Adding was ended with failure!");
                }
            }
            catch (Exception exception)
            {
                this.iEmployeeGUI.SetMessage("Add - Exception", exception.ToString());
            }
        }

        public void DeleteFlower()
        {
            try
            {
                if (Convert.ToBoolean(this.iEmployeeGUI.GetSelectedFlower()))
                {
                    uint selectedID = Convert.ToUInt32(this.iEmployeeGUI.GetSelectedFlowerID());
                    bool result = this.flowerRepository.DeleteFlower(selectedID);
                    if (result)
                    {
                        this.iEmployeeGUI.ResetDgvFlowerTable();
                        this.iEmployeeGUI.SetMessage("Success!", "Deletion was completed successfully!");
                    }
                    else
                        this.iEmployeeGUI.SetMessage("Failure!", "Deletion was ended with failure!");
                }
                else
                    this.iEmployeeGUI.SetMessage("Failure!", "No flower has been selected to be deleted!");
            }
            catch (Exception exception)
            {
                this.iEmployeeGUI.SetMessage("Delete - Exception", exception.ToString());
            }
        }

        public void UpdateFlower()
        {
            try
            {
                if (Convert.ToBoolean(this.iEmployeeGUI.GetSelectedFlower()))
                {
                    uint selectedID = Convert.ToUInt32(this.iEmployeeGUI.GetSelectedFlowerID());
                    Flower flower = this.validInformation();
                    if (flower != null)
                    {
                        bool result = this.flowerRepository.UpdateFlower(flower);
                        if (result)
                        {
                            this.iEmployeeGUI.SetMessage("Success!", "Updating was completed successfully!");
                            this.iEmployeeGUI.ResetDgvFlowerTable();
                        }
                        else
                            this.iEmployeeGUI.SetMessage("Failure!", "Updating was ended with failure!");
                    }
                }
                else
                    this.iEmployeeGUI.SetMessage("Failure!", "No flower has been selected to be updated!");
            }
            catch (Exception exception)
            {
                this.iEmployeeGUI.SetMessage("Update - Exception", exception.ToString());
            }
        }

        public void FlowerTableFilterBy()
        {
            try
            {
                this.iEmployeeGUI.ResetDgvFlowerTable();
                string selectedOption = this.iEmployeeGUI.GetSelectedCriterion();
                if (selectedOption != null && selectedOption.Length > 0)
                {
                    if (selectedOption.ToUpper() == "NONE")
                    {
                        this.allFlowers(floristID);
                    }
                    else if (selectedOption.ToUpper() == "AVAILABILITY")
                    {
                        string available = this.iEmployeeGUI.GetAvailability();
                        this.FlowerFilterBy(selectedOption, available);
                    } else if(selectedOption.ToUpper() == "PRICE")
                    {
                        string price = this.iEmployeeGUI.GetPrice().ToString();
                        this.FlowerFilterBy(selectedOption, price);
                    } else if(selectedOption.ToUpper() == "COLOR")
                    {
                        string color = this.iEmployeeGUI.GetColor();
                        this.FlowerFilterBy(selectedOption, color);
                    } else if(selectedOption.ToUpper() == "STOCK")
                    {
                        string stock = this.iEmployeeGUI.GetStock().ToString();
                        this.FlowerFilterBy(selectedOption, stock);
                    }
                }
            }
            catch (Exception exception)
            {
                this.iEmployeeGUI.SetMessage("Flowers - Exception", exception.ToString());
            }
        }

        public void FlowerFilterBy(string criterion, string value)
        {
            try
            {
                this.iEmployeeGUI.ResetDgvFlowerTable();


                if (criterion.Length > 0)
                {
                    if (criterion.ToUpper() == "AVAILABILITY")
                    {
                        List<Flower> list = this.flowerRepository.FlowerList_AvailabilityEmployee(value, floristID); ;
                        if (list != null)
                        {
                            this.setRowFlowerList(list);
                        }
                        else this.iEmployeeGUI.SetMessage("Empty", "The flowers from desired availability is empty!");
                    }
                    else if (criterion.ToUpper() == "PRICE")
                    {
                        List<Flower> list = this.flowerRepository.FlowerList_PriceEmployee(value, floristID);
                        if (list != null)
                        {
                            this.setRowFlowerList(list);
                        }
                        else this.iEmployeeGUI.SetMessage("Empty", "The flowers from desired price is empty!");
                    }
                    else if (criterion.ToUpper() == "COLOR")
                    {
                        List<Flower> list = this.flowerRepository.FlowerList_ColorEmployee(value, floristID);
                        if (list != null)
                        {
                            this.setRowFlowerList(list);
                        }
                        else this.iEmployeeGUI.SetMessage("Empty", "The flowers from desired color is empty!");
                    }
                    else if (criterion.ToUpper() == "STOCK")
                    {
                        List<Flower> list = this.flowerRepository.FlowerList_StockEmployee(value, floristID);
                        if (list != null)
                        {
                            this.setRowFlowerList(list);
                        }
                        else this.iEmployeeGUI.SetMessage("Empty", "The flowers from desired stock is empty!");
                    }
                }
                else this.iEmployeeGUI.SetMessage("Empty", "The flowers from desired filter is empty!");
            }
            catch (Exception exception)
            {
                this.iEmployeeGUI.SetMessage("Flower List - filter by - exception", exception.ToString());
            }
        }

        public void SetFlowerControls()
        {
            try
            {
                if (this.iEmployeeGUI.GetSelectedRowsNumber() > 0)
                {
                    DataGridViewRow drvr = this.iEmployeeGUI.GetFirstSelectedRow();
                    uint id = Convert.ToUInt32(drvr.Cells[0].Value);
                    this.iEmployeeGUI.SetFlowerID(id);

                    this.iEmployeeGUI.SetFloristID(floristID);

                    string type = drvr.Cells[1].Value.ToString();
                    this.iEmployeeGUI.SetType(type);

                    string color = drvr.Cells[2].Value.ToString();
                    this.iEmployeeGUI.SetColor(color);

                    float price = (float)Convert.ToDouble(drvr.Cells[3].Value);
                    this.iEmployeeGUI.SetPrice(price);

                    int stock = Convert.ToInt32(drvr.Cells[4].Value);
                    this.iEmployeeGUI.SetStock(stock);

                    string isAvailable = drvr.Cells[5].Value.ToString();
                    this.iEmployeeGUI.SetAvailability(isAvailable);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error at row selection!");
            }
        }

        private void allFlowers(uint floristID)
        {
            try
            {
                List<Flower> list = this.flowerRepository.FlowerListEmployee(floristID);
                if (list != null)
                {
                    this.setRowFlowerList(list);
                }
                else
                {
                    this.iEmployeeGUI.SetMessage("Empty", "The list of flowers is empty!");
                }
            }
            catch (Exception exception)
            {
                this.iEmployeeGUI.SetMessage("Flower List - exception", exception.ToString());
            }
        }

        private void setRowFlowerList(List<Flower> list)
        {
            foreach (Flower flower in list)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell { Value = flower.FlowerID.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = flower.Type});
                row.Cells.Add(new DataGridViewTextBoxCell { Value = flower.Color });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = flower.Price.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = flower.Stock.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = flower.IsAvailable });

                this.iEmployeeGUI.AddRowDgvFlowerTable(row);
            }
        }

        private Flower validInformation()
        {
            uint id = this.iEmployeeGUI.GetFlowerID();
            if (id == 0)
            {
                this.iEmployeeGUI.SetMessage("Incomplete information!", "Flower ID must be a non-zero natural number!");
                return null;
            }

            uint fid = this.iEmployeeGUI.GetFloristID();
            if (fid == 0)
            {
                this.iEmployeeGUI.SetMessage("Incomplete information!", "Florist ID must be a non-zero natural number!");
                return null;
            }

            string type = this.iEmployeeGUI.GetType();
            if (type == null || type.Length == 0)
            {
                this.iEmployeeGUI.SetMessage("Incomplete information!", "Flower type is empty!");
                return null;
            }
            string color = this.iEmployeeGUI.GetColor();
            if (color == null || color.Length == 0)
            {
                this.iEmployeeGUI.SetMessage("Incomplete information!", "Flower color is empty!");
                return null;
            }
            float price = this.iEmployeeGUI.GetPrice();
            if (price <= 0)
            {
                this.iEmployeeGUI.SetMessage("Incomplete information!", "Flower price is equal or less than 0!");
                return null;
            }

            int stock = this.iEmployeeGUI.GetStock();
            if (stock < 0)
            {
                this.iEmployeeGUI.SetMessage("Incomplete information!", "Flower stock is lower than 0!");
                return null;
            }

            string isAvailable = this.iEmployeeGUI.GetAvailability();

            return new Flower(id, fid, type, color, price, stock, isAvailable);
        }

        public void SearchFlowerByName(uint floristID)
        {
            try
            {
                this.iEmployeeGUI.ResetDgvFlowerTable();
                this.iEmployeeGUI.SetVisibility(true);
                this.iEmployeeGUI.ResetSelectedCriterion();
                string searchedInfo = this.iEmployeeGUI.GetSearchedInformation();
                if (searchedInfo != null && searchedInfo.Length > 0)
                {
                    List<Flower> list = new List<Flower>();
                    Flower flower = this.flowerRepository.SearchFlowerByNameEmployee(searchedInfo, floristID);
                    if (flower != null)
                    {
                        list.Add(flower);
                    }
                    //else list = this.flowerRepository.SearchFlowerByType(searchedInfo);

                    if (list != null && list.Count > 0)
                    {
                        this.setRowFlowerList(list);
                    }
                    else
                    {
                        this.iEmployeeGUI.SetMessage("Empty", "There is no flower according to searched information!");
                    }
                }
                else
                {
                    this.iEmployeeGUI.SetMessage("Empty", "The searched information is empty!");
                }
            }
            catch (Exception exception)
            {
                this.iEmployeeGUI.SetMessage("Flowers search - exception", exception.ToString());
            }
        }
        public void Logout()
        {
            try
            {
                LoginGUI loginGUI = new LoginGUI();
                loginGUI.Show();
                this.iEmployeeGUI.HideForm();
            }
            catch (Exception exception)
            {
                this.iEmployeeGUI.SetMessage("Logout failed", exception.ToString());
            }
        }

    }
}
