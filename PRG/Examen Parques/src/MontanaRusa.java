
public class MontanaRusa extends Parque implements Gestion{

	private String nombre_montana;
	
	public String getNombre_montana() {
		return nombre_montana;
	}

	public void setNombre_montana(String nombre_montana) {
		this.nombre_montana = nombre_montana;
	}

	@Override
	public String funcionamiento() {
		String salida = "La montana rusa consta de un vagon dragon que recorre un serpenteante rail";
		return salida;
	}

	@Override
	public String show() {
		String salida = "Parque tematico: " + this.nombre + ", ciudad: " + this.ciudad + ", montana rusa: " + this.nombre_montana + ", precio: " + this.precio_entrada;
		return salida;
	}

}
