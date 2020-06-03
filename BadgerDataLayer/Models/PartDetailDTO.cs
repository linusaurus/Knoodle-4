using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace DataLayer.Models
{
    // +++++++++++++++++++++++++++++++++++++++++++++
    // Aggregate DTO for part editing and creation
    // April 23-2020 -- v1
    // ++++++++++++++++++++++++++++++++++++++++++++
    public class PartDetailDTO : INotifyPropertyChanged
    {
        // private fields +++++++++++++++++
        private int partID;
        private string itemDescription;
        private string partNum;
        private int manuId;
        private int uID;
        private string unitOfMeasure;
        private decimal unitCost;
        private string addedBy;
        private DateTime dateAdded;
        private string modifiedBy;
        private DateTime modifiedDate;
        private string location;
        private int partTypeID;
        private string sku;
        private decimal weight;
        private decimal waste;
        private decimal markUp;
        private bool carbTrack;
        // +++++++++++++++++++++++++++++++


        public int PartID
        {
            get { return partID; }
            set
            {
                partID = value;
                OnPropertyChange();
            }
        }

        public string ItemDescription
        {
            get { return itemDescription; }
            set
            {
                itemDescription = value;
                OnPropertyChange();
            } 
        }

        public string PartNum
        {
            get { return partNum; }
            set
            {
              partNum = value ;
              OnPropertyChange();
            }

        }

        public int ManuId
        {
            get {return manuId; }
            set
            {
                manuId = value;
                OnPropertyChange();
            } 
        }

        public int UID 
        {
            get {return uID; }
            set
            {
               uID = value ;
               OnPropertyChange();
            }
        }

        public string UnitOfMeasure 
        {
            get {return unitOfMeasure; }
            set
            {
               unitOfMeasure = value ;
               OnPropertyChange();
            }
        }

        public decimal UnitCost 
        {
            get {return unitCost; }
            set
            {
                unitCost = value;
                OnPropertyChange();
            }
        }

        public string AddedBy 
        {
            get {return addedBy; }
            set
            {
               addedBy = value ;
               OnPropertyChange();
            }
        }

        public DateTime DateAdded
        {
            get {return dateAdded; }
            set 
            {   
               dateAdded = value ;
               OnPropertyChange();
            }
        }

        public string ModifiedBy 
        {
            get {return modifiedBy; }
            set
            {
                modifiedBy = value;
                OnPropertyChange();
            }
        }

        public string Location
        {
            get {return location; }
            set
            {
               location = value ;
               OnPropertyChange();
            }
        }

        public DateTime ModifiedDate
        {
            get {return modifiedDate; }
            set
            {
               modifiedDate = value;
               OnPropertyChange();
            }
        }

        public int PartTypeID
        {
            get {return partTypeID; }
            set
            {
              partTypeID = value  ;
              OnPropertyChange();
            }
        }

        public string Sku 
        {
            get {return sku; }
            set
            {
               sku = value ;
               OnPropertyChange();
            }
        }

        public decimal Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                OnPropertyChange();
            }
        }

        public decimal MarkUp
        {
            get {return markUp; }
            set
            {
              markUp = value  ;
              OnPropertyChange();
            }
        }

        public decimal Waste
        {
            get { return waste; }
            set
            {
                waste = value;
                OnPropertyChange();
            }
        }

        public bool CarbTrack
        {
            get { return carbTrack; }
            set
            {
                carbTrack = value;
                OnPropertyChange();
            }
        }

        public List<Document> Resources { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }


    //public class ResourceDTO : INotifyPropertyChanged
    //{
    //    private int resourceID;
    //    private string resourceDescription;
    //    private string createdby;
    //    private int currentVersion;
        
    //    public int ResourceID 
    //    {
    //        get { return resourceID; }
    //        set
    //        {
    //            resourceID = value;
    //            OnPropertyChange();
    //        }
    //    }

    //    public string ResourceDescription 
    //    {
    //        get { return resourceDescription; }
    //        set
    //        {
    //           resourceDescription = value ;
    //           OnPropertyChange();
    //        }
    //    }

    //    public string Createdby
    //    {
    //        get { return createdby; }
    //        set
    //        {
    //            createdby = value;
    //            OnPropertyChange();
    //        }
    //    }

    //    public int CurrentVersion 
    //    {
    //        get {return currentVersion; }
    //        set
    //        {
    //           currentVersion = value ;
    //           OnPropertyChange();
    //        } 
    //    }

    //    public List<ResourceVersionDTO> ResourceVersions { get; set; }

    //    public event PropertyChangedEventHandler PropertyChanged;

    //    protected void OnPropertyChange([CallerMemberName] string name = null)
    //    {
    //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    //    }
    //}

    //public class ResourceVersionDTO
    //{
    //    public int resourceVersionID;
    //    public int resourceID;
    //    public int rVersion;
    //    public string versionComment;
    //    public Byte[] resource;
    //    public string modifiedBy;
    //    public DateTime modDate;

    //    public event PropertyChangedEventHandler PropertyChanged;

    //    protected void OnPropertyChange([CallerMemberName] string name = null)
    //    {
    //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    //    }

    //    public int ResourceVersionID 
    //    {
    //        get { return resourceVersionID; }
    //        set
    //        {
    //           resourceVersionID = value ;
    //           OnPropertyChange();
    //        }
    //    }

    //    public int ResourceID 
    //    {
    //        get { return resourceID; }
    //        set
    //        {
    //           resourceID = value ;
    //           OnPropertyChange();
    //        } 
    //    }

    //    public int RVersion
    //    {
    //        get { return rVersion; }
    //        set
    //        {
    //          rVersion = value  ;
    //          OnPropertyChange();
    //        } 
    //    }

    //    public string VersionComment 
    //    {
    //        get {return versionComment; }
    //        set
    //        {
    //            versionComment = value;
    //            OnPropertyChange();
    //        }
            
    //    }

    //    public Byte[] Resource 
    //    {
    //        get {return resource; }
    //        set
    //        {
    //           resource = value ;
    //           OnPropertyChange();
    //        } 
    //    }

    //    public string ModifiedBy
    //    {
    //        get {return modifiedBy; }
    //        set
    //        {
    //           modifiedBy = value ;
    //           OnPropertyChange();
    //        }
    //    }

    //    public DateTime ModDate
    //    {
    //        get {return modDate; }
    //        set 
    //        {
    //           modDate = value ;
    //           OnPropertyChange();
    //        }
    //    }
    //}
}
