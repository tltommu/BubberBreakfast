namespace BubberBreakfast.Contracts.Breakfast.Request;

public record UpsertBreakfastRequest(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string>Savory,
    List<string>Sweet);