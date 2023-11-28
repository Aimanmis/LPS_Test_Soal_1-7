namespace LPS_Test_Soal_1_7
{
    public class Laptop
    {
        private string _os; // private member to store the OS information

        public string Os
        {
            get { return _os; } // publicly accessible getter
        }

        public Laptop(string os)
        {
            _os = os; // set the value through the constructor
        }
    }

    public class Soal3Class
    {
        public void ExampleUsage()
        {
            var laptop = new Laptop("macOs");
            Console.WriteLine(laptop.Os); // Output: macOs
        }
    }
}
