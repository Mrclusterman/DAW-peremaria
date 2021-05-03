
public class Motocicleta extends Vehiculo implements PuedeCircular {
	private int potenciaMotor;
	private boolean tieneMaletero;

	public Motocicleta() {
		super();
	};
	public Motocicleta(String marca, String modelo, String color, double kilometros, int numPuertas, int numPlazas, int potenciaMotor, boolean tieneMaletero) {
		super(marca, modelo, color, kilometros, numPuertas, numPlazas);
		this.potenciaMotor = potenciaMotor;
		this.tieneMaletero = tieneMaletero;
	}


	@Override
	public void circular() {
		// TODO Auto-generated method stub
		System.out.println("Esto es una motocicleta y las motocicletas pueden circular por carreteras, autovias y atopistas");
	}
	public void brincar() {
		System.out.println("La motocicleta ha brincado");
	}
	public void aparcar() {
		System.out.println("La motocicleta ha aparcado");
	}
	
	@Override
	public String arrancar() {
		// TODO Auto-generated method stub
		return "Arranca la moto";
	}
	@Override
	public String acelerar() {
		// TODO Auto-generated method stub
		return "Acelera la moto";
	}
	@Override
	public String frenar() {
		// TODO Auto-generated method stub
		return "Frena la moto";
	}
	

	public int getPotenciaMotor() {
		return potenciaMotor;
	}
	public void setPotenciaMotor(int potenciaMotor) {
		this.potenciaMotor = potenciaMotor;
	}
	public boolean isTieneMaletero() {
		return tieneMaletero;
	}
	public void setTieneMaletero(boolean tieneMaletero) {
		this.tieneMaletero = tieneMaletero;
	}

}
