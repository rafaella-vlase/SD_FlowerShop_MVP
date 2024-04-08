using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShopMVP.Model;
using FlowerShopMVP.Model.Repository;

namespace FlowerShopMVP_Test
{
    [TestFixture]
    public class FlowerRepositoryTest
    {
        [Test]
        public void AddFlowerTest()
        {
            FlowerRepository flowerRepository = new FlowerRepository("FlowerShopTest");
            Flower flower = new Flower(20, 2, "Poppy", "Red", 2, 300, "yes");

            bool result1 = flowerRepository.AddFlower(flower);
            bool result2 = flowerRepository.AddFlower(flower);



            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
        }

        [Test]
        public void UpdateFlowerTest()
        {
            FlowerRepository flowerRepository = new FlowerRepository("FlowerShopTest");
            Flower flower1 = new Flower(20001, 2, "Poppy", "Red", 2, 300, "yes");
            Flower flower2 = new Flower(3, 2, "Poppy", "Red", 2, 300, "yes");

            bool result1 = flowerRepository.UpdateFlower(flower1);
            bool result2 = flowerRepository.UpdateFlower(flower2);



            Assert.IsFalse(result1);
            Assert.IsTrue(result2);
        }

        [Test]
        public void DeleteFlowerTest()
        {
            FlowerRepository flowerRepository = new FlowerRepository("FlowerShopTest");
            Flower flower = new Flower(2, 2, "Poppy", "Red", 2, 300, "yes");

            bool result = flowerRepository.DeleteFlower(flower.FlowerID);

            Repository repository = new Repository("FlowerShopTest");
            string commandTruncate = "truncate table [FlowerShopTest].[dbo].[Flowers]";
            repository.CommandSQL(commandTruncate);

            string reconstructTable = "DECLARE @floristID int; ";
            reconstructTable += "SET @floristID = 1; ";
            reconstructTable += "WHILE @floristID <= 4 BEGIN ";
            reconstructTable += "INSERT INTO FlowerShopTest.dbo.Flowers (floristID, flowerName, color, price, stock, available) VALUES (@floristID, 'Rose', 'Red', 10.0, 100, 'yes'); ";
            reconstructTable += "INSERT INTO FlowerShopTest.dbo.Flowers (floristID, flowerName, color, price, stock, available) VALUES (@floristID, 'Tulip', 'Yellow', 8.0, 80, 'yes'); ";
            reconstructTable += "INSERT INTO FlowerShopTest.dbo.Flowers (floristID, flowerName, color, price, stock, available) VALUES (@floristID, 'Lily', 'White', 15.0, 50, 'yes'); ";
            reconstructTable += "INSERT INTO FlowerShopTest.dbo.Flowers (floristID, flowerName, color, price, stock, available) VALUES (@floristID, 'Orchid', 'Purple', 20.0, 30, 'yes'); ";
            reconstructTable += "INSERT INTO FlowerShopTest.dbo.Flowers (floristID, flowerName, color, price, stock, available) VALUES (@floristID, 'Sunflower', 'Yellow', 12.0, 60, 'no'); ";
            reconstructTable += "SET @floristID = @floristID + 1; END";
            repository.CommandSQL(reconstructTable);


            Assert.IsTrue(result);

        }

        [Test]
        public void FlowerListTest()
        {
            FlowerRepository flowerRepository = new FlowerRepository("FlowerShopTest");
            Flower flower1 = new Flower(20001, 2, "Poppy", "Red", 2, 300, "yes");
            Flower flower2 = new Flower(3, 2, "Poppy", "Red", 2, 300, "yes");

            flowerRepository.AddFlower(flower1);
            flowerRepository.AddFlower(flower2);

            List<Flower> result = flowerRepository.FlowerList();


            Assert.IsNotNull(result);

        }

        [Test]
        public void SearchFlowerTest()
        {
            FlowerRepository flowerRepository = new FlowerRepository("FlowerShopTest");
            Flower flower1 = new Flower(20001, 2, "Poppy", "Red", 2, 300, "yes");
            Flower flower2 = new Flower(3, 2, "Poppy", "Red", 2, 300, "yes");

            flowerRepository.AddFlower(flower1);
            flowerRepository.AddFlower(flower2);

            List<Flower> result1 = flowerRepository.SearchFlowerByType(flower1.Type);
            List<Flower> result2 = flowerRepository.SearchFlowerByType("Ghiocel");

            Assert.IsNotNull(result1);
            Assert.IsNull(result2);

        }
    }
}
