using System.Security.Cryptography.X509Certificates;

namespace StudentAdministrasjonsSystem
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Init();
            void Init()
            {
                var data = new Data();
                data.GenerateData();
                data.InitAll();
            }
        }
    }
}