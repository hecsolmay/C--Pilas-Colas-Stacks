package Listas;

import Libreria.Users;
import java.util.LinkedList;

/**
 *
 * @author Hector
 */
public class UserList extends LinkedList {

    public void mostrar() {
        for (int i = 0; i < size(); i++) {
            ((Users) get(i)).mostrar();
        }
    }
}
