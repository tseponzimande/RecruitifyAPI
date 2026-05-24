namespace Recruitify.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Employee> Employees { get; }
        DbSet<Department> Departments { get; }
        DbSet<Position> Positions { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
