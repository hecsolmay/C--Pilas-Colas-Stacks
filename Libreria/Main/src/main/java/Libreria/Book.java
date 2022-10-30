package Libreria;

/**
 *
 * @author Hector
 */
public class Book {

    public String title;
    public Users prestado = null;

    public boolean equals(Object node) {
        return title.equals(((Book) node).title);
    }

    public String toString() {
        String word = "     *" + title;

        if (prestado != null) {
            word += "   - Prestado a: " + prestado.name;
        }
        return word;
    }
}
