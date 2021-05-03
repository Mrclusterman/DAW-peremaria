import java.util.Date;

public class Compania {
	private String nombre;
	private Date ano;

	public Compania(String nombre, Date ano){
		this.nombre = nombre;
		this.ano = ano;
		
	}

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public Date getAno() {
		return ano;
	}

	public void setAno(Date ano) {
		this.ano = ano;
	}
	
	
	
}
