﻿namespace DbService;

public class AppDbContext : DbContext 
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Tbl_Blog>  Blogs{ get; set; }
}
