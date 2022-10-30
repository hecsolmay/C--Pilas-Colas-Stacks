package Libreria;

import Listas.BookList;

/**
 *
 * @author Hector
 */
public class Author {

    public String nombre;
    public BookList books = new BookList();

    public boolean equals(Object nodo) {
        return nombre.equals(((Author) (nodo)).nombre);
    }
    
    public void mostrar()
    {
        System.out.println(nombre);
        books.mostrar();
    }
}
