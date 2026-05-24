namespace Recruitify.Domain.Entities
{
    public class Employee : BaseEntity
    {
        #region Personal Information

        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

        #endregion

        #region Employment Details

        public DateTime HireDate { get; set; }
        public EmploymentStatus Status { get; set; } = EmploymentStatus.Active;

        #endregion

        #region Foreign Keys

        public Guid DepartmentId { get; set; }
        public Guid PositionId { get; set; }

        #endregion

        #region Navigation Properties

        public Department Department { get; set; } = null!;
        public Position Position { get; set; } = null!;

        #endregion
    }
}