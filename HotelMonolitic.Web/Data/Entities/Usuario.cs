using System;

public class Usuario : Repobase
{
    public int IdUsuario { get; set; }
    public string NombreCompleto { get; set; }
    public string Correo { get; set; }
    public int IdRolUsuario { get; set; }
    public string Clave { get; set; }
    public int Estado { get; set; }
    public DateTime FechaCreacion { get; set; }
}
