namespace Recruitify.Domain.Entities
{
    public class Position : BaseEntity
    {
        #region Properties

        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public Guid DepartmentId { get; set; }

        #endregion

        #region Navigation
        public Department Department { get; set; } = null!;
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();

        #endregion
    }
}
