using BubberBreakfast.Models;
using ErrorOr;

namespace BubberBreakfast.Services.Breakfasts;

public interface IBreakfastServices
{
    ErrorOr<Created>CreateBreakfast(Breakfast breakfast);
    ErrorOr<Deleted>DeleteBreakfast(Guid id);
    ErrorOr<Breakfast> GetBreakfast(Guid id);
    ErrorOr<UpsertedBreakfast> UpsertBreakfast(Breakfast breakfast);
}