namespace FlowerShopMVP.Model
{

    public class User
    {
        protected uint userID;
        protected string username;
        protected string password;
        protected string role;
        protected uint floristID;

        public User()
        {
            this.userID = 1;
            this.username = "ella";
            this.password = "stardew";
            this.role = "Administrator";
            this.floristID = 0;
        }

        public User(uint userID, string username, string password, string role, uint floristID)
        {
            this.userID = userID;
            this.username = username;
            this.password = password;
            this.role = role;
            this.floristID = floristID;
        }

        public User(User user)
        {
            this.userID = user.userID;
            this.username = user.username;
            this.password = user.password;
            this.role = user.role;
            this.floristID = user.floristID;
        }

        public uint UserID
        {
            get { return this.userID; }
            set { this.userID = value; }
        }

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public string Role
        {
            get { return this.role; }
            set { this.role = value; }
        }

        public uint FloristID
        {
            get { return this.floristID; }
            set { this.floristID = value; }
        }

        public override string ToString()
        {
            string s = "Username: " + this.username;
            s += "\nPassword: " + this.password;
            s += "\nRole: " + this.role;
            s += "\nFloristID: " + this.floristID;
            return s;
        }
    }
}