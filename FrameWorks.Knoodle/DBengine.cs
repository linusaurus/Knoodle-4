using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrameWorks;
using FrameWorks.Makes;




namespace Weaselware.Knoodle
{
    public class Db
    {

        //public delegate void WriteUnitsCompletedEventHandler(object sender, WriteUnitsCompletedEventArgs e);
        //public static BusinessObjects.OutputCollection OutPut;
        

        //public static BusinessObjects.Project ProjectData()
        //{
        //    BusinessObjects.ProjectCollection col = new BusinessObjects.ProjectCollection();
        //    BusinessObjects.Project result = new BusinessObjects.Project();
        //    col.LoadAll();
        //    foreach (BusinessObjects.Project proj in col)
        //    {
        //        result = proj;
        //    }

        //    return result;

        //}

        //public class WriteUnitsCompletedEventArgs : EventArgs
        // {

        //       private BusinessObjects.OutputCollection output;
        //       public WriteUnitsCompletedEventArgs(BusinessObjects.OutputCollection OutPut)
        //       {
        //            this.output = OutPut;
        //       }

        //       public BusinessObjects.OutputCollection OutPut
        //       { get { return output; } set { output = value; } }
   
        //    }
        /// <summary>
        /// Write Parts
        /// </summary>
        /// <param name="units"></param>
        /// <param name="bworker"></param>
        /// <returns></returns>
        //public BusinessObjects.OutputCollection WriteParts(List<FrameWorks.AssemblyBase> units,
        //                    System.ComponentModel.BackgroundWorker bworker)
        //{


        //    //BusinessObjects.OutputCollection _outParts = Db.OutParts();
        //    BusinessObjects.OutputCollection _outParts = new BusinessObjects.OutputCollection();
        //    _outParts.MarkAllAsDeleted();

        //    int jobid = ProjectData().JobNumber.Value;

        //    int counter = 0;
        //    int step = units.Count / 100;

        //    foreach (FrameWorks.Unit un in units)
        //    {
        //        foreach (FrameWorks.SubAssemblyBase sub in un.SubAssemblies)
        //        {
        //            foreach (FrameWorks.Part prt in sub.Parts)
        //            {

        //                string ptype = prt.GetType().ToString();

        //                switch (ptype)
        //                {
        //                    // Labor Part
        //                    case "FrameWorks.LPart":
        //                        {
        //                            BusinessObjects.Output newPart = _outParts.AddNew();
        //                            //number the parts starting at 1
        //                            counter += 1;

        //                            newPart.PartIdentifier = prt.ContainerAssembly.Parent.UnitID.ToString() + "-" + prt.ContainerAssembly.ID.ToString() + "-" + counter.ToString();
        //                            newPart.PartType = prt.PartType;
        //                            newPart.UnitPrice = prt.LaborAmount ;
        //                            newPart.PartLabel = prt.PartLabel;
        //                            //newPart.Price = prt.CalculatedCost;
        //                            //newPart.Qnty = prt.Qnty;
        //                            newPart.Rate = prt.Rate;
        //                            newPart.LaborAmount = prt.LaborAmount;
        //                            //newPart.Markup = prt.MarkUp;
        //                            newPart.FunctionalName = prt.FunctionalName;
        //                            newPart.SubAssemblyGUID = prt.ContainerAssembly.Name;
        //                            newPart.SourceDescription = prt.Source.MaterialDescription;
        //                            newPart.SourceName = prt.Source.MaterialName;
        //                            //newPart.Width = prt.PartWidth;
        //                            //newPart.Length = prt.PartLength;
        //                            //newPart.Thick = prt.PartThick;
        //                            newPart.AssemblyID = prt.ContainerAssembly.Parent.UnitID;
        //                            newPart.AssemblyName = prt.ContainerAssembly.Parent.UnitName;
        //                            //newPart.PartID = prt.Source.ItemID;
        //                            //newPart.Tax = Math.Round((prt.CalculatedCost * 0.0875m), 2);
        //                            //newPart.Weight = Convert.ToDecimal(prt.Weight.ToString());
        //                            //newPart.Waste = prt.Waste;
        //                            //newPart.Area = prt.Area;

