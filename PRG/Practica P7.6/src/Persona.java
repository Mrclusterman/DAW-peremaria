
public abstract class Persona extends Ser_Vivo{

	private int edad;

	public int getEdad() {
		return edad;
	}

	public void setEdad(int edad) {
		this.edad = edad;
	}
	public String toString() {
		return super.toString() + "\nTengo: " + this.edad + " anos.";
	}
}
