package Libreria;

/**
 *
 * @author Hector
 */
public class CheckOutBook {

    public Author autor = null;
    public Book libro = null;

    public boolean equals(Object nodo) {

        return autor.nombre.equals(((CheckOutBook) nodo).autor.nombre) && libro.title.equals(((CheckOutBook) nodo).libro.title);
    }

    public String toString() {
        return "    *  " + autor.nombre + " , " + libro.title;
    }
}
