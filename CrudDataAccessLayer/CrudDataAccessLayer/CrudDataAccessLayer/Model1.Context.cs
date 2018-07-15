﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrudDataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CompanyEntities : DbContext
    {
        public CompanyEntities()
            : base("name=CompanyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Dept> Depts { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
    
        [DbFunction("CompanyEntities", "ShowEmployees")]
        public virtual IQueryable<ShowEmployees_Result> ShowEmployees()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<ShowEmployees_Result>("[CompanyEntities].[ShowEmployees]()");
        }
    
        public virtual ObjectResult<Displaydata_Result> Displaydata()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Displaydata_Result>("Displaydata");
        }
    
        public virtual int InsertEmployee(string eName, Nullable<int> salary, Nullable<int> mgrid, ObjectParameter id)
        {
            var eNameParameter = eName != null ?
                new ObjectParameter("EName", eName) :
                new ObjectParameter("EName", typeof(string));
    
            var salaryParameter = salary.HasValue ?
                new ObjectParameter("Salary", salary) :
                new ObjectParameter("Salary", typeof(int));
    
            var mgridParameter = mgrid.HasValue ?
                new ObjectParameter("Mgrid", mgrid) :
                new ObjectParameter("Mgrid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertEmployee", eNameParameter, salaryParameter, mgridParameter, id);
        }
    
        public virtual int printall()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("printall");
        }
    }
}
