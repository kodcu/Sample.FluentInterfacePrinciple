using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample0
{
    public interface IPersonFactory
    {
        Person TakeAHero();
        IPersonFactory GiveANickName(string nickName);
        IPersonFactory GiveAColor(string color);
        IPersonFactory GiveAGravatar(string gravatar);
        IPersonFactory SetForce(int forceValue);
    }
}
