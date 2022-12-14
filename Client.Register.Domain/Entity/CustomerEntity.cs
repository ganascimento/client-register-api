namespace Client.Register.Domain.Entity;

public class CustomerEntity : BaseEntity
{
    public string? Cpf { get; set; }
    public string? Name { get; set; }
    public DateTime BirthDate { get; set; }
    public string? Sex { get; set; }
    public string? PublicPlace { get; set; }
    public string? District { get; set; }
    public string? PostalCode { get; set; }
    public string? City { get; set; }
    public string? Uf { get; set; }
    public string? Number { get; set; }
}