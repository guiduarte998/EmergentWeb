namespace EmergentWeb.Models
{
    public class SoftwareManager
    {
        public static List<SoftwareModel> GetAllSoftware()
        {
            return new List<SoftwareModel>
            {
                new SoftwareModel
                {
                    Name = "MS Word",
                    Version = "13.2.1"
                },
                new SoftwareModel
                {
                    Name = "AngularJS",
                    Version = "1.7.1"
                },
                new SoftwareModel
                {
                    Name = "Angular",
                    Version = "13"
                },
                new SoftwareModel
                {
                    Name = "React",
                    Version = "0.0.5"
                },
                new SoftwareModel
                {
                    Name = "Vue.js",
                    Version = "2.6"
                },
                new SoftwareModel
                {
                    Name = "Visual Studio",
                    Version = "17.0.31919.166.0"
                },
                new SoftwareModel
                {
                    Name = "Visual Studio",
                    Version = "16.11.9.3.55"
                },
                new SoftwareModel
                {
                    Name = "Visual Studio Code",
                    Version = "1.63"
                },
                new SoftwareModel
                {
                    Name = "Blazor",
                    Version = "3.2.0"
                }
            };
        }

        public List<SoftwareModel> Softwares { get; set; }
    }
}
