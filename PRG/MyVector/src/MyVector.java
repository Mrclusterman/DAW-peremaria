import java.util.Enumeration;

public class MyVector implements Vec {

	Object[] arr;
	int puntero = 0;
	int capacidad = 0;
	int crecimiento = 0;
	
	public MyVector() {
		this.arr = new Object[10];
		this.capacidad = 10;
		this.crecimiento= 10;
	}
	
	public MyVector(int posiciones) {
			this.arr = new Object[posiciones];
			this.capacidad = posiciones;
			this.crecimiento = posiciones; 
	}
	
	public MyVector(int posiciones, int crecimiento) {
		this.arr = new Object[posiciones];
		this.capacidad = posiciones;
		this.crecimiento = crecimiento;
	}
	
	@Override
	public void add(Object c) {
		// TODO Auto-generated method stub
		if(this.puntero == this.capacidad) {
			Object aux[] = new Object[capacidad];
			for(int i = 0; i < this.arr.length; i++) {
				aux[i] = this.arr[i];
			}

			this.arr = new Object[this.capacidad + this.crecimiento];

			for(int i = 0; i < this.capacidad; i++) {
				this.arr[i] = aux[i];
			}

			this.arr[this.puntero] = c;
			this.puntero = this.puntero + 1;
			this.capacidad = this.capacidad + crecimiento;
		} else {
			this.arr[puntero] = c;
			this.puntero = this.puntero + 1;
		}
		
	}

	@Override
	public int size() {
		// TODO Auto-generated method stub
		return this.puntero;
	}

	@Override
	public int capacity() {
		// TODO Auto-generated method stub
		return this.capacidad;
	}

	@Override
	public void remove(int index) {
		// TODO Auto-generated method stub
		if (index == this.puntero - 1){
			this.arr[index] = null;	
		}
		else{
			for(int i = index; i < this.puntero - 1; i++){
				this.arr[index] = this.arr[index + 1];
			}	
			this.arr[this.puntero - 1] = null;
		}
		this.puntero = this.puntero - 1;
	}

	public void removeRecursivo(int index) {
		// TODO Auto-generated method stub
		if (index == this.puntero - 1){
			this.arr[index] = null;	
		}
		else{
			if(index < this.puntero - 1){
				this.arr[index] = this.arr[index + 1];
				removeRecursivo(index + 1);
			}
		}
		this.puntero = this.puntero - 1;
	}

	@Override
	public Object elementAt(int posi) {
		// TODO Auto-generated method stub
		return this.arr[posi];
	}

	@Override
	public void insertElementAt(Object o, int posicion) {
		// TODO Auto-generated method stub
		if(posicion <= this.puntero){
			this.arr[posicion] = o;
			if(posicion == this.puntero){
				this.puntero = this.puntero + 1;
			}
		}
		else{
			this.arr[this.puntero] = o;
			this.puntero = this.puntero + 1;
		}
		
	}
	@Override
	public Enumeration elements(){
		// TODO Auto-generated method stub
		return null;
	}
}
