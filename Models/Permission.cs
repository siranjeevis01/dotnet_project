using System.ComponentModel.DataAnnotations;

public class Permission
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    // Other properties such as description, code, etc.
}
