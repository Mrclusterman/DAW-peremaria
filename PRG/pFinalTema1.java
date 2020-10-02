package prg;

public class pFinalTema1 {
	public static void main(String[] args) {
		System.out.println("Primeros 25 enteros:");
		int num = 1;
		while(num < 25) {
			System.out.print(num + "," );
			num++;
			
		}
		System.out.println(num);
		System.out.println("Los primeros pares hasta el 50: ");
		int num1 = 2;
		while(num1 < 50) {
			System.out.print(num1 + "," );
			num1= num1 + 2;
		}
		System.out.println(num1);
		
		System.out.println("Los primeros impares hasta el 49: ");
		int num2 = 1;
		while(num2 < 49) {
			System.out.print(num2 + "," );
			num2= num2 + 2;
		}
		System.out.println(num2);
		
		int num3 = 1;
		
		while(num3 <= 10) {
			System.out.println("Tabla de multiplicar del " + num3 +":");
			int num4 = 1;	
			while(num4 <= 10) {
				int result = num3 * num4;
				System.out.println(num3 + "*" + num4 + "=" + result);
				num4++;
			}
			num3++;
		}
	}
}