        //                            newPart.AssemblyArea = prt.ContainerAssembly.Parent.Area;
        //                            newPart.AssemblyDepth = prt.ContainerAssembly.Parent.UnitDepth;
        //                            newPart.AssemblyWidth = prt.ContainerAssembly.Parent.UnitWidth;
        //                            newPart.AssemblyHieght = prt.ContainerAssembly.Parent.UnitHeight;

        //                            newPart.SubAssemblyWidth = prt.ContainerAssembly.SubAssemblyWidth;
        //                            newPart.SubAssemblyHieght = prt.ContainerAssembly.SubAssemblyHieght;
        //                            newPart.SubAssemblyDepth = prt.ContainerAssembly.SubAssemblyDepth;
        //                            newPart.SubAssemblyArea = prt.ContainerAssembly.Area;
        //                            newPart.JobID = (short)jobid;
        //                            break;
        //                        }
        //                    // Standard Material Part
        //                    case "FrameWorks.Part":
        //                        {
        //                            BusinessObjects.Output newPart = _outParts.AddNew();
        //                            //number the parts starting at 1
        //                            counter += 1;

        //                            newPart.PartIdentifier = jobid + "-" + prt.ContainerAssembly.Parent.UnitID.ToString() + "-" + prt.ContainerAssembly.ID.ToString() + 
        //                                "-" + counter.ToString();
        //                            newPart.PartType = prt.PartType;
        //                            newPart.UnitPrice = prt.UnitPrice;
        //                            newPart.PartLabel = prt.PartLabel;
        //                            newPart.Price = prt.CalculatedCost;
        //                            newPart.Qnty = prt.Qnty;
        //                            newPart.Rate = prt.Rate;
        //                            newPart.Markup = prt.MarkUp;
        //                            newPart.FunctionalName = prt.FunctionalName;
        //                            newPart.SubAssemblyGUID = prt.ContainerAssembly.Name;
        //                            newPart.SourceDescription = prt.Source.MaterialDescription;
        //                            newPart.SourceName = prt.Source.MaterialName;
        //                            newPart.Width = prt.PartWidth;
        //                            newPart.Length = prt.PartLength;
        //                            newPart.Thick = prt.PartThick;
        //                            newPart.AssemblyID = prt.ContainerAssembly.Parent.UnitID;
        //                            newPart.AssemblyName = prt.ContainerAssembly.Parent.UnitName;
        //                            newPart.PartID = prt.Source.ItemID;
        //                            newPart.Tax = Math.Round((prt.CalculatedCost * 0.0875m), 2);
        //                            newPart.Weight = Convert.ToDecimal(prt.Weight.ToString());
        //                            newPart.Waste = prt.Waste;
        //                            newPart.Area = prt.Area;

        //                            newPart.AssemblyArea = prt.ContainerAssembly.Parent.Area;
        //                            newPart.AssemblyDepth = prt.ContainerAssembly.Parent.UnitDepth;
        //                            newPart.AssemblyWidth = prt.ContainerAssembly.Parent.UnitWidth;
        //                            newPart.AssemblyHieght = prt.ContainerAssembly.Parent.UnitHeight;

        //                            newPart.SubAssemblyWidth = prt.ContainerAssembly.SubAssemblyWidth;
        //                            newPart.SubAssemblyHieght = prt.ContainerAssembly.SubAssemblyHieght;
        //                            newPart.SubAssemblyDepth = prt.ContainerAssembly.SubAssemblyDepth;
        //                            newPart.SubAssemblyArea = prt.ContainerAssembly.Area;
        //                            newPart.Uom = Convert.ToInt16(prt.UOM.ToString());
        //                            newPart.JobID = (short)jobid;
        //                            break;
        //                        }
        //                    default:
        //                        break;
        //                }

        //                //
        //            }
        //        }
        //        bworker.ReportProgress(counter += step);
        //    }

        //    _outParts.Save();
        //    return _outParts;

        //}

        //public class AnsyncWriter : ThreadWrapperBase
        //{
        //    private List<FrameWorks.Unit> _units;
        //    int step = 0;
        //    private BusinessObjects.OutputCollection unitCollection;
        //    public event WriteUnitsCompletedEventHandler Completed;
            
         
        //    public AnsyncWriter(List<FrameWorks.Unit> units)
        //    {
        //        this._units = units;
        //        step = 100 / units.Count;
        //    }

