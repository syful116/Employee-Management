using EmployeeManagementSystem.Shared.Enum;

namespace EmployeeManagementSystem.Shared.Common;

public class BaseEntity
{
    public DateTimeOffset Created { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset Updated { get; set;} = DateTimeOffset.UtcNow;
    public string CreatedBy { get; set; } =string.Empty;
    public DateTimeOffset?LastModified {get; set; }

    public string? LastModifiedBy { get; set; }

    public EntityStatus Status { get; set; }    
}
