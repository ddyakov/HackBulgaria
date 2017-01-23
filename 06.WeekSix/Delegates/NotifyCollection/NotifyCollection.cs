namespace NotifyCollection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel;
    using System.Collections;

    public class NotifyCollection<T> 
    {
        public event PropertyChangedEventHandler CollectionChanged;

        private IList<T> items;

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
            set
            {
                if (this.CollectionChanged != null && this.items != value)
                {
                    this.CollectionChanged(this, new PropertyChangedEventArgs("The items have been changed!"));
                }

                this.items = value;
            }
        }

        public void AddNumbers(T number)
        {
            if (this.CollectionChanged != null)
            {
                this.CollectionChanged(this, new PropertyChangedEventArgs(string.Format("Added a number {0} with the index {1}", number, this.items.Count)));
            }

            this.items.Add(number);
        }

        public void RemoveNumber(T number)
        {
            if (this.CollectionChanged != null)
            {
                this.CollectionChanged(this, new PropertyChangedEventArgs(string.Format("The number {0} was removed.", number)));
            }

            this.items.Remove(number);
        }

        public void ReplaceNumber(T number, T replacment)
        {
            if (this.CollectionChanged != null)
            {
                this.CollectionChanged(this, new PropertyChangedEventArgs(string.Format("The number {0} was replaced by {1}", number, replacment)));
            }

            for (int i = 0; i < this.items.Count; i++)
            {
                if (this.items[i].Equals(number))
                {
                    this.items[i] = replacment;
                }
            }
        }
    }
}
