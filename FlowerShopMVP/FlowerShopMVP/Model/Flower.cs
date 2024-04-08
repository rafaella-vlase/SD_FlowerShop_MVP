namespace FlowerShopMVP.Model
{
    public class Flower
    {
        protected uint flowerID;
        protected uint floristID;
        protected string type;
        protected string color;
        protected float price;
        protected int stock;
        protected string isAvailable;

        public Flower()
        {
            this.flowerID = 1;
            this.floristID = 1;
            this.price = 15;
            this.stock = 20;
            this.isAvailable = "yes";
            this.color = "Red";
            this.type = "Rose";
        }

        public Flower(uint flowerID, uint floristID, string type, string color, float price, int stock, string isAvailable)
        {
            this.flowerID = flowerID;
            this.floristID = floristID;
            this.price = price;
            this.stock = stock;
            this.isAvailable = isAvailable;
            this.color = color;
            this.type = type;
        }

        public Flower(Flower flower)
        {
            this.flowerID = flower.flowerID;
            this.floristID = flower.floristID;
            this.price = flower.price;
            this.stock = flower.stock;
            this.isAvailable = flower.isAvailable;
            this.color = flower.color;
            this.type = flower.type;
        }

        public uint FlowerID
        {
            get { return this.flowerID; }
            set { this.flowerID = value; }
        }

        public uint FloristID
        {
            get { return this.floristID; }
            set { this.floristID = value; }
        }

        public float Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public int Stock
        {
            get { return this.stock; }
            set { this.stock = value; }
        }

        public string IsAvailable
        {
            get { return this.isAvailable; }
            set { this.isAvailable = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public override string ToString()
        {
            string s = "Flower: " + this.type;
            s += "Flower ID: " + this.flowerID;
            s += " Florist: " + this.floristID;
            s += " Color: " + this.color;
            s += " Price: " + this.price;
            s += " Stock = " + this.stock;
            s += " Is Available? = " + this.isAvailable;
            return s;
        }
    }
}