        //    protected override void DoTask()
        //    {
                  
        //        //BusinessObjects.OutputCollection _outParts = Db.OutParts();
        //        BusinessObjects.OutputCollection _outParts = new BusinessObjects.OutputCollection();
        //        _outParts.MarkAllAsDeleted();

        //        int counter = 0;

        //        foreach(FrameWorks.Unit   un in _units)
        //        {
        //            foreach (FrameWorks.SubAssemblyBase sub in un.SubAssemblies)
        //            {
        //                foreach (FrameWorks.Part prt in sub.Parts)
        //                {

        //                    string ptype = prt.GetType().ToString();

        //                    switch (ptype)
        //                    {
        //                        // Labor Part
        //                        case "FrameWorks.LPart":
        //                            {
        //                                BusinessObjects.Output newPart = _outParts.AddNew();
        //                                //number the parts starting at 1
        //                                counter += 1;

        //                                newPart.PartIdentifier = prt.ContainerAssembly.Parent.UnitID.ToString() + "-" + prt.ContainerAssembly.ID.ToString() + "-" + counter.ToString();
        //                                newPart.PartType = prt.PartType;
        //                                //newPart.UnitPrice = prt.UnitPrice;
        //                                newPart.PartLabel = prt.PartLabel;
        //                                //newPart.Price = prt.CalculatedCost;
        //                                //newPart.Qnty = prt.Qnty;
        //                                newPart.Rate = prt.Rate;
        //                                newPart.LaborAmount = prt.LaborAmount;
        //                                //newPart.Markup = prt.MarkUp;
        //                                newPart.FunctionalName = prt.FunctionalName;
        //                                newPart.SubAssemblyGUID = prt.ContainerAssembly.Name;
        //                                newPart.SourceDescription = prt.Source.MaterialDescription;
        //                                newPart.SourceName = prt.Source.MaterialName;
        //                                //newPart.Width = prt.PartWidth;
        //                                //newPart.Length = prt.PartLength;
        //                                //newPart.Thick = prt.PartThick;
        //                                newPart.AssemblyID = prt.ContainerAssembly.Parent.UnitID;
        //                                newPart.AssemblyName = prt.ContainerAssembly.Parent.UnitName;
        //                                //newPart.PartID = prt.Source.ItemID;
        //                                //newPart.Tax = Math.Round((prt.CalculatedCost * 0.0875m), 2);
        //                                //newPart.Weight = Convert.ToDecimal(prt.Weight.ToString());
        //                                //newPart.Waste = prt.Waste;
        //                                //newPart.Area = prt.Area;

        //                                newPart.AssemblyArea = prt.ContainerAssembly.Parent.Area;
        //                                newPart.AssemblyDepth = prt.ContainerAssembly.Parent.UnitDepth;
        //                                newPart.AssemblyWidth = prt.ContainerAssembly.Parent.UnitWidth;
        //                                newPart.AssemblyHieght = prt.ContainerAssembly.Parent.UnitHeight;

        //                                newPart.SubAssemblyWidth = prt.ContainerAssembly.SubAssemblyWidth;
        //                                newPart.SubAssemblyHieght = prt.ContainerAssembly.SubAssemblyHieght;
        //                                newPart.SubAssemblyDepth = prt.ContainerAssembly.SubAssemblyDepth;
        //                                newPart.SubAssemblyArea = prt.ContainerAssembly.Area;
        //                                break;
        //                            }
        //                        // Standard Material Part
        //                        case "FrameWorks.Part":
        //                            {
        //                                BusinessObjects.Output newPart = _outParts.AddNew();
        //                                //number the parts starting at 1
        //                                counter += 1;

