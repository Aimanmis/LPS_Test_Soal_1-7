namespace LPS_Test_Soal_1_7
{
    public class ApplicationInfo
    {
        public string Path { get; set; }
        public string Name { get; set; }
    }

    public class Soal2Class
    {
        public ApplicationInfo GetInfo()
        {
            var application = new ApplicationInfo
            {
                Path = "C:/apps/",
                Name = "Shield.exe"
            };
            return application;
        }
    }
}
