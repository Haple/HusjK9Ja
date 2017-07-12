/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package projeto.cadastro;

import java.io.BufferedWriter;
import java.io.FileWriter;
import javax.swing.JOptionPane;

/**
 *
 * @author i14505i
 */
public class Livro {
    private String titulo;
    private String isbn;
    private String preco;
    private String genero;
    
    
     //MÉTODO: NOVO LIVRO
    //FUNÇÃO: CADASTRA NOVO LIVRO
    //PARÂMETROS: TÍTULO, ISBN, PREÇO E GÊNERO
    public void novoLivro(String titulo_livro, String isbn_livro, String preco_livro, String genero_livro) {
        titulo = titulo_livro;
        isbn = isbn_livro;
        preco = preco_livro;
        genero = genero_livro;
        

        try {
            BufferedWriter bw = new BufferedWriter(new FileWriter(".\\Cadastro livro.txt", true));
            bw.write(titulo + ":");
            bw.write(isbn + ":");
            bw.write(preco + ":");
            bw.write(genero);
            bw.newLine();
            bw.flush();
            bw.close();
            JOptionPane.showMessageDialog(null, "Novo livro cadastrado");
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "Falha no cadastro");
        }

    }
    
}
