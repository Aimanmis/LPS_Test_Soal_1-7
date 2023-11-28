namespace LPS_Test_Soal_1_7
{
    public class Soal1Class
    {
        // Assuming application is a property or field of Soal1Class
        public Application Application { get; set; }

        public DateTime GetLastRun()
        {
            // Check if the application and its protected property are not null
            if (Application?.Protected != null)
            {
                // Return the shieldLastRun property if it exists
                return Application.Protected.ShieldLastRun;
            }

            // Return a default value or handle the case when the conditions are not met
            // For example, you can return DateTime.MinValue or throw an exception
            return DateTime.MinValue; // replace with an appropriate value or handle the case accordingly
        }
    }

    // Example classes for reference, you should replace these with your actual classes
    public class Application
    {
        public ProtectedClass Protected { get; set; }
    }

    public class ProtectedClass
    {
        public DateTime ShieldLastRun { get; set; }

    }
}
