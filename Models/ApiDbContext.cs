using System;
using Microsoft.EntityFrameworkCore;
using dotnet_example.Maps;
using dotnet_example.Models;

namespace dotnet_example.Models
{
  public class ApiDbContext : DbContext
  {
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

    public DbSet<Blog> Blogs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      new BlogMap(modelBuilder.Entity<Blog>());
    }
  }
}