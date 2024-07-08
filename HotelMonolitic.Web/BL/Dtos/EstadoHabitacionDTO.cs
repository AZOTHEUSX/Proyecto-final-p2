using System;

public class EstadoHabitacionDTO
{
	public int IdEstadoHabitacion { get; set; }
	public string Descripcion { get; set; }
	public bool Estado {  get; set; }
	public DateTime FechaCreacion { get; set; }
	

    public EstadoHabitacionDTO()
	{

	}

	public EstadoHabitacionDTO(int Ideh,string Des,bool Est,DateTime Fc) 
	{ 
	}
}
