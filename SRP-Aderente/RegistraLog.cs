using System;

namespace SRP_Aderente
{
    class RegistraLog : ILogger
    {
        public void Info(string info)
        {
            Console.WriteLine(info);
        }
    }
}
