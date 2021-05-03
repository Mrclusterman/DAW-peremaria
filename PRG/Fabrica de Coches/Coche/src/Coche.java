import javax.swing.JOptionPane;
class Coche{

	private int numCoches = 0;
	private final int MAX_COCHES = 5;
	private String matricula = "";
	private String marca = "SEAT";
	private String modelo = "ALTEA";
	private String color = "blanco";
	private boolean techoSolar = false;
	private float kilometros = 0;
	private int numPuertas = 3;
	private int numPlazas = 5;

	public Coche(){
		this.matricula = "";
		this.marca = "SEAT";
		this.modelo = "ALTEA";
		this.color = "BLANCO";
		this.kilometros = 0;
		this.numPuertas = 3;
		this.numPlazas = 5;
		this.techoSolar = false;
	}
	public Coche(String matricula){
		if(this.numCoches < this.MAX_COCHES){
			this.matricula = matricula;
			this.marca = "SEAT";
			this.modelo = "ALTEA";
			this.color = "BLANCO";
			this.kilometros = 0;
			this.numPuertas = 3;
			this.numPlazas = 5;
			this.techoSolar = false;
			this.numCoches++;
		}
		else{
			JOptionPane.showMessageDialog(null,"El garaje esta lleno", "GARAJE LLENO", JOptionPane.ERROR_MESSAGE);
		}
	}

	public Coche(int numPuertas, int numPlazas){
		if(this.numCoches < this.MAX_COCHES){
			this.numPuertas = numPuertas;
			this.numPlazas = numPlazas;
			this.numCoches++;
		}
		else{
			JOptionPane.showMessageDialog(null,"El garaje esta lleno", "GARAJE LLENO", JOptionPane.ERROR_MESSAGE);
		}
	}

	public Coche(String marca, String modelo, String color){
		if(this.numCoches < this.MAX_COCHES){
			this.marca = marca;
			this.modelo = modelo;
			this.color = color;
			this.numCoches++;
		}
		else{
			JOptionPane.showMessageDialog(null,"El garaje esta lleno", "GARAJE LLENO", JOptionPane.ERROR_MESSAGE);
		}
	}



	public void avanzar(float kilometros){
		this.kilometros += kilometros;
		JOptionPane.showMessageDialog(null,"Operacion realizada con exito, numero total de km= " + this.kilometros);
	}

	public void tunear(){
		kilometros = 0;
		techoSolar = true;
		JOptionPane.showMessageDialog(null,"Kilometros a 0 y techo solar instalado");
	}

	public void tunear(String color){
		this.color = color;
		kilometros = 0;
		techoSolar = true;
		JOptionPane.showMessageDialog(null,"Kilometros a 0 y techo solar instalado");
	}

	public void matricular(String matricula){
		this.matricula = matricula;
		JOptionPane.showMessageDialog(null,"El coche ha sido matriculado.");
	}


	public void setMatricula(String matricula){
		this.matricula = matricula;
	}

	public void setMarca(String marca){
		this.marca = marca;
	}

	public void setModelo(String modelo){
		this.modelo = modelo;
	}

	public void setColor(String color){
		this.color = color;
	}

	public void setTechoSolar(boolean techoSolar){
		this.techoSolar = techoSolar;
	}

	public void setKilometros(float kilometros){
		if(kilometros >= 0){
			this.kilometros = kilometros;
		}else{
			JOptionPane.showMessageDialog(null,"Los Kilometros introducidos no pueden ser menor que 0, se establecido 0 como numero de kilometros recorridos", "Error", JOptionPane.ERROR_MESSAGE);
			this.kilometros = 0;
		}
	}

	public void setNumPuertas(int numPuertas){
		if(numPuertas > 0 && this.numPuertas <= 5){
			this.numPuertas = numPuertas;
		}else{
			this.numPuertas = 3;
		}
	}

	public void setNumPlazas(int numPlazas){
		if(numPlazas > 0 && this.numPlazas < 7){
			this.numPlazas = numPlazas;
		}else{
			this.numPlazas = 5;
		}
	}
	
	public String getMatricula(){
		return this.matricula;
	}

	public String getMarca(){
		return this.marca;
	}

	public String getModelo(){
		return this.modelo;
	}

	public String getColor(){
		return this.color;
	}

	public boolean getTechoSolar(){
		return this.techoSolar;
	}

	public float getKilometros(){
		return this.kilometros;
	}

	public int getNumPuertas(){
		return this.numPuertas;
	}

	public int getNumPlazas(){
		return this.numPlazas;
	}
	public int getNumCoches(){
		return this.numCoches;
	}
}
