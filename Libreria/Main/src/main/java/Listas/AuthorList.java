package Listas;

import Libreria.Author;
import java.util.LinkedList;

/**
 *
 * @author Hector
 */
public class AuthorList extends LinkedList {

    public void mostrar() {
        for (int i = 0; i < size(); i++) {
            ((Author) get(i)).mostrar();
        }
    }
}
