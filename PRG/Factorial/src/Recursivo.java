import java.lang.Math;
public class Recursivo {
    public static void main(String[] args) throws Exception {
      
        int[] num = new int[10];
        int posi = 0;
        for(int i = 0; i < 10; i++){
            num[posi] = (int) Math.floor(Math.random() * (100 - 1 + 1) + 1);

            System.out.println(Integer.toString(num[posi]) + ',');
            posi++;
        }
        System.out.println();
        for(int i = 0; i < num.length; i++ ){
            System.out.print(num[i] + ",");
        }
        System.out.println();
        ordenarRecursivo(num, 0, 0);
        for(int i = 0; i < num.length; i++ ){
            System.out.print(num[i] + ",");
        }
    }

    public static int factorialRecursivo(int numero) {
        if (numero < 0) {
            return 0;
        } else {
            if(numero == 0) {
                return 1;
            } else {
                return numero *factorialRecursivo(numero - 1);
            }
            
        }
        
    }

    public static int sumaNumero(int numero) {
        if (numero == 1){
            return 1;
        } else {
            return numero + sumaNumero(numero - 1);
        }

    }
    public static int[] ordenar(int[] numeros) {

        int i, j, aux;
        for (i = 0; i < numeros.length - 1; i++) {
            for (j = i; j < numeros.length - 1; j++) {
                if ( numeros[i] > numeros[j + 1]) {
                    aux = numeros[j + 1];
                    numeros[j + 1] = numeros[i];
                    numeros[i] = aux;

                    System.out.println("cambio " + Integer.toString(numeros[j+1]) + " por " + Integer.toString(numeros[i]));
                }

            }

            for(int t=0;t<numeros.length;t++) {

                System.out.print(Integer.toString(numeros[t])+',');
            }
            System.out.println();
        }

        return numeros;

    }
    public static int[] ordenarRecursivo(int[] numeros, int i, int j) {
        int aux;
        if(i == numeros.length - 1){
            return numeros;
        }
        else{
            if ( numeros[i] > numeros[j + 1]) {
                aux = numeros[j + 1];
                numeros[j + 1] = numeros[i];
                numeros[i] = aux;
            }
            if(j < numeros.length - 2){
                return ordenarRecursivo(numeros, i , j + 1);
            } else{
                return ordenarRecursivo(numeros, i + 1, i + 1);
            }
            
        }
    }
}