        //                                newPart.PartIdentifier = prt.ContainerAssembly.Parent.UnitID.ToString() + "-" + prt.ContainerAssembly.ID.ToString() + "-" + counter.ToString();
        //                                newPart.PartType = prt.PartType;
        //                                newPart.UnitPrice = prt.UnitPrice;
        //                                newPart.PartLabel = prt.PartLabel;
        //                                newPart.Price = prt.CalculatedCost;
        //                                newPart.Qnty = prt.Qnty;
        //                                newPart.Rate = prt.Rate;
        //                                newPart.Markup = prt.MarkUp;
        //                                newPart.FunctionalName = prt.FunctionalName;
        //                                newPart.SubAssemblyGUID = prt.ContainerAssembly.Name;
        //                                newPart.SourceDescription = prt.Source.MaterialDescription;
        //                                newPart.SourceName = prt.Source.MaterialName;
        //                                newPart.Width = prt.PartWidth;
        //                                newPart.Length = prt.PartLength;
        //                                newPart.Thick = prt.PartThick;
        //                                newPart.AssemblyID = prt.ContainerAssembly.Parent.UnitID;
        //                                newPart.AssemblyName = prt.ContainerAssembly.Parent.UnitName;
        //                                newPart.PartID = prt.Source.ItemID;
        //                                newPart.Tax = Math.Round((prt.CalculatedCost * 0.0875m), 2);
        //                                newPart.Weight = Convert.ToDecimal(prt.Weight.ToString());
        //                                newPart.Waste = prt.Waste;
        //                                newPart.Area = prt.Area;

        //                                newPart.AssemblyArea = prt.ContainerAssembly.Parent.Area;
        //                                newPart.AssemblyDepth = prt.ContainerAssembly.Parent.UnitDepth;
        //                                newPart.AssemblyWidth = prt.ContainerAssembly.Parent.UnitWidth;
        //                                newPart.AssemblyHieght = prt.ContainerAssembly.Parent.UnitHeight;

        //                                newPart.SubAssemblyWidth = prt.ContainerAssembly.SubAssemblyWidth;
        //                                newPart.SubAssemblyHieght = prt.ContainerAssembly.SubAssemblyHieght;
        //                                newPart.SubAssemblyDepth = prt.ContainerAssembly.SubAssemblyDepth;
        //                                newPart.SubAssemblyArea = prt.ContainerAssembly.Area;
        //                                newPart.Uom = Convert.ToInt16(prt.UOM.ToString());
        //                                break;
        //                            }
        //                        default:
        //                            break;
        //                    }

        //                    //
        //                }
        //            }
        //        }

        //        _outParts.Save();
        //        unitCollection = _outParts;
               

        //    }
        //    protected override void OnCompleted()
        //    {
        //        // Signal that the operation is complete.
        //        if (Completed != null)
        //            Completed(this,
        //            new WriteUnitsCompletedEventArgs(unitCollection));
        //    }


                
        //}

        //Access Connection
       
        // Set Access Connection with File Path
       
        // Sql Connection
      
        /// <summary>
        /// Outparts
        /// </summary>
        /// <returns></returns>
       

       

       
        // This is the syncronius non-threaded write parts to database version
        //public static BusinessObjects.OutputCollection Write(List<FrameWorks.Unit> unitCollection)
        //{
        //    BusinessObjects.OutputCollection _outParts = Db.OutParts();
        //    _outParts.MarkAllAsDeleted();

        //    int counter = 0;
        //    int jobid = ProjectData().JobNumber.Value;
        //    string jobname = ProjectData().JobName.ToString();

        //    foreach (FrameWorks.Unit un in unitCollection)
        //    {
        //        foreach (FrameWorks.SubAssemblyBase sub in un.SubAssemblies)
        //        {
        //            foreach (FrameWorks.Part prt in sub.Parts)
        //            {

        //                string ptype = prt.GetType().ToString();

        //                switch (ptype)
        //                {
        //                    // Labor Part
        //                    case "FrameWorks.LPart":
        //                        {
        //                            BusinessObjects.Output newPart = _outParts.AddNew();
        //                            //number the parts starting at 1
        //                            counter += 1;
        //                            newPart.PartClass = "Labor";
        //                            newPart.Price = prt.CalculatedCost ;
        //                            newPart.PartIdentifier = prt.ContainerAssembly.Parent.UnitID.ToString() + "-" + prt.ContainerAssembly.ID.ToString() + "-" + counter.ToString();

                                
        //                            newPart.PartType = prt.PartType;
        //                            newPart.UnitPrice = prt.UnitPrice;
        //                            newPart.PartLabel = prt.PartLabel;
 
        //                            newPart.Rate = prt.Rate;
        //                            newPart.LaborAmount = prt.LaborAmount;
        //                            //newPart.Markup = prt.MarkUp;
        //                            newPart.FunctionalName = prt.FunctionalName;
        //                            newPart.SubAssemblyGUID = prt.ContainerAssembly.Name;
        //                            newPart.SourceDescription = prt.Source.MaterialDescription;
        //                            newPart.SourceName = prt.Source.MaterialName;

