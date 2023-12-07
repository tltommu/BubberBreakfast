namespace BubberBreakfast.Contracts.Breakfast.Request;

public record BreakfastResponse(
    Guid id,
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    DateTime LastModifiedDateTime,
    List<string>Savory,
    List<string>Sweet);