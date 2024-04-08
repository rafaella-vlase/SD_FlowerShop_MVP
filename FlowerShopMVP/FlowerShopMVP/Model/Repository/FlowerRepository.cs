using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace FlowerShopMVP.Model.Repository
{
    public class FlowerRepository
    {
        private Repository repository;
        public FlowerRepository()
        {
            this.repository = new Repository();
        }

        public FlowerRepository(string database)
        {
            this.repository = new Repository(database);
        }

        public bool AddFlower(Flower flower)
        {
            string commandSQL = "insert into Flowers values(";
            commandSQL += flower.FloristID;
            commandSQL += ", '" + flower.Type + "', '" + flower.Color;
            commandSQL += "', " + flower.Price + ", " + flower.Stock;
            commandSQL += ", '" + flower.IsAvailable + "')";
            return this.repository.CommandSQL(commandSQL);
        }

        public bool DeleteFlower(uint id)
        {
            string commandSQL = "delete from Flowers where flowerID = '" + id + "'";
            return this.repository.CommandSQL(commandSQL);
        }

        public bool UpdateFlower(Flower flower)
        {
            string commandSQL = "update Flowers set floristID = ";
            commandSQL += flower.FloristID + ", flowerName = '";
            commandSQL += flower.Type + "', color = '" + flower.Color;
            commandSQL += "', price = " + flower.Price;
            commandSQL += ", stock = " + flower.Stock;
            commandSQL += ", available = '" + flower.IsAvailable;
            commandSQL += "' where flowerID = '" + flower.FlowerID + "'";
            return this.repository.CommandSQL (commandSQL);
        }

        public DataTable FlowerTable()
        {
            string selectSQL = "Select * from Flowers order by flowerID";
            DataTable flowerTable = this.repository.GetTable(selectSQL);
            if (flowerTable == null || flowerTable.Rows.Count == 0)
            {
                return null;
            }
            return flowerTable;
        }

        public DataTable FlowerTableEmployee(uint floristID)
        {
            string selectSQL = "Select * from Flowers where floristID = " + floristID + " order by flowerID";
            DataTable flowerTable = this.repository.GetTable(selectSQL);
            if (flowerTable == null || flowerTable.Rows.Count == 0)
            {
                return null;
            }
            return flowerTable;
        }

        public List<Flower> FlowerListEmployee(uint floristID)
        {
            DataTable flowerTable = this.FlowerTableEmployee(floristID);
            if (flowerTable == null)
                return null;
            List<Flower> list = new List<Flower>();
            foreach (DataRow dr in flowerTable.Rows)
            {
                Flower flower = this.convertToFlower(dr);
                list.Add(flower);
            }
            return list;
        }

        public List<Flower> FlowerList()
        {
            DataTable flowerTable = this.FlowerTable();
            if (flowerTable == null)
                return null;
            List<Flower> list = new List<Flower>();
            foreach (DataRow dr in flowerTable.Rows)
            {
                Flower flower = this.convertToFlower(dr);
                list.Add(flower);
            }
            return list;
        }

        public List<Flower> FlowerList_ColorPrice()
        {

            string selectSQL = "select * from [Flowers] order by [color], [price]";


            DataTable flowerTable = this.repository.GetTable(selectSQL);
            if (flowerTable == null || flowerTable.Rows.Count == 0)
            {
                return null;
            }
            List<Flower> list = new List<Flower>();
            foreach (DataRow dr in flowerTable.Rows)
            {
                Flower flower = this.convertToFlower(dr);
                list.Add(flower);
            }
            return list;
        }

        public List<Flower> FlowerList_Availability(string available)
        {
            string selectSQL = "select * from Flowers where available = '" + available + "'";

            DataTable flowerTable = this.repository.GetTable(selectSQL);
            if(flowerTable == null || flowerTable.Rows.Count == 0)
            {
                return null;
            }
            List<Flower> list = new List<Flower>();
            foreach(DataRow dr in flowerTable.Rows)
            {
                Flower flower = this.convertToFlower(dr);
                list.Add(flower);
            }
            return list;
        }

        public List<Flower> FlowerList_AvailabilityEmployee(string available, uint floristID)
        {
            string selectSQL = "select * from Flowers where available = '" + available + "' and floristID = " + floristID;

            DataTable flowerTable = this.repository.GetTable(selectSQL);
            if (flowerTable == null || flowerTable.Rows.Count == 0)
            {
                return null;
            }
            List<Flower> list = new List<Flower>();
            foreach (DataRow dr in flowerTable.Rows)
            {
                Flower flower = this.convertToFlower(dr);
                list.Add(flower);
            }
            return list;
        }

        public List<Flower> FlowerList_Price(string priceString)
        {
            float price = (float)Convert.ToDouble(priceString);
            string selectSQL = "select * from Flowers where price = '" + price + "'";

            DataTable flowerTable = this.repository.GetTable(selectSQL);
            if (flowerTable == null || flowerTable.Rows.Count == 0)
            {
                return null;
            }
            List<Flower> list = new List<Flower>();
            foreach (DataRow dr in flowerTable.Rows)
            {
                Flower flower = this.convertToFlower(dr);
                list.Add(flower);
            }
            return list;
        }

        public List<Flower> FlowerList_PriceEmployee(string priceString, uint floristID)
        {
            float price = (float)Convert.ToDouble(priceString);
            string selectSQL = "select * from Flowers where price = '" + price + "' and floristID = " + floristID;

            DataTable flowerTable = this.repository.GetTable(selectSQL);
            if (flowerTable == null || flowerTable.Rows.Count == 0)
            {
                return null;
            }
            List<Flower> list = new List<Flower>();
            foreach (DataRow dr in flowerTable.Rows)
            {
                Flower flower = this.convertToFlower(dr);
                list.Add(flower);
            }
            return list;
        }

        public List<Flower> FlowerList_Color(string color)
        {
            string selectSQL = "select * from Flowers where color = '" + color + "'";

            DataTable flowerTable = this.repository.GetTable(selectSQL);
            if (flowerTable == null || flowerTable.Rows.Count == 0)
            {
                return null;
            }
            List<Flower> list = new List<Flower>();
            foreach (DataRow dr in flowerTable.Rows)
            {
                Flower flower = this.convertToFlower(dr);
                list.Add(flower);
            }
            return list;
        }

        public List<Flower> FlowerList_ColorEmployee(string color, uint floristID)
        {
            string selectSQL = "select * from Flowers where color = '" + color + "' and floristID = " + floristID;

            DataTable flowerTable = this.repository.GetTable(selectSQL);
            if (flowerTable == null || flowerTable.Rows.Count == 0)
            {
                return null;
            }
            List<Flower> list = new List<Flower>();
            foreach (DataRow dr in flowerTable.Rows)
            {
                Flower flower = this.convertToFlower(dr);
                list.Add(flower);
            }
            return list;
        }

        public List<Flower> FlowerList_Stock(string stockString)
        {

            int stock = Convert.ToInt32(stockString);
            string selectSQL = "select * from Flowers where stock = '" + stock + "'";

            DataTable flowerTable = this.repository.GetTable(selectSQL);
            if (flowerTable == null || flowerTable.Rows.Count == 0)
            {
                return null;
            }
            List<Flower> list = new List<Flower>();
            foreach (DataRow dr in flowerTable.Rows)
            {
                Flower flower = this.convertToFlower(dr);
                list.Add(flower);
            }
            return list;
        }


        public List<Flower> FlowerList_StockEmployee(string stockString, uint floristID)
        {

            int stock = Convert.ToInt32(stockString);
            string selectSQL = "select * from Flowers where stock = '" + stock + "' and floristID = " + floristID;

            DataTable flowerTable = this.repository.GetTable(selectSQL);
            if (flowerTable == null || flowerTable.Rows.Count == 0)
            {
                return null;
            }
            List<Flower> list = new List<Flower>();
            foreach (DataRow dr in flowerTable.Rows)
            {
                Flower flower = this.convertToFlower(dr);
                list.Add(flower);
            }
            return list;
        }

        private Flower convertToFlower(DataRow dataRow)
        {
            int id = (int)dataRow["flowerID"];
            int fid = (int)dataRow["floristID"];
            int stock = (int)dataRow["stock"];
            float price = (float)Convert.ToDouble(dataRow["price"]);
            return new Flower((uint)id,(uint)fid, (string)dataRow["flowerName"], (string)dataRow["color"], (float)price, (int)stock, (string)dataRow["available"]);
        }

        public Flower SearchFlowerByName(string name)
        {
            try
            {
                string searchSQL = "Select * from FlowerShop.dbo.Flowers where flowerName = '" + name + "'";
                DataTable flowerTable = this.repository.GetTable(searchSQL);
                if (flowerTable == null || flowerTable.Rows.Count == 0)
                    return null;
                DataRow dr = flowerTable.Rows[0];
                return this.convertToFlower(dr);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Flower SearchFlowerByNameEmployee(string name, uint floristID)
        {
            try
            {
                string searchSQL = "Select * from FlowerShop.dbo.Flowers where flowerName = '" + name + "'";
                searchSQL += " and floristID = " + floristID;
                DataTable flowerTable = this.repository.GetTable(searchSQL);
                if (flowerTable == null || flowerTable.Rows.Count == 0)
                    return null;
                DataRow dr = flowerTable.Rows[0];
                return this.convertToFlower(dr);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Flower> SearchFlowerByType(string type)
        {
            string selectSQL = "Select * from Flowers where flowerName = '" + type + "'";
            DataTable flowerTable = this.repository.GetTable(selectSQL);
            if (flowerTable == null || flowerTable.Rows.Count == 0)
                return null;
            List<Flower> list = new List<Flower>();
            foreach (DataRow dr in flowerTable.Rows)
            {
                Flower flower = this.convertToFlower(dr);
                list.Add(flower);
            }
            return list;
        }

    }
}

