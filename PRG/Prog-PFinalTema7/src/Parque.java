import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Collections;

public class Parque {

	public static void main(String[] args) throws NumberFormatException, IOException {
		
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		ArrayList<Vehiculo> arr = new ArrayList<Vehiculo>();
		
		int menu;
		
	do {
		Parque.MostrarOpciones();
		switch(menu = Integer.parseInt(br.readLine()))
		{
		case 1:
			
			Coche c = new Coche("Honda", "Civic", "Rojo", 0.0, 5, 5, 2, false, true);
			arr.add(c);
			System.out.println("Se ha creado un coche");
		break;
		case 2:
			Autobus ab = new Autobus("Alsa", "A2", "Negro", 0.0, 50, 4, "Deportivo", true);
			arr.add(ab);
			System.out.println("Se ha creado un autobus");
		break;
		case 3:
			Motocicleta m = new Motocicleta("Kawasaki", "T8", "Gris", 0.0, 2, 1, 500, true);
			arr.add(m);
			System.out.println("Se ha creado una motocicleta");
		break;
		case 4:
			Avioneta av = new Avioneta("FlyHigh", "BOS", "Blanca", 200.0, 5, 3, "Barajas", 200);
			arr.add(av);
			System.out.println("Se ha creado una avioneta");
		break;
		case 5:
			Yate y = new Yate("Boat", "253", "Verde", 0.0, 10, 2, true, 4, 20);
			arr.add(y);
			System.out.println("Se ha creado un yate");
		break;
		case 6:
			Collections.shuffle(arr);
			Parque.verVehiculo(arr);
		break;
		case 7:
			Collections.shuffle(arr);
			Parque.verVehiculoEspe(arr);
		break;
		case 8:
			System.out.println("Creado por: Gabriel Miralles Alvarez");
		break;
		}
	} while(menu != 8);
}
	
	public static void verVehiculo(ArrayList<Vehiculo> arr) {
		for(int i = 0; i<arr.size(); i++) {
			System.out.println(arr.get(i).frenar());
		}
	}
	
	public static void verVehiculoEspe(ArrayList<Vehiculo> arr) {
		for(int i = 0; i<arr.size(); i++) {
			arr.get(i).setMatricula(Parque.MatRandRec("", 4, 3));
			if(arr.get(i) instanceof Coche) {
				Coche c = (Coche) arr.get(i);
				c.aparcar();
				System.out.println(c.acelerar());
				System.out.println(c.getMatricula());
			} else if (arr.get(i) instanceof Autobus) {
				Autobus ab = (Autobus) arr.get(i);
				ab.abrirPuertas();
				System.out.println(ab.acelerar());
				System.out.println(ab.getMatricula());
			} else if (arr.get(i) instanceof Avioneta) {
				Avioneta av = (Avioneta) arr.get(i);
				System.out.println(av.acelerar());
				av.despegar();
				System.out.println(av.getMatricula());
			} else if (arr.get(i) instanceof Motocicleta) {
				Motocicleta mc =  (Motocicleta) arr.get(i);
				System.out.println(mc.acelerar());
				mc.brincar();
				System.out.println(mc.getMatricula());
			} else if (arr.get(i) instanceof Yate) {
				Yate y = (Yate) arr.get(i);
				System.out.println(y.arrancar());
				y.zarpar();
				System.out.println(y.getMatricula());
			}
		}
	}
	
	public static void MostrarOpciones() {
		System.out.println("1. Crear un coche");
		System.out.println("2. Crear un autobus");
		System.out.println("3. Crear una motocicleta");
		System.out.println("4. Crear una avioneta");
		System.out.println("5. Crear un yate");
		System.out.println("6. Mostrar caracteristicas de todos los vehiculos del parque");
		System.out.println("7. Especificaciones de los vehiculos del parque");
		System.out.println("8. Salir del programa");
		System.out.print("Selecciona una opcion: ");
	}
	
	public static String MatRandRec(String mat, int num, int let) {
		String letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		if(num == 0 && let == 0) {
			return mat;
		} else if(num != 0) {
			mat = mat + (int)(Math.floor(Math.random()*(9-0+1)+0));
			return MatRandRec(mat, num-1, let); 
		} else {
			int rand = (int) Math.floor(Math.random()*25);
			mat += letras.charAt(rand);
			return MatRandRec(mat, num, let-1);
		}
	}
	
}
