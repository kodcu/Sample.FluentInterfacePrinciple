using Sample0;
using Sample1;
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

            // sample 1
            //var emre = FluentFactory<Player>
            //    .Initialize(new Player())
            //    .GiveAValue("LastLevel", 12)
            //    .GiveAValue("NickName", "CoolBoy")
            //    .Take();

            var burko = FluentFactory<Player>
                .Initialize(new Player())
                .GiveAValue(x => x.NickName, "Emre")
                .GiveAValue(d => d.LastLevel, 12);
        }
    }
}
