
package Listas;

import java.util.LinkedList;

/**
 *
 * @author Hector
 */
public class BookList extends LinkedList {
    
    public void mostrar()
    {
        for (int i = 0; i < size(); i++) {
            System.out.println(get(i));
        }
    }
    
}
