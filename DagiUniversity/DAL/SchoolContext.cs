﻿using DagiUniversity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace DagiUniversity.DAL
{
    public class SchoolContext:DbContext
    {
        public SchoolContext() : base("schoolContex")
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }




        public DbSet<Enrollment> Enrollments { get; set; }

        protected  void OnModlCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        

    }
}