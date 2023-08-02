
namespace flights_fullstack.Dtos
{
	public record FlightSearchDto(
		DateTime? FromDate,
		DateTime? ToDate,
		string? FromAirport,
		string? ToAirport,
		int? NumberOfPassengers
		);
}

