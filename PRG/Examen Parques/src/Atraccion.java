
public class Atraccion extends Parque implements Gestion{

	private String nombre_atraccion;
	
	@Override
	public String funcionamiento() {
		String salida = "La atraccion consta de unos botes que navegan sobre varias cascadas";
		return salida;
	}

	@Override
	public String show() {
		String salida = "Parque tematico: " + this.nombre + ", ciudad: " + this.ciudad + ", atraccion: " + this.nombre_atraccion + ", precio: " + this.precio_entrada;
		return salida;
	}

	public String getNombre_atraccion() {
		return nombre_atraccion;
	}

	public void setNombre_atraccion(String nombre_atraccion) {
		this.nombre_atraccion = nombre_atraccion;
	}

}
