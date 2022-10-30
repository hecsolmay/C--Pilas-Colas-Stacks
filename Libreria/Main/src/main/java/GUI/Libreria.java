package GUI;

import Listas.AuthorList;
import Listas.UserList;
import java.util.Scanner;
import Libreria.Author;
import Libreria.Book;
import Libreria.Users;
import Libreria.CheckOutBook;

/**
 *
 * @author Hector
 */
public class Libreria {

    int size = (int) 'Z' + 1;
    AuthorList[] catalogo = new AuthorList[size];
    UserList[] personas = new UserList[size];
    Scanner sc = new Scanner(System.in);

    public Libreria() {
        for (int i = 0; i < catalogo.length; i++) {
            catalogo[i] = new AuthorList();
            personas[i] = new UserList();

        }

        // Prueba de Libros por defecto
        Author autor = new Author();
        Book libro = new Book();
        autor.nombre = "Stephen";
        libro.title = "It";

        // generamos el numero de pocision de la palabra con ansi
        int indexCatalogo = (int) autor.nombre.charAt(0);
        autor.books.add(libro);
        catalogo[indexCatalogo].add(autor);
    }

    public String getString(String text) {
        System.out.print(text + ": ");
        String r = sc.next();
        return r.substring(0, 1).toUpperCase() + r.substring(1);
    }

    public void Program() {

        boolean cerrar = false;

        while (!cerrar) {

            System.out.println(" - - - - - - - - - Escoge Tus Opciones - - - - - - - - - \n");
            System.out.println("1.- Añadir Libro");
            System.out.println("2.- Prestar Libro");
            System.out.println("3.- Regresar Libro");
            System.out.println("4.- Mostrar el estatus");
            System.out.println("5.- Cerrar el programa\n");

            System.out.print("Tu Opcion: ");
            int opcion = sc.nextInt();

            switch (opcion) {
                case 1:
                    AgregarLibro();
                    break;
                case 2:
                    PrestarLibro();
                    break;
                case 3:
                    RegresarLibro();
                    break;
                case 4:
                    MostrarEstatus();
                    break;
                case 5:
                    // cerrar el programa
                    cerrar = true;
                    break;
                default:
                    System.out.println("Opcion no valida");
                    break;
            }
        }

    }

    public void AgregarLibro() {
        Author autor = new Author();
        Book libro = new Book();
        autor.nombre = getString("Dame el nombre del autor");
        libro.title = getString("Dame el nombre del libro");

        // generamos el numero de pocision de la palabra con ansi
        int indexCatalogo = (int) autor.nombre.charAt(0);

        //Buscamos al autor si ya existe
        int indexAutor = catalogo[indexCatalogo].indexOf(autor);

        // Nos devuelve -1 si el usuario no se encuentra en el catalogo
        if (indexAutor == -1) {
            System.out.println("Autor Nuevo");
            autor.books.add(libro);
            catalogo[indexCatalogo].add(autor);

        } else {
            //En caso de que si exista lo vamos a obtener por medio del indice que nos dio antes
            System.out.println("Ya existe el autor");
            Author autorExistente = (Author) catalogo[indexCatalogo].get(indexAutor);
            autorExistente.books.add(libro);
        }

    }

