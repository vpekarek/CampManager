namespace CampManager.Shared;

public class PersonModel
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? MiddleName { get; set; }
    public AddressModel Address { get; set; } = new();
    public string? Email { get; set; }
    public string? Phone { get; set; }
}
