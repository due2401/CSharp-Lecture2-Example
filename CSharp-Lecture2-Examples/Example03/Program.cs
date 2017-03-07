using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string sql =
                @"select * from table
                  where id > 1000";
            string xml =
                @"<Pokemon>
                    <NationalNo>#001</National>
                    <Name>Bulbsaur</Name>
                  </Pokemon>";
            string json =
                @"Pokemon = {
                    NationalN: '#001',
                    Name:Bulbsaur
                  }";

            Console.WriteLine(sql);
            Console.WriteLine(xml);
            Console.WriteLine(json);
        }
    }
}