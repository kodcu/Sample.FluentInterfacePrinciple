using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample0
{
    public class PersonFactory
        : IPersonFactory
    {
        private Person person = null;
        public PersonFactory(Person person)
        {
            this.person = person;
        }

        public Person TakeAHero()
        {
            return this.person;
        }

        public IPersonFactory GiveANickName(string nickName)
        {
            this.person.NickName = nickName;
            return this;
        }

        public IPersonFactory GiveAColor(string color)
        {
            this.person.Color = color;
            return this;
        }

        public IPersonFactory GiveAGravatar(string gravatar)
        {
            this.person.Gravatar = GetGravatar(address: gravatar);
            return this;
        }

        private byte[] GetGravatar(string address)
        {
            return null;
        }

        public IPersonFactory SetForce(int forceValue)
        {
            this.person.InitilizeForce = forceValue;
            return this;
        }
    }


}
