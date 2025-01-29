namespace day3prgm1
{
    class Product
    {
        public int Product_id;
        public string Product_name;
        public Product(int id,string name)
        {
            Product_id = id;
            Product_name = name;
        }
        private void Samplemethod()//can't access elements 
        {
            Console.WriteLine("private method");
        }
        public void publicmethod()
        {
            Console.WriteLine("product id " + Product_id + " product name " + Product_name);
        }
    }
}