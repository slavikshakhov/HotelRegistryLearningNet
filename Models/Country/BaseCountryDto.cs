using System.ComponentModel.DataAnnotations;

public abstract class BaseCountryDto
{
    [Required]
    public string Name { get; set; }
    public string ShortName { get; set; }
}