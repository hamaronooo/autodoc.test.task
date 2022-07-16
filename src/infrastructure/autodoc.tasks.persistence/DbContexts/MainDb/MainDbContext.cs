﻿using autodoc.tasks.application.Common.Interfaces;
using autodoc.tasks.domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace autodoc.tasks.persistence.DbContexts.MainDb;

// todo: dev powershell -> dotnet tool install --global dotnet-ef
// create migration: dotnet ef migrations add [NAME]
// update db: dotnet ef database update
// drop db: dotnet ef database drop
// revert migration:
//      -> dotnet ef database update <previous-migration-name>
//      -> dotnet ef migrations remove
public sealed class MainDbContext : DbContext, IMainDbContext
{
	public MainDbContext(DbContextOptions<MainDbContext> options) : base(options) { }

	public DbSet<TaskEntity> Tasks { get; set; }
	public DbSet<TaskStatusEntity> TaskStatuses { get; set; }
	public DbSet<TaskFileEntity> TaskFiles { get; set; }

	public async Task<int> SaveChangesAsync() => await base.SaveChangesAsync();
	public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
		=> await base.SaveChangesAsync(cancellationToken);
	
}