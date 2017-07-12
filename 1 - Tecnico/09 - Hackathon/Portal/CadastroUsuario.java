
package example;

import java.io.BufferedWriter;
import java.io.FileWriter;
import javax.swing.JOptionPane;

public class CadastroUsuario {

    String nome;
    String senha; 	
    String rg;
    String telefone;
    String email;
    
    
    public void novoUsuario(String nomeUsuario, String senhaUsuario, String rgUsuario, String telefoneUsuario, String emailUsuario) {

        nome = nomeUsuario;
        rg = rgUsuario;
        senha = senhaUsuario;
        telefone = telefoneUsuario;
        endereco = enderecoUsuario;
        
        try {
            BufferedWriter bw = new BufferedWriter(new FileWriter(".\\Cadastro cliente.txt", true));
            bw.write(nome + ":");
            bw.write(senha + ":");
            bw.write(rg + ":");
            bw.write(telefone + ":");
            bw.write(email);
            bw.newLine();
            bw.flush();
            bw.close();
            
        } catch (Exception e) {
            
        }

    }
    
}
