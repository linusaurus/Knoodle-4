using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.DTO
{
    public class ComponentDTO
    {

        public string componentGroupName = "Materials";
        public decimal unitPrice;
        public string componentName;
        public int m_ComponentSourceNumber;
        public decimal unitSpecificAmount;
        // this requires the lookup and a Component number
        
        public decimal componentWidth = 0.0m;
        public decimal componentThick = 0.0m;
        public decimal componentLength = 0.0m;
        public string functionName;
        public string m_ComponentGroupType;
        public decimal waste = 0.0m;
        public decimal markup = 0.0m;

        
        public decimal area;
        public string componentLabel = string.Empty;
        public string m_ComponentIdentifier = string.Empty;
        public int uOM = 0;
        public decimal m_weight;
        protected decimal m_waste = 0.0m;
        protected decimal m_markup = 0.0m;
        protected int m_supplierID;
    }
}
