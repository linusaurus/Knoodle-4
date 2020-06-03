using System.Collections.Generic;
//using BadgerData;
using DataLayer.Entities;
using DataLayer.Models;

namespace DataLayer.Interfaces
{
    public interface IJobsService {
        void Dispose();
        bool Exist(int jobID);
        List<JobListDto> All();
        Job Find(int jobNumber);
        PurchaseOrder GetJob(int jobNumber);
        List<PurchaseOrder> GetJobOrders(int jobNumber);
        List<Job> GetJobs(string jobName);
       // List<JobListDto> GetJobsList(string JobName);
        void Save();
    }
}