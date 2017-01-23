namespace INotifyPropertyChanged
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel;

    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string firstName = "Mitko";
        private string secondName = "Dyakov";
        private int ages = 17;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (this.PropertyChanged != null && this.firstName != value)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("FirstName has been changed!"));
                }

                this.firstName = value;
            }
        }

        public string SecondName
        {
            get
            {
                return this.secondName;
            }
            set
            {
                if (this.secondName != value && this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("SecondName has been changed!"));
                }

                this.secondName = value;
            }
        }

        public int Ages
        {
            get
            {
                return this.ages;
            }
            set
            {
                if (this.PropertyChanged != null && this.ages != value)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Ages has been changed!"));
                }

                this.ages = value;
            }
        }

        public override int GetHashCode()
        {
            return firstName.GetHashCode() * 17 + this.secondName.GetHashCode() * 21 + ages.GetHashCode() * 49;
        }
    }
}
