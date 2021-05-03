
public class VideoJuego {
    private String titulo, genero;
    private double precio;
    private Compania comp;

    public VideoJuego(String titulo, String genero, double precio, Compania comp) {
        this.titulo = titulo;
        this.genero = genero;
        this.precio = precio;
        this.setComp(comp);
    }

    public Compania getComp() {
        return comp;
    }

    public void setComp(Compania comp) {
        this.comp = comp;
    }

    public String getTitulo() {
        return titulo;
    }

    public double getPrecio() {
        return precio;
    }

    public void setPrecio(double precio) {
        this.precio = precio;
    }

    public String getGenero() {
        return genero;
    }

    public void setGenero(String genero) {
        this.genero = genero;
    }

    public void setTitulo(String titulo) {
        this.titulo = titulo;
    }
}
