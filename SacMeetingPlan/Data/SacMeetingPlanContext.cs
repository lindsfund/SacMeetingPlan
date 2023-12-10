using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SacMeetingPlan.Models;

namespace SacMeetingPlan.Data
{
    public class SacMeetingPlanContext : DbContext
    {
        public SacMeetingPlanContext (DbContextOptions<SacMeetingPlanContext> options)
            : base(options)
        {
        }

        public DbSet<SacMeetingPlan.Models.MeetingPlan> MeetingPlan { get; set; } = default!;
    }
}
