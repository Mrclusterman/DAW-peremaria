
public class Coche extends Vehiculo implements PuedeCircular{


		private int numAirbags;
		private boolean techoSolar, tieneRadio;


		public Coche() {
			super();
			this.numAirbags = 0;
			this.techoSolar = false;
			this.tieneRadio = false;
		};	
		public Coche(String marca, String modelo, String color, double kilometros, int numPuertas, int numPlazas, int numAirbags, boolean techoSolar, boolean tieneRadio) {
			super(marca, modelo, color, kilometros, numPuertas, numPlazas);
			this.numAirbags = numAirbags;
			this.techoSolar = techoSolar;
			this.tieneRadio = tieneRadio;
		}
		
		@Override
		public void circular() {
			// TODO Auto-generated method stub
			System.out.println("Esto es un coche y los coches pueden circular por carreteras, autovias y atopistas");
		}
		public void tunear(String color) {
			this.setColor(color);
			this.setKilometros(0);
			this.techoSolar = true;
			System.out.println("El coche ha sido tuneado");
		}
		public void aparcar() {
			System.out.println("El coche ha aparcado");
		}
		
		@Override
		public String arrancar() {
			// TODO Auto-generated method stub
			return "Arranca el coche";
		}
		@Override
		public String acelerar() {
			// TODO Auto-generated method stub
			return "Acelera el coche";
		}
		@Override
		public String frenar() {
			// TODO Auto-generated method stub
			return "Frena el coche";
		}

		public int getNumAirbags() {
			return numAirbags;
		}
		public void setNumAirbags(int numAirbags) {
			this.numAirbags = numAirbags;
		}
		public boolean isTechoSolar() {
			return techoSolar;
		}
		public void setTechoSolar(boolean techoSolar) {
			this.techoSolar = techoSolar;
		}
		public boolean isTieneRadio() {
			return tieneRadio;
		}
		public void setTieneRadio(boolean tieneRadio) {
			this.tieneRadio = tieneRadio;
		}


}