        //                            newPart.AssemblyID = prt.ContainerAssembly.Parent.UnitID;
        //                            newPart.AssemblyName = prt.ContainerAssembly.Parent.UnitName;
        //                            //newPart.PartID = prt.Source.ItemID;
        //                            //newPart.Tax = Math.Round((prt.CalculatedCost * 0.0875m), 2);
        //                            //newPart.Weight = Convert.ToDecimal(prt.Weight.ToString());
        //                            //newPart.Waste = prt.Waste;
        //                            //newPart.Area = prt.Area;

        //                            newPart.AssemblyArea = prt.ContainerAssembly.Parent.Area;
        //                            newPart.AssemblyDepth = prt.ContainerAssembly.Parent.UnitDepth;
        //                            newPart.AssemblyWidth = prt.ContainerAssembly.Parent.UnitWidth;
        //                            newPart.AssemblyHieght = prt.ContainerAssembly.Parent.UnitHeight;

        //                            newPart.SubAssemblyWidth = prt.ContainerAssembly.SubAssemblyWidth;
        //                            newPart.SubAssemblyHieght = prt.ContainerAssembly.SubAssemblyHieght;
        //                            newPart.SubAssemblyDepth = prt.ContainerAssembly.SubAssemblyDepth;
        //                            newPart.SubAssemblyArea = prt.ContainerAssembly.Area;

        //                            newPart.JobID = (int) jobid;
        //                            newPart.JobName = jobname;
        //                            break;
        //                        }
        //                    // Standard Material Part
        //                    case "FrameWorks.Part":
        //                        {
        //                            BusinessObjects.Output newPart = _outParts.AddNew();
        //                            //number the parts starting at 1
        //                            counter += 1;
        //                            string s = prt.ContainerAssembly.Name.ToString();
        //                            newPart.PartIdentifier =  prt.ContainerAssembly.Parent.UnitID.ToString() + "-" + prt.ContainerAssembly.ID.ToString() + "-" + counter.ToString();
        //                            newPart.PartType = prt.PartType;
        //                            newPart.UnitPrice = prt.UnitPrice;
        //                            newPart.PartLabel = prt.PartLabel;
        //                            newPart.Price = prt.CalculatedCost;
        //                            newPart.Qnty = prt.Qnty;
        //                            newPart.Rate = prt.Rate;
        //                            newPart.Markup = prt.MarkUp;
        //                            newPart.FunctionalName = prt.FunctionalName;
        //                            newPart.SubAssemblyGUID = prt.ContainerAssembly.Name;
        //                            newPart.SourceDescription = prt.Source.MaterialDescription;
        //                            newPart.SourceName = prt.Source.MaterialName;
        //                            newPart.Width = prt.PartWidth;
        //                            newPart.Length = prt.PartLength;
        //                            newPart.Thick = prt.PartThick;
        //                            newPart.AssemblyID = prt.ContainerAssembly.Parent.UnitID;
        //                            newPart.AssemblyName = prt.ContainerAssembly.Parent.UnitName;
        //                            newPart.PartID = prt.Source.ItemID;
        //                            newPart.Tax = Math.Round((prt.CalculatedCost * 0.0875m), 2);
        //                            newPart.Weight = Convert.ToDecimal(prt.Weight.ToString());
        //                            newPart.Waste = prt.Waste;
        //                            newPart.Area = prt.Area;
        //                            newPart.PartClass = prt.PartGroupType;

        //                            newPart.AssemblyArea = prt.ContainerAssembly.Parent.Area;
        //                            newPart.AssemblyDepth = prt.ContainerAssembly.Parent.UnitDepth;
        //                            newPart.AssemblyWidth = prt.ContainerAssembly.Parent.UnitWidth;
        //                            newPart.AssemblyHieght = prt.ContainerAssembly.Parent.UnitHeight;

