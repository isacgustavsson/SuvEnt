using System.ComponentModel.DataAnnotations;

namespace EventUI.Models;

public class CreateEventViewModel
{
    [Required]
    [StringLength(3, MinimumLength = 1, ErrorMessage = "Name must be between 1-3 characters long.")]
    public string Name { get; set; } = string.Empty;

    [Required]
    [MinLength(15, ErrorMessage = "Description must be at least 15 ju ,characters long")]
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
