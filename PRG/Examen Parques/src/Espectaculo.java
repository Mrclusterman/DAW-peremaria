
public class Espectaculo extends Parque implements Gestion{

	private String nombre_espectaculo;
	
	public String getNombre_espectaculo() {
		return nombre_espectaculo;
	}

	public void setNombre_espectaculo(String nombre_espectaculo) {
		this.nombre_espectaculo = nombre_espectaculo;
	}

	@Override
	public String funcionamiento() {
		String salida = "El espectaculo consta de una interpretacion de los personajes del Mago de Oz";
		return salida;
	}

	@Override
	public String show() {
		String salida = "Parque tematico: " + this.nombre + ", ciudad: " + this.ciudad + ", espectaculo: " + this.nombre_espectaculo + ", precio: " + this.precio_entrada;
		return salida;
	}

}
