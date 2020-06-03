using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using DataLayer.Interfaces;
using DataLayer.Entities;
using DataLayer.Models;

namespace DataLayer.Services {

    public class JobsService : IDisposable, IJobsService {

        private  BadgerDataModel context;

        public JobsService(BadgerDataModel Context) {
            
            context = Context;
        }

        public bool Exist(int jobID) {

            bool result = false;
            if (context.Job.Any(c=> c.JobId == jobID))
            { result = true;}

            return result;
        }


        public PurchaseOrder GetJob(int jobNumber) {

            return context.PurchaseOrder.Where(c => c.OrderNum == jobNumber).FirstOrDefault();
        }

   
        public List<PurchaseOrder> GetJobOrders(int jobNumber) {

            return context.PurchaseOrder.Where(c => c.JobId == jobNumber).ToList();
        }

        /// <summary>
        /// TODO  refactor to use lightweight DTO return object
        /// </summary>
        /// <param name="jobName"></param>
        /// <returns></returns>
        public List<Job> GetJobs(string jobName) {

            return context.Job
                .Include(p => p.PurchaseOrder).ThenInclude(p => p.PurchaseLineItem)
                .Where(c => c.Jobname.StartsWith(jobName)).OrderByDescending(t => t.start_ts).Take(25).ToList();
        }
        /// <summary>
        /// Return lightweight list of jobs with 
        /// </summary>
        /// <param name="jobName"></param>
        /// <returns></returns>
        //public List<JobListDto> GetJobsList(string jobName)
        //{

        //    var query = context.Job.AsNoTracking().Include(j => j.PurchaseOrder).ThenInclude(s => s.Supplier)
        //        .OrderByDescending(d => d.start_ts).Take(25)
        //        .Select(d = new JobListDto()
        //        {
        //            d
        //        }).ToList();

        //    //return context.Job
        //    //    .Include(p => p.PurchaseOrder).ThenInclude(p => p.PurchaseLineItem)
        //    //    .Where(c => c.Jobname.StartsWith(jobName)).OrderByDescending(t => t.start_ts).Take(25).ToList();
        //}

        public void Save() {

            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public Job Find(int jobNumber) 
        {

            return context.Job.Where(c => c.JobId == jobNumber).FirstOrDefault();
        }

        public List<JobListDto> All()
        {
            var jobs = context.Job.AsNoTracking().OrderByDescending(p => p.JobId)
                                  
                                   .Select(j => new JobListDto()
                                   {
                                       JobID = j.JobId,
                                       JobName = j.Jobname
                                   }).ToList();


            return jobs;

        }
    }
}
