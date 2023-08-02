
namespace flights_fullstack.Dtos
{
	public record NewPassengerDto(
		string FirstName,
		string LastName,
		string Email,
		string Mobile,
		string PassportNumber,
		string PassportCountry,
		DateOnly PassportExpiryDate
		);
}

