using Sample0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.FluentInterfacePrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            // sample 0
            Person v = FluentPersonFactory
                .Init()
                .GiveAColor("")
                .GiveAGravatar("")
                .GiveANickName("")
                .SetForce(20)
                .TakeAHero();
        }
    }
}
