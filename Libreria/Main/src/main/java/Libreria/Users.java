package Libreria;

import Listas.BookList;

/**
 *
 * @author Hector
 */
public class Users {

    public String name;
    public BookList libros = new BookList();

    public boolean equals(Object nodo) {
        return name.equals(((Users) nodo).name);
    }

    public void mostrar() {
        if (libros.isEmpty()) {
            System.out.println(name + "  No tiene libros");
        } else {
            System.out.println(name + "  tiene los siguientes libros: ");
            libros.mostrar();
        }
    }
}
