import java.util.Enumeration;

public interface Vec {
	
	public void add(Object o);
	public int size();
	public int capacity();
	public void remove(int posi);
	public Object elementAt(int posi);
	public void insertElementAt(Object o, int posicion);
	public Enumeration elements();

}
