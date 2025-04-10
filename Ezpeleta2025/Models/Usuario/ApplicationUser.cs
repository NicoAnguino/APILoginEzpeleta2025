using Microsoft.AspNetCore.Identity;
public class ApplicationUser : IdentityUser
{
    //AGREGAMOS CAMPO EXTRA DE LA HERENCIA
    public string? NombreCompleto { get; set; }
}
