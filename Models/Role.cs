using System.ComponentModel.DataAnnotations;

public class Role
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    // Other properties such as description, permissions, etc.
}
