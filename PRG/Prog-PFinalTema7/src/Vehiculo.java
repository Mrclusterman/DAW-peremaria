
public abstract class Vehiculo {

	protected String matricula, marca, modelo;
	protected String color;
	protected double kilometros = 0.0;
	protected int numPuertas, numPlazas;
	protected static int numVehiculos;
	protected static final int MAX_VEHICULOS = 5;
	
	public String generaMatricula(String mat) {
		mat = "";
		for(int i = 0; i<4;i++) {
			int aux = (int) Math.floor(Math.random()*(9-0+1)+0);
			mat = mat + aux;
		}
		
		for(int i = 0; i<3; i++) {
			String letras="ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			int numlet = (int) Math.floor(Math.random()*(25-0+1)+0);
			mat=mat+ letras.charAt(numlet);
		}
		return mat;
		
	}
	public String getMatricula() {
		return matricula;
	}
	public void setMatricula(String matricula) {
		this.matricula = matricula;
	}
	public String getMarca() {
		return marca;
	}
	public void setMarca(String marca) {
		this.marca = marca;
	}
	public String getModelo() {
		return modelo;
	}
	public void setModelo(String modelo) {
		this.modelo = modelo;
	}
	public String getColor() {
		return color;
	}
	public void setColor(String color) {
		this.color = color;
	}
	public double getKilometros() {
		return kilometros;
	}
	public void setKilometros(double kilometros) {
		this.kilometros = kilometros;
	}
	public int getNumPuertas() {
		return numPuertas;
	}
	public void setNumPuertas(int numPuertas) {
		this.numPuertas = numPuertas;
	}
	public int getNumPlazas() {
		return numPlazas;
	}
	public void setNumPlazas(int numPlazas) {
		this.numPlazas = numPlazas;
	}
	public static int getNumVehiculos() {
		return numVehiculos;
	}
	public static void setNumVehiculos(int numVehiculos) {
		Vehiculo.numVehiculos = numVehiculos;
	}
	public static int getMaxVehiculos() {
		return MAX_VEHICULOS;
	}
	
	public Vehiculo() {
		if (numVehiculos == MAX_VEHICULOS) {
			System.out.println("Ya no se pueden crear mas vehiculos");
		}
		else {
			this.color = "blanco";
			this.kilometros = 0.0;
			this.matricula = this.generaMatricula(this.matricula);
			;
			numVehiculos++;
		}
		
	}
	public Vehiculo(String marca, String modelo, String color, double kilometros, int numPuertas, int numPlazas) {
		if (numVehiculos == MAX_VEHICULOS) {
			System.out.println("Ya no se pueden crear mas vehiculos");
		}
		else {
			this.marca = marca;
			this.modelo = modelo;
			this.color = color;
			this.matricula = this.generaMatricula(this.matricula);
			this.kilometros = kilometros;
			this.numPuertas = numPuertas;
			this.numPlazas = numPlazas;
			numVehiculos++;
		}	
	}
	
	public abstract String arrancar();
	public abstract String acelerar();
	public abstract String frenar();
	
	public String toString() {
		String salida = "Este vehiculo es de la marca " + this.marca + ", el modelo es " + this.modelo + ", es de color " + this.color + " lleva recorridos " + this.kilometros + "km, ademas tiene " + this.numPuertas + " puertas y " + this.numPlazas + " plazas."; 
		return salida;
	}
}
