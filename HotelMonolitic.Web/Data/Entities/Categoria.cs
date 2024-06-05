using Microsoft.Identity.Client;
using System;

public class Categoria : Repobase
{
	public int IdCategoria { get; set; }
    public string? Descripcion { get; set; }
    public int Estado { get; set; }
    public DateTime FechaCreacion { get; set; }
}
