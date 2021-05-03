import java.util.ArrayList;
import java.util.Collections;

public class Principal {
	public static void main(String[] args) {
		
		ArrayList<PuedeCantar> arr = new ArrayList<PuedeCantar>();
		
		Cantante cant = new Cantante();
		Gallo ga = new Gallo();
		Canario cana = new Canario();
		cant.setNombre("Carreras");
		cant.setEdad(66);
		cana.setNombre("Piolin");
		cana.setPeso(15.5);
		cana.setNumPatas(2);
		ga.setNombre("Claudio");
		ga.setColor("Blanco");
		ga.setNumPatas(2);
		arr.add(cant);
		arr.add(ga);
		arr.add(cana);
		Collections.shuffle(arr);
		
		for(int i = 0; i<arr.size(); i++) {
			

			if ( arr.get(i) instanceof Cantante) {
				cant = (Cantante) arr.get(i);
				cant.cantar();
				System.out.println(cant.toString());
			}
			else if  ( arr.get(i) instanceof Gallo) {
				ga = (Gallo) arr.get(i);
				ga.cantar();
				System.out.println(ga.toString());
			}
			else if ( arr.get(i) instanceof Canario) {
				cana = (Canario) arr.get(i);
				cana.cantar();
				System.out.println(cana.toString());
			}
		}
	}
}
