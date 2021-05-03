
public class Autobus extends Vehiculo implements PuedeCircular {
	
	private String tipoRecorrido;
	private boolean esEscolar;
	
	public Autobus() {
		super();
		this.tipoRecorrido = "";
		this.esEscolar = false;
	}	
	public Autobus(String marca, String modelo, String color, double kilometros, int numPuertas, int numPlazas,String tipoRecorrido, boolean esEscolar) {
		super(marca, modelo, color, kilometros, numPuertas, numPlazas);
		this.tipoRecorrido = tipoRecorrido;
		this.esEscolar = esEscolar;
	}
	

	@Override
	public void circular() {
		// TODO Auto-generated method stub
		System.out.println("Esto es un autobus y los autobuses pueden circular por carreteras, autovias y atopistas");
	}
	public void abrirPuertas() {
		System.out.println("Las puertas del autobus se han abierto");
	}
	public void aparcar() {
		System.out.println("El autobus ha aparcado");
	}
	
	@Override
	public String arrancar() {
		// TODO Auto-generated method stub
		return "Arranca el autobus";
	}
	@Override
	public String acelerar() {
		// TODO Auto-generated method stub
		return "Acelera el autobus";
	}
	@Override
	public String frenar() {
		// TODO Auto-generated method stub
		return "Frena el autobus";
	}

	public String getTipoRecorrido() {
		return tipoRecorrido;
	}
	public void setTipoRecorrido(String tipoRecorrido) {
		this.tipoRecorrido = tipoRecorrido;
	}
	public boolean isEsEscolar() {
		return esEscolar;
	}
	public void setEsEscolar(boolean esEscolar) {
		this.esEscolar = esEscolar;
	}
}
