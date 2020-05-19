using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using DataAccess;
using DataAccess.Entities;

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

        public Job FindJob(int jobID)
        {

            return ctx.Job.Find(jobID);
        }

        //public List<Job> RecentJobs()
        //{

        //   // return ctx.Job.OrderByDescending(p => p.)
        //}

        public List<Job> SearchJobs(string term)
        {

            return ctx.Job.Where(w => w.jobname.Contains(term)).ToList();
        }

    }
}
