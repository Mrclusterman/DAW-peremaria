import java.util.ArrayList;

public class Principal {
	public static void main(String[] args) {
		ArrayList<Parque> arr = new ArrayList<Parque>();
		
		Principal.crea(arr);
		
		for (int i = 0; i < arr.size(); i++) {
			
				Principal.muestra(arr.get(i));
		}
		Parque paq = Principal.entradaMasCara(arr);
		System.out.println("\nLa entrada mas cara es la del parque:");
		Principal.muestra(paq);
		
		System.out.println("\nORDENO");
		Principal.ordena(arr);
		for (int i = 0; i < arr.size(); i++) {
			Principal.muestra(arr.get(i));
		}
		
		System.out.println("\nBARAJO");
		Principal.baraja(arr);
		for (int i = 0; i < arr.size(); i++) {
			Principal.muestra(arr.get(i));
		}
		
		String busca = "Dragon Khan";
		System.out.println("\nEstoy buscando Dragon Khan:");
		paq = Principal.buscaRecursivo(arr, busca, 0);
		Principal.muestra(paq);
		
		busca = "XXXX";
		System.out.println("\nEstoy buscando XXXX:");
		paq = Principal.buscaRecursivo(arr, busca, 0);
		Principal.muestra(paq);
	}
	
	public static void crea(ArrayList<Parque> arr) {
		
	     Atraccion a = new Atraccion();
	     a.nombre = "Terra Mitica";
	     a.ciudad = "Benidorm";
	     a.precio_entrada = 99.5;
	     a.setNombre_atraccion("La furia del Triton");
	     arr.add(a);

	     Espectaculo e = new Espectaculo();
	     e.nombre = "Warner Bros";
	     e.ciudad = "Madrid";
	     e.precio_entrada = 150.30;
	     e.setNombre_espectaculo("El Mago de Oz");
	     arr.add(e);
	            
	     MontanaRusa m = new MontanaRusa();
	     m.nombre = "Port Aventura";
	     m.ciudad = "Salou";
	     m.precio_entrada = 75.80;
	     m.setNombre_montana("Dragon Khan");
	     arr.add(m);
	        	        
	}
	
	public static void muestra(Parque paq) {
		if (paq == null) {
			System.out.println("No se ha podido encontrar");
		}
		else {
			if (paq instanceof Espectaculo) {
				Espectaculo aux = (Espectaculo) paq;
				System.out.println(aux.show());
				System.out.println(aux.funcionamiento());
			}
			if (paq instanceof Atraccion) {
				Atraccion aux = (Atraccion) paq;
				System.out.println(aux.show());
				System.out.println(aux.funcionamiento());
			}
			if (paq instanceof MontanaRusa) {
				MontanaRusa aux = (MontanaRusa) paq;
				System.out.println(aux.show());
				System.out.println(aux.funcionamiento());
			}
		}
	}
	
	public static Parque entradaMasCara(ArrayList<Parque> arr) {
		 double caro = arr.get(0).precio_entrada;
	        int posi = 0;
	        for (int i = 0; i < arr.size(); i++) {
	            if(arr.get(i).precio_entrada >= caro) {
	                caro = arr.get(i).precio_entrada;
	                posi = i;
	            }
	        }

	        return arr.get(posi);
		
	}
	
	public static void ordena(ArrayList<Parque> arr) {
		
		Parque aux = null;
		for(int i = 0; i < arr.size(); i++) {
			for(int j = i; j < arr.size() - 1; j++) {
				if(arr.get(i).precio_entrada > arr.get(j + 1).precio_entrada){
					aux = arr.get(i);
					arr.set(i, arr.get(j + 1));
					arr.set(j + 1, aux);

				}
			}
		}
	}
	
	public static void baraja(ArrayList<Parque> arr) {
	    for (int i = arr.size()- 1; i > 0; i--)
	    {
	      int index = (int)(Math.random()* arr.size());
	      
	      Parque aux = arr.get(index);
	      arr.set(index, arr.get(i));
	      arr.set(i, aux);
	    }
	}
	
	public static Parque buscaRecursivo(ArrayList<Parque> arr, String name, int i) {
	//El metodo encuentra siempre y cuando no este en la ultima posicion el string name
		Parque paq = null;
		if(arr.get(i) instanceof Atraccion) {
			Atraccion a = (Atraccion) arr.get(i);
			if((i == arr.size()-1) || a.getNombre_atraccion().equals(name)) {
				if(i == arr.size()-1) {					
					return null;
				}else {
					paq = arr.get(i);
					return paq;
				}
			}else {
				return buscaRecursivo(arr, name, i + 1);
			}
		}else if(arr.get(i) instanceof Espectaculo) {
			Espectaculo e = (Espectaculo) arr.get(i);
			if((i == arr.size()-1) || e.getNombre_espectaculo().equals(name)) {
				if(i == arr.size()-1) {
					
					return null;
				}else {
					paq = arr.get(i);
					return paq;
				}
			}else {
				return buscaRecursivo(arr, name, i + 1);
			}
		}else if(arr.get(i) instanceof MontanaRusa) {
			MontanaRusa m = (MontanaRusa) arr.get(i);
			if((i == arr.size()-1) || m.getNombre_montana().equals(name)) {
				if(i == arr.size()-1) {
					return null;
				}else {
					paq = arr.get(i);
					return paq;
				}
			}else {
				return buscaRecursivo(arr, name, i + 1);
			}
		}
		
		return paq;
		
	}
}
