using System;

public class EstadoHabitacionException : Exception
{ 
	public EstadoHabitacionException() : base()
	{

	}

	public EstadoHabitacionException(string message) : base(message) 
	{ 
	
	}

	public EstadoHabitacionException(string message, Exception InnerException) : base(message, InnerException)
	{ 
	
	}
}
