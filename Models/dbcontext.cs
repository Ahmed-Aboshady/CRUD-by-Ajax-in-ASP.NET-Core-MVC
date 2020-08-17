using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDbyAjaxinASP.NETCoreMVC.Models
{
    public class dbcontext:DbContext
    {
        public dbcontext(DbContextOptions<dbcontext> options):base(options)
        { }
        public DbSet<employeemodel> employee { get; set; }

    }
}
