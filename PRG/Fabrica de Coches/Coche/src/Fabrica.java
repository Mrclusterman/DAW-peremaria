import javax.swing.JOptionPane;
public class Fabrica{
	public static void main(String[] args) {
		int op;
		Coche[] arr = new Coche[4];
		
		do{
			op = Integer.parseInt(JOptionPane.showInputDialog("Fabrica de Coches de Gabriel Miralles. Seleciona una de las siguientes opciones:"+
				"\n1.Fabricar coche (conociendo matricula)"+
				"\n2.Fabricar coche (a partir del numero de puertas y el numero de plazas)"+
				"\n3.Fabricar coche (a partir de la marca, el modelo y el color)"+
				"\n4.Fabricar coche"+
				"\n5.Tunear coche (pintandolo de un color)"+
				"\n6.Tunear coche (sin pintarlo)"+
				"\n7.Avanzar kilometros"+
				"\n8.Mostrar caracteristicas de un coche"+
				"\n9.Salir del programa"));

		
			switch (op){
               
				case 1:
					String matriculaux = (JOptionPane.showInputDialog(null, "Introduza la matricula.", "Introduzca los datos.", 3));
					Coche a = new Coche(matriculaux);
					Fabrica.añadirCoche(arr, a);
					
				break;

				case 2:
					int puertasux = Integer.parseInt(JOptionPane.showInputDialog(null, "Introduza el numero de puertas.", "Introduzca los datos.", 3));
					int plazasux = Integer.parseInt(JOptionPane.showInputDialog(null, "Introduza el numero de plazas.", "Introduzca los datos.", 3));
					Coche a1 = new Coche(puertasux, plazasux);
					a1.setMatricula(Fabrica.matAleatoria());
					Fabrica.añadirCoche(arr, a1);
					
				break;

				case 3:
					String marcaux = (JOptionPane.showInputDialog(null, "Introduza la marca.", "Introduzca los datos.", 3));
					String modeloux = (JOptionPane.showInputDialog(null, "Introduza el modelo.", "Introduzca los datos.", 3));
					String colorux = (JOptionPane.showInputDialog(null, "Introduza el color.", "Introduzca los datos.", 3));
					Coche a2 = new Coche(marcaux, modeloux, colorux);
					a2.setMatricula(Fabrica.matAleatoria());
					Fabrica.añadirCoche(arr, a2);
					
				break;

				case 4:
					Coche a3 = new Coche();
					a3.setMatricula(Fabrica.matAleatoria());
					Fabrica.añadirCoche(arr, a3);
					
				break;

				case 5:
					String texto = "";
					for(int i = 0; i< arr.length; i++) {
						if (arr[i]!= null) {
							texto = texto + i + ".- "+ arr[i].getMatricula() + "\n";
						}
					}

					int puntero =Integer.parseInt((JOptionPane.showInputDialog(null, texto, "Seleccione el coche que quiere ver.", 3)));
					String coloraux = ( JOptionPane.showInputDialog(null, "Escriba el color de su coche", "Inserte los datos", 3));
					arr[puntero].tunear(coloraux);
					JOptionPane.showMessageDialog(null, "El color de su coche es ahora: " + arr[puntero].getColor(),"COLOR", 3);
				break;

				case 6:
					String texto1 = "";
					for(int i = 0; i< arr.length; i++) {
					if (arr[i]!= null) {
					texto1 = texto1 + i + ".- "+ arr[i].getMatricula() + "\n";
					}
					}
					int puntero1 =Integer.parseInt((JOptionPane.showInputDialog(null, texto1, "Seleccione el coche que quiere ver.", 3)));
					arr[puntero1].tunear();
					
				break;

				case 7: 
					String texto2 = "";
					for(int i = 0; i< arr.length; i++) {
					if (arr[i]!= null) {
					texto2 = texto2 + i + ".- "+ arr[i].getMatricula() + "\n";
					}
					}
					int puntero2 =Integer.parseInt((JOptionPane.showInputDialog(null, texto2, "Seleccione el coche que quiere ver.", 3)));
					String kilometros;
					arr[puntero2].avanzar(Integer.parseInt(kilometros = ( JOptionPane.showInputDialog(null, "Escriba el numero de Kilometros a avanzar", "Inserte los datos", 3))));
					JOptionPane.showMessageDialog(null, "El numero avanzado de kilometros es: " + arr[puntero2].getKilometros(), "KILOMETROS", 3);
				break;

				case 8: 
					Fabrica.caracteristicas(arr);
				break;
			}
		}while(op != 9);

	
	}

	public static void caracteristicas(Coche[] arr){
		String techo;
		
		String texto1 = "";
		for(int i = 0; i< arr.length; i++) {
			if (arr[i]!= null) {
				texto1 = texto1 + i + ".- "+ arr[i].getMatricula() + "\n";
			}
		}
		int puntero1 =Integer.parseInt((JOptionPane.showInputDialog(null, texto1, "Seleccione el coche que quiere ver.", 3)));
		if(arr[puntero1].getTechoSolar()==true){
			techo="Si";
		}else{
			techo="No";
		}

		JOptionPane.showMessageDialog(null, "Datos del coche: \n Matricula: "+arr[puntero1].getMatricula()+
		"\nMarca: "+arr[puntero1].getMarca()+"\nModelo: "+arr[puntero1].getModelo()+"\nColor: "+arr[puntero1].getColor()+
		"\nTecho Solar: "+techo+"\nKilometros: "+arr[puntero1].getKilometros()+"\nNumero de puertas: "+
		arr[puntero1].getNumPuertas()+"\nNumero de Plazas: "+arr[puntero1].getNumPlazas());

		}
	
    public static String matAleatoria(){
      int matricula = (int)(Math.random() * ((99999 - 0) + 1));
      String matString = matricula + "";
      if(matString.length() < 5){
        for(int i = matString.length(); i <= 5; i++){
            matString = "0" + matString;
        }
	  }
	  
      return matString;
        
	}

	public static void añadirCoche(Coche[] arr, Coche a) {
		int index = -1;
		if (arr[3] == null) {
			for(int i = arr.length - 1; i>=0; i--) {
				if (arr[i] == null) {
					index = i;
				}
			}
			if (index != -1) {
				arr[index] = a;
			}
		} else {
			JOptionPane.showMessageDialog(null, "No se pueden crear mas coches.");
		}
	}
	
}