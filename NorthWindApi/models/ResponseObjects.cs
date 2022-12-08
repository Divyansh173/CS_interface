namespace NorthWindApi.Models
{
    public class ResponseObject
    {
        public List<CustomersEmployeesShipper>? CustomersEmployeesShippers { get; set; }
        
        public CustomersEmployeesShipper? CustomersEmployeesShipper { get; set; }
        public int? StatusCode { get; set; }
        public string? Message { get; set; }
    }
}