        //                            newPart.SubAssemblyWidth = prt.ContainerAssembly.SubAssemblyWidth;
        //                            newPart.SubAssemblyHieght = prt.ContainerAssembly.SubAssemblyHieght;
        //                            newPart.SubAssemblyDepth = prt.ContainerAssembly.SubAssemblyDepth;
        //                            newPart.SubAssemblyArea = prt.ContainerAssembly.Area;
        //                            newPart.Uom = Convert.ToInt16(prt.UOM.ToString());
        //                            newPart.JobID = (int)jobid;
        //                            newPart.JobName = jobname;
        //                            break;
        //                        }
        //                    default:
        //                        break;
        //                }


        //            }
        //        }
        //    }

        //    _outParts.Save();
        //    return _outParts;

        //}

        /*
         Threaded version of outputting parts to database table 
        */
        //public static void WriteParts(List<FrameWorks.Unit> unitCollection, System.ComponentModel.BackgroundWorker bworker)
        //{

        //    if (unitCollection != null && unitCollection.Count > 0)
        //    {

        //     int jobid = ProjectData().JobNumber.Value;
        //     string jobname = ProjectData().JobName.ToString();

        //    BusinessObjects.OutputCollection _outParts = Db.OutParts();
        //    _outParts.MarkAllAsDeleted();

        //   int counter = 0;
        //   int step = 100 / unitCollection.Count ;

        //   int partCounter = 0;
        //    foreach (FrameWorks.Unit un in unitCollection)
        //    {
        //        foreach (FrameWorks.SubAssemblyBase sub in un.SubAssemblies)
        //        {
        //            foreach (FrameWorks.Part prt in sub.Parts)
        //            {

        //                string ptype = prt.GetType().ToString();
        //                partCounter ++;
        //                switch (ptype)
        //                {
        //                    // Labor Part
        //                    case "FrameWorks.LPart":
        //                        {
        //                            BusinessObjects.Output newPart = _outParts.AddNew();
        //                            //number the parts starting at 1

        //                            newPart.PartIdentifier = jobid +"-"+ prt.ContainerAssembly.Parent.UnitID.ToString() + "-" + prt.ContainerAssembly.ID.ToString() + "-" + partCounter.ToString();
        //                            newPart.PartType = "Labor";
        //                            newPart.UnitPrice = prt.CalculatedCost;
        //                            newPart.PartLabel = prt.PartLabel;
        //                            newPart.Price = prt.CalculatedCost;
        //                            newPart.Qnty = prt.Qnty;
        //                            newPart.Rate = prt.Rate;
        //                            newPart.LaborAmount = prt.LaborAmount;
        //                            newPart.Uom = (short)prt.UOM;
        //                            //newPart.Markup = prt.MarkUp;
        //                            newPart.FunctionalName = prt.FunctionalName;
        //                            newPart.SubAssemblyGUID = prt.ContainerAssembly.Name;
        //                            newPart.SourceDescription = prt.Source.MaterialDescription;
        //                            newPart.SourceName = prt.Source.MaterialName;
        //                            newPart.AssemblyID = prt.ContainerAssembly.Parent.UnitID;
        //                            newPart.AssemblyName = prt.ContainerAssembly.Parent.UnitName;
        //                            //newPart.PartID = prt.Source.ItemID;
        //                            //newPart.Area = prt.Area;
        //                            newPart.AssemblyArea = prt.ContainerAssembly.Parent.Area;
        //                            newPart.AssemblyDepth = prt.ContainerAssembly.Parent.UnitDepth;
        //                            newPart.AssemblyWidth = prt.ContainerAssembly.Parent.UnitWidth;
        //                            newPart.AssemblyHieght = prt.ContainerAssembly.Parent.UnitHeight;

        //                            newPart.SubAssemblyWidth = prt.ContainerAssembly.SubAssemblyWidth;
        //                            newPart.SubAssemblyHieght = prt.ContainerAssembly.SubAssemblyHieght;
        //                            newPart.SubAssemblyDepth = prt.ContainerAssembly.SubAssemblyDepth;
        //                            newPart.SubAssemblyArea = prt.ContainerAssembly.Area;
        //                            newPart.JobID = (int)jobid;
        //                            newPart.JobName = jobname;
        //                            break;
        //                        }
        //                    // Standard Material Part
        //                    case "FrameWorks.Part":
        //                        {
        //                            BusinessObjects.Output newPart = _outParts.AddNew();
        //                                //number the parts starting at 1

