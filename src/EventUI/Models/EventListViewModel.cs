namespace EventUI.Models;

public record EventListViewModel(
    int Id,
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    string Location,
    int? MaxParticipants,
    int RegistrationCount
);
