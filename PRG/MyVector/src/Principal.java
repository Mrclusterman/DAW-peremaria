import java.util.Enumeration;
public class Principal {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		MyVector v1 = new MyVector(); // crea un array de arr[10] y crece 10 posiciones 
        MyVector v2 = new MyVector(5); // crea un array de arr[5] y crece 10 posiciones
        MyVector v3 = new MyVector(7,3); // crea un array de arr[5] y crece 3 posiciones

        if(v1.capacity() == 10) {
            System.out.println("capacity 10 OK");
        }

        if(v2.capacity() == 5) {
            System.out.println("capacity 5 OK");
        }

        if(v3.capacity() == 7) {
            System.out.println("capacity 7 OK");
        }

        for(int i=0;i<13;i++) {
            v1.add(i);
        }

        if(v1.size() == 13 && v1.capacity() == 20) {
            System.out.println("size 13 OK capacity 20 OK");
        }

        for(int i=0;i<9;i++) {
            v2.add(i);
        }
        if(v2.size() == 9 && v2.capacity() == 10) {
            System.out.println("size 9 OK capacity 10 OK");
                }


        for(int i=0;i<8;i++) {
            v3.add(i);
        }

        if(v3.size() == 8 && v3.capacity() == 10) {
            System.out.println("size 8 OK capacity 10 OK");
        }

        v3.remove(2);
        boolean correcto = true;

        for(int i=0;i<v3.size();i++) {
            if(((int)v3.elementAt(i)) == 2) {
               correcto = false;
            }
        }

        if(correcto) {
            System.out.println("Se ha eliminado el numero 2");
        }

        correcto = false;

       // Enumeration<?> lista = v3.elements();

        // while(lista.hasMoreElements()) {
        //     if(((int)lista.nextElement()) == 2) {
        //          correcto = true;
        //     }
        // }

        // if(correcto) {
        //     System.out.println("Se ha eliminado el numero 2 y he utilizado un Enumeration");
        // }

	}

}