    public void PrestarLibro() {
        Users usuario = new Users();
        Users usuarioBuscado; // Este sirve para guardar al usuario existente en las personas
        Author autor = new Author();
        Author autorBuscado; // Este sirve para almacenar el autor que existe en el catalogo
        Book libro = new Book();
        int indexAutor = -1;
        int indexUsuario;
        int indexLibro = -1;

        usuario.name = getString("Dame el nombre del usuario");

        do {
            autor.nombre = getString("Dame el nombre del autor");
            int indexCatalogoAutor = (int) autor.nombre.charAt(0);

            indexAutor = catalogo[indexCatalogoAutor].indexOf(autor);
            System.out.println(indexAutor);
            if (indexAutor == -1) {
                System.out.println("El autor que pusiste no existe, intentalo de nuevo");
            }
        } while (indexAutor == -1);

        do {
            libro.title = getString("Dame el nombre del libro");
            int indexCatalogoAutor = (int) autor.nombre.charAt(0);

            autorBuscado = (Author) catalogo[indexCatalogoAutor].get(indexAutor);

            indexLibro = autorBuscado.books.indexOf(libro);

            if (indexLibro == -1) {
                System.out.println("El libro escrito no existe intentalo de nuevo");
            }
        } while (indexLibro == -1);

        Book libroBuscado = (Book) autorBuscado.books.get(indexLibro);

        CheckOutBook libroPrestado = new CheckOutBook();
        libroPrestado.autor = autorBuscado;
        libroPrestado.libro = libroBuscado;

        int indexPersona = (int) usuario.name.charAt(0);

        indexUsuario = personas[indexPersona].indexOf(usuario);

        if (indexUsuario == -1) {
            usuario.libros.add(libroPrestado);
            personas[indexPersona].add(usuario);
            indexUsuario = personas[indexPersona].indexOf(usuario);
            libroBuscado.prestado = (Users) personas[indexPersona].get(indexUsuario);
        } else {
            usuarioBuscado = (Users) personas[indexPersona].get(indexUsuario);
            usuarioBuscado.libros.add(libroPrestado);
            libroBuscado.prestado = usuarioBuscado;
        }
    }

    public void RegresarLibro() {
        Users usuario = new Users();
        Author autorBuscado = new Author();
        Author autor = new Author();
        Book libro = new Book();
        CheckOutBook libroPrestado = new CheckOutBook();

        int indexAutor = -1;
        int indexUsuario = -1;
        int indexLibro = -1;
        int indexCatalogo = -1;
        int indexPersona = -1;

        // Inicia Buscando al usuario que desea regresar el libro
        do {

            usuario.name = getString("Dame el nombre del usuario");
            indexPersona = (int) usuario.name.charAt(0);
            indexUsuario = personas[indexPersona].indexOf(usuario);

            if (indexUsuario == -1) {
                System.out.println("El usuario No existe intentalo de nuevo");
            }

        } while (indexUsuario == -1);

        // Le pedimos que ingrese el nombre del libro que desea devolver
        do {

            autor.nombre = getString("Dame el nombre del autor");
            indexCatalogo = (int) autor.nombre.charAt(0);
            indexAutor = catalogo[indexCatalogo].indexOf(autor);

        } while (indexAutor == -1);

        // Le pedimos que nos proporcione el nombre del libro que desea devolver
        do {
            libro.title = getString("Dame el nombre del libro");
            autorBuscado = (Author) catalogo[indexCatalogo].get(indexAutor);
            indexLibro = autorBuscado.books.indexOf(libro);

            if (indexLibro == -1) {
                System.out.println("El nombre del libro no es el correcto intentalo de nuevo");
            }

        } while (indexLibro == -1);

        libroPrestado.autor = autorBuscado;
        libroPrestado.libro = (Book) autorBuscado.books.get(indexLibro);
        ((Book) autorBuscado.books.get(indexLibro)).prestado = null;
        ((Users) personas[indexPersona].get(indexUsuario)).libros.remove(libroPrestado);
    }

    public void MostrarEstatus() {
        
        System.out.println("\nLa libreria cuenta con los siguientes libros\n\n");
        for (int i = 0; i < size; i++) {
            if (!catalogo[i].isEmpty()) {
                catalogo[i].mostrar();
            }
        }
        
        System.out.println("\nLos usuarios de la libreria son los siguientes\n");
        for (int i = 0; i < size; i++) {
            if (!personas[i].isEmpty()) {
                personas[i].mostrar();
            }
        }

    }

    public void mostrarLibros() {
        for (int i = 0; i < size; i++) {
            if (!catalogo[i].isEmpty()) {
                var autor = (Author) catalogo[i].get(0);
                System.out.println(autor.nombre);

            }
        }
    }

}
