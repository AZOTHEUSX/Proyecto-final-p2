using System;

public class Cliente : Repobase
{
    public int IdCliente { get; set; }
    public string TipoDocumento { get; set; }
    public string Documento { get; set; }
    public string? NombreCompleto { get; set; }
    public string Correo { get; set; }
    public int Estado { get; set; }
    public DateTime FechaCreacion { get; set; }
}
