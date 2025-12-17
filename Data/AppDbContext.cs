using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace azure_app_revisit.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    // public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    // {


    public DbSet<Employee> Employees{get;set;}

}
