package main;

import Listas.AuthorList;
import GUI.Libreria;

/**
 *
 * @author Hector
 */
public class Main {

    public static void main(String[] args) {
        System.out.println("Libreria!");
        AuthorList listaAutor = new AuthorList();

        int limite = (int) 'Z' + 1;

        System.out.println(limite);
        
        Libreria libreria = new Libreria();
        
        libreria.Program();

    }
}
