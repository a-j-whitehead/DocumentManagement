namespace DocumentManagement.Domain.Clients.Dtos
{
    public class CustomerInformationDto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public AddressDto? AddressLine1 { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
