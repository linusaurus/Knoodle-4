using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace DataLayer.Models
{
    public class AttachmentDto : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        protected void OnPropertyChange([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public int attachmentId { get; set; }
        public string attachmentDescription { get; set; }
        public int orderNum { get; set; }
        public string ext { get; set; }
        public string src { get; set; }
        public byte[] filesource { get; set; }
        public string creator { get; set; }
        public DateTime createdDate { get; set; }
        public string fileSize { get; set; }


        public string FileSize
        {
            get { return fileSize; }
            set
            {
                fileSize = value;
                OnPropertyChange();
            }
        }

        public DateTime CreatedDate
        {
            get { return createdDate; }
            set
            {
                createdDate = value;
                OnPropertyChange();
            }
        }

        public string Creator
        {
            get { return creator; }
            set
            {
                creator = value;
                OnPropertyChange();
            }
        }

        public int AttachmentID 
        {
            get { return attachmentId;}
            set
            {
               attachmentId = value;
               OnPropertyChange();           
            }
        }

        public string AttachmentDescription
        {
            get {return attachmentDescription; }
            set
            {
                attachmentDescription = value;
                OnPropertyChange();
            }
        }

        public int OrderNum
        {
            get { return orderNum; }
            set
            {
                orderNum = value;
                OnPropertyChange();
            }

        }

        public string Ext
        {
            get { return ext; }
            set
            {
                ext = value;
                OnPropertyChange();
            }

        }

        public string Src
        {
            get { return src; }
            set
            {
                src = value;
                OnPropertyChange();
            }
        }

        public byte[] FileSource
        {
            get { return filesource; }
            set
            {
                filesource = value;
                OnPropertyChange();
            }
        }
    }
}
