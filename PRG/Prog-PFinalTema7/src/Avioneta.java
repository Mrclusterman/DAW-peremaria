
public class Avioneta extends Vehiculo implements PuedeVolar, PuedeCircular{
	private String aeropuerto;
	private int maxKg;

	public Avioneta() {
		super();
		this.aeropuerto = "";
		this.maxKg = 0;
	};	
	public Avioneta(String marca, String modelo, String color, double kilometros, int numPuertas, int numPlazas, String aeropuerto, int maxKg) {
		super(marca, modelo, color, kilometros, numPuertas, numPlazas);
		this.aeropuerto = aeropuerto;
		this.maxKg = maxKg;
	};


	@Override
	public void volar() {
		// TODO Auto-generated method stub
		System.out.println("Esto es una avioneta y las avionetas pueden circular por el cielo");
	}
	@Override
	public void circular() {
		// TODO Auto-generated method stub
		System.out.println("Esto es una avioneta y las avionetas pueden circular por aerodromos");
	}
	public void despegar() {
		System.out.println("La avioneta ha despegado");
	}
	public void aterrizar() {
		System.out.println("La avioneta ha aterrizado");
	}
	
	@Override
	public String arrancar() {
		// TODO Auto-generated method stub
		return "Arranca la avioneta";
	}
	@Override
	public String acelerar() {
		// TODO Auto-generated method stub
		return "Acelera la avioneta";
	}
	@Override
	public String frenar() {
		// TODO Auto-generated method stub
		return "Frena la avioneta";
	}
	

	public String getAeropuerto() {
		return aeropuerto;
	}
	public void setAeropuerto(String aeropuerto) {
		this.aeropuerto = aeropuerto;
	}
	public int getMaxKg() {
		return maxKg;
	}
	public void setMaxKg(int maxKg) {
		this.maxKg = maxKg;
	}

}
