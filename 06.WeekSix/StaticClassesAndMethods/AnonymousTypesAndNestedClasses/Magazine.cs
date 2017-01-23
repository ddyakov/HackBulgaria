using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypesAndNestedClasses
{
    class Magazine
    {
        private string title;
        private int isbn;

        public string Title
        {
            get
            {
                return this.title;
            }
        }

        public int ISBN
        {
            get
            {
                return this.isbn;
            }
        }
    }
}
