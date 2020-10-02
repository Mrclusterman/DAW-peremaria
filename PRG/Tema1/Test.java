package prg;

public class Test {
	public static void main(String[] args) {
		int x = 0;
		int y = 0;
		while (x < 5) {
			
		
			if(y < 5) {
				x = x + 1;
				if(y < 3) {
					x = x + 1;
				}
			}
			y = y + 2;
			
			System.out.print(x + "" + y +" ");
			x = x + 1;
		}
	}
}
/**Resultados Práctica 6
*1-g
*2-h
*3-d
*4-b
*5-a
**/ 