using Microsoft.AspNetCore.Identity;
public class ApplicationUser : IdentityUser
{
    // Puedes agregar campos extra como:
    public string? NombreCompleto { get; set; }
}
