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
    public class UserRepositoryTest
    {
        [Test]
        public void AddUserTest()
        {
            UserRepository userRepository = new UserRepository("FlowerShopTest");
            User user1 = new User(10, "administrator", "admin", "Administrator", 0);
            User user2 = new User(11, "manager", "man", "Manager", 1);
            User user3 = new User(12, "employee", "emp", "Employee", 1);

            bool result1 = userRepository.AddUser(user1);
            bool result2 = userRepository.AddUser(user2);
            bool result3 = userRepository.AddUser(user3);


            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
            Assert.IsTrue(result3);

        }

        [Test]
        public void UpdateUserTest()
        {
            UserRepository userRepository = new UserRepository("FlowerShopTest");
            User user = new User(3, "mike", "forza", "Employee", 2);

            bool result = userRepository.UpdateUser(user);

            Assert.IsTrue(result);
        }

        [Test]
        public void DeleteUserTest()
        {
            UserRepository userRepository = new UserRepository("FlowerShopTest");
            User user = new User(4, "testUser", "test", "Employee", 1);

            bool result = userRepository.DeleteUser(user.UserID);


            Repository repository = new Repository("FlowerShopTest");
            string commandTruncate = "truncate table [FlowerShopTest].[dbo].[Users]";
            repository.CommandSQL(commandTruncate);

            string reconstructTable = "DECLARE @userID int;";
            reconstructTable += "SET @userID = 1;";
            reconstructTable += "WHILE @userID <= 10 ";
            reconstructTable += "BEGIN INSERT INTO Users (username, password, role, floristID) VALUES ";
            reconstructTable += "('User' + CAST(@userID AS varchar(2)), 'Password' + CAST(@userID AS varchar(2)), 'Employee', @userID % 4 + 1);";
            reconstructTable += "SET @userID = @userID + 1; END";

            repository.CommandSQL(reconstructTable);


            Assert.IsTrue(result);

        }

        [Test]
        public void UserListTest()
        {
            UserRepository userRepository = new UserRepository("FlowerShopTest");

            User user1 = new User(123, "test1", "test", "Administrator", 0);
            User user2 = new User(124, "test2", "test", "Employee", 1);

            userRepository.AddUser(user1);
            userRepository.AddUser(user2);

            List<User> result = userRepository.UserList();


            Assert.IsNotNull(result);
        }

        [Test]
        public void SearchUserTest()
        {
            UserRepository userRepository = new UserRepository("FlowerShopTest");

            User user1 = new User(123, "test1", "test", "Administrator", 0);

            userRepository.AddUser(user1);

            User result1 = userRepository.SearchUserByID(user1.UserID.ToString());
            User result2 = userRepository.SearchUserByID("3");


            Assert.IsNull(result1);
            Assert.IsNotNull(result2);
        }
    }
}