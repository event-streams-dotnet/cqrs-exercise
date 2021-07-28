using System.Diagnostics.CodeAnalysis;

namespace CustomerService.DTO.Write
{
    [ExcludeFromCodeCoverage]
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
    }
}