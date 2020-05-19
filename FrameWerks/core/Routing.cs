using System;
using System.Collections.Generic;
using System.Text;

namespace FrameWorks
{
    [Serializable]
    public class Routing
    {
        private int m_routingID;
        private string m_routingName;
        private string m_routingDescription;

        private decimal m_rate;
        private decimal m_hours;
        private decimal m_amount;
        private int m_costFactor;

        // Default Constructor
        public Routing()
        {


        }

        public override string ToString()
        {
            return this.m_routingName;
        }
        // RoutingID
        public int RoutingID
        { get{return m_routingID;}set{m_routingID = value;} }
        // RoutingName
        public string RoutingName
        { get { return m_routingName; } set { m_routingName = value; } }
        // Routing Description
        public string RoutingDescription
        { get { return m_routingDescription; } set { m_routingDescription = value; } }
        // Rate
        public decimal Rate
        { get { return m_rate; } set { m_rate = value; } }
        // Amount of Labor and Rate
        public decimal Amount
        { get { return m_amount; } set { m_amount = value; } }
        // Hours, not sure I need this
        public decimal Hours
        { get { return m_hours; } set { m_hours = value; } }
        // Cost Factor
        public int CostFactor
        { get { return m_costFactor; } set { m_costFactor = value; } }

    }



    [Serializable]
    public class Workorder
    {

        //private int m_workOrderID;
        //private string m_workOrderName;
        private List<Routing> m_routings;
        //private FrameWorks.SubAssemblyBase m_subAssembly;

        // Default Constructor
        public Workorder()
        {
            m_routings = new List<Routing>();

        }

        public Workorder(FrameWorks.SubAssemblyBase Subassembly,int workOrderID)
        {
            m_routings = new List<Routing>();

        }

        #region properties 

       
     

        public List<Routing> Routings
        { get { return m_routings; } }

        #endregion

    }


}
