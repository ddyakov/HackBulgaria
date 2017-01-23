using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair
{
    class Pair
    {
        private object key;
        private object value;

        public Pair(object key, object value)
        {
            this.key = key;
            this.value = value;
        }

        public object Key
        {
            get { return this.key; }
        }

        public object Value
        {
            get { return this.value; }
        }

        public override string ToString()
        {
            string result = this.key + ":" + this.value;
            return result;
        }

        public override bool Equals(object p1)
        {
            if (this.key == (p1 as Pair).key && this.value == (p1 as Pair).value)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + key.GetHashCode();
                hash = hash * 23 + value.GetHashCode();
                return hash;
            }
        }
    }
}
