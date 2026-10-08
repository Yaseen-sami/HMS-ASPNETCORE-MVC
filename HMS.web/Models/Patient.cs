using System.ComponentModel.DataAnnotations;

namespace HMS.Web.Models;

public class Patient
{
    public int PatientId { get; set; }

    [Required]
    [StringLength(50)]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    public string LastName { get; set; } = string.Empty;

    [Required]
    [StringLength(20)]
    public string Gender { get; set; } = string.Empty;

    [Required]
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }

    [Required]
    [Phone]
    [StringLength(15)]
    public string PhoneNumber { get; set; } = string.Empty;

    [EmailAddress]
    [StringLength(100)]
    public string? Email { get; set; }

    [StringLength(250)]
    public string? Address { get; set; }

    [StringLength(100)]
    public string? EmergencyContactName { get; set; }

    [Phone]
    [StringLength(15)]
    public string? EmergencyContactPhone { get; set; }

    [StringLength(50)]
    public string? BloodGroup { get; set; }

    public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;

    public bool IsActive { get; set; } = true;
}