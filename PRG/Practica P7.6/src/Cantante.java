
public class Cantante extends Persona implements PuedeCantar {

	@Override
	public void cantar() {
		// TODO Auto-generated method stub
		System.out.println("Canta las notas musicales");
	}

	@Override
	public String alimentacion() {
		// TODO Auto-generated method stub
		return "hamburguesas y pizzas";
	}

}
