using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EfcoreCodeFirstApproach.Models;

namespace EfcoreCodeFirstApproach.Data
{
    public class EFCodeFirstDb : DbContext
    {
        public EFCodeFirstDb (DbContextOptions<EFCodeFirstDb> options)
            : base(options)
        {
        }

        public DbSet<EfcoreCodeFirstApproach.Models.EmployeeModel> EmployeeModel { get; set; } = default!;
    }
}
