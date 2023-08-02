
namespace flights_fullstack.Dtos
{
	public record BookDto(
		Guid FlightId,
		string PassengerEmail,
		string PassengerMobile,
		byte NumberOfSeats
		);
}