        //                            string guid = Guid.NewGuid().ToString();
        //                            newPart.PartIdentifier = jobid + "-" + prt.ContainerAssembly.Parent.UnitID.ToString() + "-" + prt.ContainerAssembly.ID.ToString() + "-" + partCounter.ToString();
        //                            newPart.PartType = prt.PartType;
        //                            newPart.UnitPrice = prt.UnitPrice;
        //                            newPart.PartLabel = prt.PartLabel;
        //                            newPart.Price = prt.CalculatedCost;
        //                            newPart.Qnty = prt.Qnty;
        //                            newPart.Rate = prt.Rate;
        //                            newPart.Markup = prt.MarkUp;
        //                            newPart.FunctionalName = prt.FunctionalName;
        //                            newPart.SubAssemblyGUID = prt.ContainerAssembly.Name;
        //                            newPart.SourceDescription = prt.Source.MaterialDescription;
        //                            newPart.SourceName = prt.Source.MaterialName;
        //                            newPart.Width = prt.PartWidth;
        //                            newPart.Length = prt.PartLength;
        //                            newPart.Thick = prt.PartThick;
        //                            newPart.AssemblyID = prt.ContainerAssembly.Parent.UnitID;
        //                            newPart.AssemblyName = prt.ContainerAssembly.Parent.UnitName;
        //                            newPart.PartID = prt.Source.ItemID;
        //                            newPart.Tax = Math.Round((prt.CalculatedCost * 0.0875m), 2);
        //                            newPart.Weight = Convert.ToDecimal(prt.Weight.ToString());
        //                            newPart.Waste = prt.Waste;
        //                            newPart.Area = prt.Area;
        //                            newPart.PartClass = prt.PartGroupType;

        //                            newPart.AssemblyArea = prt.ContainerAssembly.Parent.Area;
        //                            newPart.AssemblyDepth = prt.ContainerAssembly.Parent.UnitDepth;
        //                            newPart.AssemblyWidth = prt.ContainerAssembly.Parent.UnitWidth;
        //                            newPart.AssemblyHieght = prt.ContainerAssembly.Parent.UnitHeight;

        //                            newPart.SubAssemblyWidth = prt.ContainerAssembly.SubAssemblyWidth;
        //                            newPart.SubAssemblyHieght = prt.ContainerAssembly.SubAssemblyHieght;
        //                            newPart.SubAssemblyDepth = prt.ContainerAssembly.SubAssemblyDepth;
        //                            newPart.SubAssemblyArea = prt.ContainerAssembly.Area;
        //                            newPart.Uom = Convert.ToInt16(prt.UOM.ToString());
        //                            newPart.JobID = (int)jobid;
        //                            newPart.JobName = jobname;
        //                            break;
        //                        }
        //                    default:
        //                        break;
        //                }
        //            }
        //        }

        //        bworker.ReportProgress(counter += step);
        //    }

        //     _outParts.Save();
             
        //    } 

        //}
        /// <summary>
        /// Populate the Tree Control with Units recursively
        /// </summary>
        /// <param name="units"></param>
        /// <returns></returns>
        //public static List<FrameWorks.Unit> Build(BusinessObjects.UnitCollection units)
        //{

        //    List<FrameWorks.Unit> internalUnits = null;
        //    if (units.Count > 0)
        //    {
        //        internalUnits = new List<Unit>();
        //        foreach (BusinessObjects.Unit unit in units)
        //        {
        //            if (unit.Make == true)
        //            {
        //                internalUnits.Add(PopulateUnit(unit));
        //            }
        //        }
        //    }

        //    return internalUnits;

        //}
        /// <summary>
        /// Populate Unit
        /// </summary>
        /// <param name="InUnit"></param>
        /// <returns>FrameWorks.Unit</returns>
        //private static FrameWorks.Unit PopulateUnit(BusinessObjects.Unit InUnit)
        //{
        //    FrameWorks.Unit result = new Unit();
        //    //Identification
        //    result.UnitID = InUnit.UnitID.Value;
        //    result.UnitName = InUnit.UnitName.ToString();
        //    result.MakeFileName = InUnit.MakeFile;
        //    //Dimensional
        //    result.UnitWidth = InUnit.Fow.Value;
        //    result.UnitHeight = InUnit.Foh.Value;
        //    result.UnitDepth = InUnit.Fod.Value;
        //    foreach (BusinessObjects.Component comp in InUnit.ComponentCollectionByUnitID)
        //    {
        //        // first pass to construct collection without building
        //        result.AddSubAssembly(PopulateSub(comp,result));
        //    }
        //    BuildOutAssemblies(result.SubAssemblies);
        //    return result;
        //}

