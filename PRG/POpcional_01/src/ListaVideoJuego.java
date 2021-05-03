import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;



public class ListaVideoJuego {
    
    public static void main (String[] args)throws IOException, ParseException{
       
       ArrayList<VideoJuego> arr = new ArrayList<VideoJuego>();
       BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

       ListaVideoJuego.insertaVideoJuego(arr, br);
        
       int posi = ListaVideoJuego.RecursivoMasCaro(arr, 0, 0, arr.get(0).getPrecio());
       
       ListaVideoJuego.muestra(arr,posi);
       System.out.println("Dame titulo del videojuego: ");
       String tit= br.readLine();
       
       posi = ListaVideoJuego.RecursivoBuscaPorNombre(arr,0, tit);
       
       if (posi == -1) {
    	   System.out.println("No se ha encontrado ese videojuego");
    	   
       }else {
    	   System.out.println("Su videojuego se ha encontrado en la posicion: " + posi);
       }
    }

    public static void insertaVideoJuego(ArrayList<VideoJuego> arr, BufferedReader br) throws IOException, ParseException {
        String titulo;
        String genero;
        double precio;
        for (int i = 0; i < 3; i++) {
            System.out.print("Dame un titulo: ");
            titulo = br.readLine();
            System.out.print("Dame un genero: ");
            genero = br.readLine();
            System.out.print("El precio es: ");
            precio = Math.random() * (500 - 1) + 1;
            System.out.println(precio);
            
            SimpleDateFormat df = new SimpleDateFormat("dd-MM-YYYY");

            Compania comp = new Compania("Blizzard", df.parse("01-01-1990"));

            VideoJuego vi = new VideoJuego(titulo, genero, precio, comp);

            vi.setComp(comp);
            
            arr.add(vi);
        
        }

    }

    public static int masCaro(ArrayList<VideoJuego> arr) {

        double caro = arr.get(0).getPrecio();
        int posi = 0;
        for (int i = 0; i < arr.size(); i++) {
            if(arr.get(i).getPrecio() >= caro) {
                caro = arr.get(i).getPrecio();
                posi = i;
            }
        }

        return posi;
    }

    public static int RecursivoMasCaro(ArrayList<VideoJuego> arr, int i, int posi, double caro) {

        if (i == arr.size()) {
            return posi;
        }else {
            if (arr.get(i).getPrecio() >= caro) {
                caro = arr.get(i).getPrecio();
                posi = i;
            }
            return 0 + RecursivoMasCaro(arr, i + 1, posi, caro);
        }
    }

    public static void ordena(ArrayList<VideoJuego> arr) {
        VideoJuego aux = null;
        for (int i = 0; i < arr.size(); i++) {
            for (int j = i; i < arr.size() - 1; j++) {
                if(arr.get(i).getPrecio() > arr.get(j + 1).getPrecio()){
                    aux = arr.get(i);
                    arr.set(i, arr.get(j + 1));
                    arr.set(j + 1, aux);
                }
            }
        }
    }

    public static int BuscaPorNombre(ArrayList<VideoJuego> arr, String nombre) {
        int i = 0;
        while((i != arr.size() - 1) || (!(arr.get(i).getTitulo().equals(nombre)))) {
            i++;
        }
        
        if(i == arr.size() - 1 ) {
            if (arr.get(i).getTitulo().equals(nombre)) {
                return i;
            }else {
                return -1;
            }
           
        }else{
            return i;
        } 
    }
    public static int RecursivoBuscaPorNombre(ArrayList<VideoJuego> arr, int i, String nombre) {
        if ( i == arr.size() || (arr.get(i).getTitulo().equals(nombre)) ) {
            if(i == arr.size()) {
                return -1;
            }else{
                return i;
            }           
        }else {
            return RecursivoBuscaPorNombre(arr, i + 1, nombre);
        }
    }

    public static void muestra(ArrayList<VideoJuego> arr, int posi){
        System.out.println("El mas caro se llama " + arr.get(posi).getTitulo() + " y vale " + arr.get(posi).getPrecio());
    }

    public static void muestraCaroBarato(ArrayList<VideoJuego> arr) {
        System.out.println("El mas barato se llama " + arr.get(0).getTitulo() + " y vale " + arr.get(0).getPrecio());
        System.out.println("El mas caro se llama " + arr.get(arr.size()-1).getTitulo() + " y vale " + arr.get(arr.size()-1).getPrecio());
    }
}
