using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using DataAccess;
using DataAccess.Entities;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Service
{
    public class JobService 
    {
        private readonly ProductionContext ctx;

        public List<Job> Jobs;

        public JobService(ProductionContext context)
        {
            ctx = context;
        }

        public Job GetDeepJob(int jobID)
        {
            return ctx.Job.Include(s => s.Products).ThenInclude(s => s.SubAssembly).Where(j => j.JobID == jobID).FirstOrDefault();
        }

        public Job FindJob(int jobID)
        {

            return ctx.Job.Find(jobID);
        }
        /// <summary>
        /// Return list of 25 most recent Jobs
        /// </summary>
        /// <returns></returns>
        public List<JobListDto> RecentJobs()
        {
            var jobs = ctx.Job.AsNoTracking().OrderByDescending(r => r.start_ts).Select(d => new JobListDto
            {
                JobID = d.JobID,
                JobName = d.JobName
            }).Take(35).ToList();
            return jobs;
        }

        public List<Job> SearchJobs(string term)
        {

            return ctx.Job.Where(w => w.JobName.Contains(term)).ToList();
        }

        

    }
}
