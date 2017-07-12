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
public class Cliente {
    private String nome;
    private String cpf;
    private String nascimento;
    private String telefone;
    private String endereco;
    
    
    //MÉTODO: NOVO CLIENTE
    //FUNÇÃO: CADASTRA NOVO CLIENTE
    //PARÂMETROS: NOME, CPF, NASCIMENTO, TELEFONE E ENDEREÇO
    public void novoCliente(String nome_cliente, String cpf_cliente, String nascimento_cliente, String telefone_cliente, String endereco_cliente) {
        nome = nome_cliente;
        cpf = cpf_cliente;
        nascimento = nascimento_cliente;
        telefone = telefone_cliente;
        endereco = endereco_cliente;
        

        try {
            BufferedWriter bw = new BufferedWriter(new FileWriter(".\\Cadastro cliente.txt", true));
            bw.write(nome + ":");
            bw.write(cpf + ":");
            bw.write(nascimento + ":");
            bw.write(telefone + ":");
            bw.write(endereco);
            bw.newLine();
            bw.flush();
            bw.close();
            JOptionPane.showMessageDialog(null, "Novo cliente cadastrado");
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "Falha no cadastro");
        }

    }
    
}
