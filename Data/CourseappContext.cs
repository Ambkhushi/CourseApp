using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationExercise.Models;

namespace Courseapp.Data
{
    public class CourseappContext : DbContext
    {
        public CourseappContext (DbContextOptions<CourseappContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationExercise.Models.Courses> Courses { get; set; } = default!;
    }
}
