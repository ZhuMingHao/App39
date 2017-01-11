using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace App39
{
   public class ViewModel :INotifyPropertyChanged
    {
        private decimal template;

        public event PropertyChangedEventHandler PropertyChanged;

        public decimal Template
        {
            get
            {
                return template;
            }

            set
            {
                template = value;
                OnPropertyChanged();
            }
        }

       public ViewModel()
        {
            template = new decimal(15);
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler eventHandler = this.PropertyChanged;
            if (eventHandler != null)
            {
                eventHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
