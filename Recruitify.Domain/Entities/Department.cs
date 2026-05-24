namespace Recruitify.Domain.Entities
{
    public class Department :BaseEntity
    {
        #region Properties

        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        #endregion

        #region Navigation

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        public ICollection<Position> Positions { get; set; } = new List<Position>();

        #endregion
    }
}
