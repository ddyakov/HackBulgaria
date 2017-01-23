using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace AverageAggregator
{
    public class AverageAggregator : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private double average;
        private readonly List<int> numbers = new List<int>();

        public double Average
        {
            get
            {
                return this.average;
            }
            private set
            {
                if (this.average != value && this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Average"));
                }

                this.average = value;
            }
        }

        public void AddNumber(int number)
        {
            this.numbers.Add(number);
            this.Average = this.numbers.Average();
        }
    }
}
