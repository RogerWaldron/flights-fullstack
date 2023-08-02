namespace flights_fullstack.Models
{
	public record BookingModel(
		Guid FlightId,
		string Airline,
		string Price,
		int NumberOfBookedSeats,
		string PassengerEmail
		);
}

