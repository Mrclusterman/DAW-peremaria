
public class Canario extends Animal implements PuedeCantar {
	
	private double peso;

	public double getPeso() {
		return peso;
	}

	public void setPeso(double peso) {
		this.peso = peso;
	}
	
	@Override
	public void cantar() {
		// TODO Auto-generated method stub
		System.out.println("Canta el canto del canario");
	}

	@Override
	public String alimentacion() {
		// TODO Auto-generated method stub
		return "alpiste";
	}
	public String toString() {
		return super.toString() +"\nTengo un peso: " + this.peso ;
	}

}