        //private static void BuildOutAssemblies(List<FrameWorks.SubAssemblyBase>  Subs )
        //{
        //    foreach (SubAssemblyBase  sub in Subs)
        //    {
        //        sub.Build();
        //    }

        //}
        /// <summary>
        /// Core Class generates unit fro class definiion using reflection
        /// </summary>
        /// <param name="inSubAssembly"></param>
        /// <returns></returns>
        //private static FrameWorks.SubAssemblyBase PopulateSub(BusinessObjects.Component inSubAssembly)
        //{
            
        //    FrameWorks.SubAssemblyBase newSub;
        //    string makefile = inSubAssembly.MakeFile;
        //    newSub = FrameWorks.SubAssemblyBase.FactoryNew(makefile);
        //    if (newSub != null)
        //    {
        //        newSub.ID = inSubAssembly.AssemblyID.Value;
        //        newSub.Name = inSubAssembly.AssemblyName;
        //        if (inSubAssembly.W.HasValue) newSub.SubAssemblyWidth = inSubAssembly.W.Value;
        //        if (inSubAssembly.H.HasValue) newSub.SubAssemblyHieght = inSubAssembly.H.Value;
        //        if (inSubAssembly.D.HasValue) newSub.SubAssemblyDepth = inSubAssembly.D.Value;

        //        newSub.Build();
        //    }
        //    else
        //    {
        //        throw new Exception("MakeFile : " + inSubAssembly.MakeFile.ToString() + " Failed");
        //    }

        //    return newSub;
        //}

        //private static FrameWorks.SubAssemblyBase PopulateSub(BusinessObjects.Component inSubAssembly, FrameWorks.Unit parent)
        //{
        //    FrameWorks.SubAssemblyBase newSub;
        //    string makefile = inSubAssembly.MakeFile;
        //    newSub = FrameWorks.SubAssemblyBase.FactoryNew(makefile);
        //    if (newSub != null)
        //    {
        //        newSub.ID = inSubAssembly.AssemblyID.Value;
        //        newSub.Name = inSubAssembly.AssemblyName;
        //        if (inSubAssembly.W.HasValue) newSub.SubAssemblyWidth = inSubAssembly.W.Value;
        //        if (inSubAssembly.H.HasValue) newSub.SubAssemblyHieght = inSubAssembly.H.Value;
        //        if (inSubAssembly.D.HasValue) newSub.SubAssemblyDepth = inSubAssembly.D.Value;
        //        newSub.Parent = parent;
        //        //newSub.Build();
        //    }
        //    else
        //    {
        //        MakeFileException ex = new MakeFileException(makefile);
        //        string MissingType = ex.MakeFileName.ToString();
        //        MessageBox.Show(MissingType + "--Not Found!");
        //        throw ex; 
                
        //    }

        //    return newSub;
        //}

        //public static void FillBuildTree(TreeView buildTree, List<FrameWorks.Unit> units)
        //{
        //    if (units != null && units.Count > 0)
        //    {
        //        foreach (FrameWorks.Unit un in units)
        //        {
        //            TreeNode node = new TreeNode(un.UnitName);
        //            node.Tag = un;
        //            buildTree.Nodes.Add(node);
        //            foreach (FrameWorks.SubAssemblyBase sub in un.SubAssemblies)
        //            {
        //                TreeNode subNode = new TreeNode(sub.Name);
        //                subNode.Tag = sub;
        //                node.Nodes.Add(subNode);
        //                foreach (Part part in sub.Parts)
        //                {
        //                    TreeNode partNode = new TreeNode();
        //                    partNode.Text = part.FunctionalName;
        //                    if(part.GetType().Name.ToString()== "LPart")partNode.BackColor = System.Drawing.Color.Goldenrod;
        //                    partNode.Tag = part;
        //                    subNode.Nodes.Add(partNode);
        //                }
        //            }
        //        }
        //    }


        //}

    }
}
