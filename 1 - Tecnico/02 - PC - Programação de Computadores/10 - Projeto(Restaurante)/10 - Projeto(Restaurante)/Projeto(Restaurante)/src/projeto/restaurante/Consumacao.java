/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package projeto.restaurante;

import java.sql.*;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import javax.swing.JOptionPane;

/**
 *
 * @author i14505i
 */
public class Consumacao {
    
     public  Consumacao(String nro_mesa, String produto, String valor, String quantidade) {

        try {
            //Driver
            Class.forName("com.mysql.jdbc.Driver");
            //Conexão
            //Connection c = (Connection) DriverManager.getConnection("jdbc:mysql://localhost:3306/projeto_restaurante", "root", "");
            Connection c = (Connection) DriverManager.getConnection("jdbc:mysql://localhost:3306/projeto_restaurante", "root", "");	
            


            //SQL
            PreparedStatement comando = (PreparedStatement)
                    c.prepareStatement("INSERT INTO CONSUMACAO (NRO_MESA, PRODUTO, VALOR, QUANTIDADE, TOTAL) VALUES (?, ?, ?, ?, ?)");
            //Número da mesa
            comando.setString(1, nro_mesa);
            //Produto
            comando.setString(2, produto);
            //Valor do produto
            comando.setString(3, valor);
            //Quantidade de produtos
            comando.setString(4, quantidade);
            
            //Cálculo do total do pedido
            double total = (Double.valueOf(valor) * Double.valueOf(quantidade));
            //Total do pedido
            comando.setString(5, "" + total);
            //Executa comando SQL
            comando.execute();
            //Fecha conexão
            c.close();
            //Confirmação de sucesso
            JOptionPane.showMessageDialog(null, "ITEM ADICIONADO");
            
        } catch (Exception e) {
            //Mensagem de erro
            JOptionPane.showMessageDialog(null, "ERRO AO BUSCAR!!\n" + e);
        }

   
    }
     
     public void excluirRegistro(String nro_item){
         try {
            
            //Driver
            Class.forName("com.mysql.jdbc.Driver");
            
            //Conexão
            Connection c = (Connection) DriverManager.getConnection("jdbc:mysql://localhost:3306/projeto_restaurante", "root", "");
           
            //SQL
            PreparedStatement comando = (PreparedStatement) c.prepareStatement("DELETE FROM CONSUMACAO WHERE NRO_ITEM = ?");
           
            //Número da mesa
            comando.setString(1, nro_item);
            
            //Executa comando SQL
            comando.execute();
            
            //Fecha conexão
            c.close();
            
            //Confirmação de sucesso
            JOptionPane.showMessageDialog(null, "ITEM EXCLUÍDO.");
            
        } catch (Exception e) {
            
            //Mensagem de erro
            JOptionPane.showMessageDialog(null, "ERRO AO BUSCAR!\n" + e);
        }
     }

    
    
    
    
}
