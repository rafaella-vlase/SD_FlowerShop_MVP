using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShopMVP.Model.Repository;

namespace FlowerShopMVP_Test
{
    [TestFixture]
    public class RepositoryTest
    {
        [Test]
        public void OpeningConnectionTest()
        {
            Repository repository = new Repository("FlowerShopTest");
            repository.OpeningConnection();
            Assert.IsTrue(repository.Connection.State == ConnectionState.Open);
        }

        [Test]
        public void ClosingConnectionTest()
        {
            Repository repository = new Repository("FlowerShopTest");
            repository.ClosingConnection();
            Assert.IsTrue(repository.Connection.State == ConnectionState.Closed);
        }

        [Test]
        public void CommandSQLTest()
        {
            Repository repository = new Repository("FlowerShopTest");

            string command1 = "insert into Flowers values(1, 'Monte Cassino', 'Red', 12, 20, 'yes')";
            string command2 = "insert into Flowers values(1, 'Orchid', 'Light Blue', 12.5, 0, 'no')";
            string command3 = "update Flowers set floristID = 2, flowerName = 'Monte Cassino', color = 'Red', price = 11, stock = 14, available = 'yes' where flowerID = 1";
            string command4 = "delete from Flowers where flowerID = 12315";
            
            bool result1 = repository.CommandSQL(command1);
            bool result2 = repository.CommandSQL(command2);
            bool result3 = repository.CommandSQL(command3);
            bool result4 = repository.CommandSQL(command4);

            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
            Assert.IsTrue(result3);
            Assert.IsFalse(result4);
        }

        [Test]
        public void GetTableTest()
        {
            Repository repository = new Repository("FlowerShopTest");
            string selectSQL = "select * from Flowers order by floristID";

            DataTable result = repository.GetTable(selectSQL);

            Assert.IsNotNull(result);
            Assert.AreEqual(7, result.Columns.Count);
        }
    }
}
