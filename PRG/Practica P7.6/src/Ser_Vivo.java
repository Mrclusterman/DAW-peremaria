
public abstract class Ser_Vivo {
	
	private String nombre;
	
	public abstract String alimentacion();

	public String getNombre() {
		return nombre;
	}
	public void setNombre(String nombre) {
		this.nombre = nombre;
	}
	
	public String toString() {
		return "Me llamo " + this.nombre;
	}
}
