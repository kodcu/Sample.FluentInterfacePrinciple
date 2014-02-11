using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample3
{
    public class PersonFinder
    {
        private string firstName;
        private string lastName;
        private bool includePhoto;

        public PersonFinder FirstName(string firstName)
        {
            this.firstName = firstName;
            return this;
        }

        public PersonFinder LastName(string lastName)
        {
            this.lastName = lastName;
            return this;
        }

        public PersonFinder IncludePhoto
        {
            get
            {
                this.includePhoto = true;
                return this;
            }
        }

        public List<Person> Find()
        {
            return new List<Person>();
        }
    }
}
