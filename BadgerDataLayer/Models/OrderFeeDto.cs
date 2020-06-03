using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace DataLayer.Models
{
    public class OrderFeeDto : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private int orderfeeID { get; set; }
        private string feeName { get; set; }
        private decimal qnty { get; set; }
        private decimal cost { get; set; }
        private decimal extension { get; set; }

        public int OrderFeeID
        {
            get { return orderfeeID; }
            set
            {
                orderfeeID = value;
                OnPropertyChange();

            }
        }

        public string FeeName
        {
            get { return feeName; }
            set
            {
                feeName = value;
                OnPropertyChange();
            }
        }

        public decimal Qnty
        {
            get { return qnty; }
            set
            {
                qnty = value;
                extension = cost * qnty;
                OnPropertyChange();
            }
        }

        public decimal Cost
        { 
            get { return cost; }
            set
            {
                cost = value;
                extension = cost * qnty;
                OnPropertyChange();
            }      
        }

        public decimal Extension
        {
            get { return extension; }
            set
            {
                extension = value;
                OnPropertyChange();
            }
        }
    }
}
