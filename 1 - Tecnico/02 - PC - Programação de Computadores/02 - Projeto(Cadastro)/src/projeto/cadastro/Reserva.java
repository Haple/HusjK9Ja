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
public class Reserva {
    private String nome;
    private String cpf;
    private String titulo;
    
    
     //MÉTODO: NOVO CLIENTE
    //FUNÇÃO: CADASTRA NOVO CLIENTE
    //PARÂMETROS: NOME, CPF E TÍTULO
    public void novoReserva(String nome_cliente, String cpf_cliente, String titulo_livro) {
        nome = nome_cliente;
        cpf = cpf_cliente;
        titulo = titulo_livro;

        

        try {
            BufferedWriter bw = new BufferedWriter(new FileWriter(".\\Cadastro reserva.txt", true));
            bw.write(nome + ":");
            bw.write(cpf + ":");
            bw.write(titulo);
            bw.newLine();
            bw.flush();
            bw.close();
            JOptionPane.showMessageDialog(null, "Reserva concluída");
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "Falha na reserva");
        }

    }
}
