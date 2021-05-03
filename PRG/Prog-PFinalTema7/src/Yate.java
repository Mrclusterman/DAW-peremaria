public class Yate extends Vehiculo implements PuedeNavegar{

	private boolean tieneCocina;
	private int numMotores, metrosEslora;
	

	public Yate() {
		super();
	}
	public Yate(String marca, String modelo, String color, double kilometros, int numPuertas, int numPlazas, boolean tieneCocina, int numMotores, int metrosEslora) {
		super(marca, modelo, color, kilometros, numPuertas, numPlazas);
		this.tieneCocina = tieneCocina;
		this.numMotores = numMotores;
		this.metrosEslora = metrosEslora;
	}
	

	@Override
	public void navegar() {
		// TODO Auto-generated method stub
		System.out.println("Esto es un yate y los yates pueden circular por el mar");
	}
	
	public void zarpar() {
		System.out.println("El yate ha zarpado");
	}
	
	public void atracar() {
		System.out.println("El yate ha atracado");
	}

	@Override
	public String arrancar() {
		// TODO Auto-generated method stub
		return "Arranca el yate";
	}
	@Override
	public String acelerar() {
		// TODO Auto-generated method stub
		return "Acelera el yate";
	}
	@Override
	public String frenar() {
		// TODO Auto-generated method stub
		return "Frena el yate";
	}



	public boolean isTieneCocina() {
		return tieneCocina;
	}
	public void setTieneCocina(boolean tieneCocina) {
		this.tieneCocina = tieneCocina;
	}
	public int getNumMotores() {
		return numMotores;
	}
	public void setNumMotores(int numMotores) {
		this.numMotores = numMotores;
	}
	public int getMetrosEslora() {
		return metrosEslora;
	}
	public void setMetrosEslora(int metrosEslora) {
		this.metrosEslora = metrosEslora;
	}

}
