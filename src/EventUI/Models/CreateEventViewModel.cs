using System.ComponentModel.DataAnnotations;

namespace EventUI.Models;

public class CreateEventViewModel
{
    [Required]
    [StringLength(35, MinimumLength = 2, ErrorMessage = "Name must be between 2-35 characters long.")]
    public string Name { get; set; } = string.Empty;

    [Required]
    [MinLength(1, ErrorMessage = "Description must be at least 1 characters long")]
    public string Description { get; set; } = string.Empty;

    [Required]
    [DataType(DataType.DateTime)]
    public DateTime StartDateTime { get; set; }

    [Required]
    [DataType(DataType.DateTime)]
    public DateTime EndDateTime { get; set; }

    [Required]
    public string Location { get; set; } = string.Empty;

    public int? MaxParticipants { get; set; }
}
