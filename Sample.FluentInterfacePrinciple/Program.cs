using Sample0;
using Sample1;
using Sample2;
using Sample3;
using Sample4;
using Sample5;
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
            Sample0.Person v = FluentPersonFactory
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

            // sample 2
            Car c = new Car()
               .SetName("")
               .SetModel("")
               .SetPlate("")
               .SetPower(12);

            // sample 3
            var personals = new PersonFinder()
                           .FirstName("Emre")
                           .LastName("Keskin")
                           .Find();

            // sample 4
            Vehicle vh = new Vehicle() { Plate = "" };

            var militaryOpr = new MilitaryVehicleOperation()
                            .Add(new Vehicle())
                            .Add(new Vehicle() { SerialNo = "", Plate = "64-MIT-265" })
                            .Remove(vh);

            // sample 5
            var account = new Account()
                            .Create()
                            .SetAccountType(14)
                            .SetAccountNumber(12345)
                            .SetAccountSuffix(354)
                            .SetCustomerName("yunus emre");
                                
        }
    }
}
