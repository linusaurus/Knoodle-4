using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace DataLayer.Models
{
    /// <summary>
    /// The new model of basic smart bindable DTO
    /// </summary>
    public class InventoryItemDto : INotifyPropertyChanged
    {
        private int stockTransActionID;
        private int orderReceiptID;
        private int lineID;
        private int stockBillID;
        private int jobID;
        private DateTime dateStamp;
        private string description;
        private decimal qntyOrdered;
        private decimal qntyRecieved;
        private int transActionType;
        private string transActionName;

        public int StockTransActionID
        {
            get { return stockTransActionID; }
            set
            {
              stockTransActionID = value  ;
              OnPropertyChange();
            }
        }

        public int OrderReceiptID
        {
            get { return orderReceiptID; }
            set
            {
                orderReceiptID = value;
                OnPropertyChange();
            }
        }

        public int LineID
        {
            get { return lineID; }
            set
            {
                lineID = value;
                OnPropertyChange();       
            }   
        }
 
        public DateTime DateStamp
        {
            get { return dateStamp; }
            set
            {
                dateStamp = value;
                OnPropertyChange();
            }
        }

        public string Description
        {
            get { return description; }
            set { description = value;
                OnPropertyChange();

            }
        }

        public decimal QntyOrdered
        {
            get { return qntyOrdered; }
            set
            {
                qntyOrdered = value;
                OnPropertyChange();
            }
        }

        public decimal QntyReceived
        {
            get { return qntyRecieved; }
            set
            {
                qntyRecieved = value;
                OnPropertyChange();
            }
        }

        public int TransActionType
        {
            get { return transActionType; }
            set
            {
                transActionType = value;
                OnPropertyChange();
            }
        }

        
        public string TransActionName
        {
            get { return transActionName; }
            set 
            {
                transActionName = value;
                OnPropertyChange();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
