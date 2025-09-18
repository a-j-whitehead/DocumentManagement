namespace DocumentManagement.Domain.Clients.Dtos
{
    public class AddressDto
    {
        public string? AddressLine2 { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
    }
}