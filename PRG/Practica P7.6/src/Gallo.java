
public class Gallo extends Animal implements PuedeCantar {

	private String color;

	public String getColor() {
		return color;
	}

	public void setColor(String color) {
		this.color = color;
	}

	@Override
	public void cantar() {
		// TODO Auto-generated method stub
		System.out.println("Canta el canto del gallo");
	}

	@Override
	public String alimentacion() {
		// TODO Auto-generated method stub
		return "maiz";
	}
	public String toString() {
		return super.toString() + "\nSoy de color: " + this.color;
	}
}
