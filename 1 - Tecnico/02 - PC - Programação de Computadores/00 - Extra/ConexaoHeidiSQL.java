/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package financiamento;
import java.sql.*;
import javax.swing.JOptionPane;
/**
 *
 * @author unknow
 */
public class ConexaoHeidiSQL { 
   Connection con;
   Statement stmt;
   ResultSet rs;
   
   String url = "jdbc:mysql://localhost:3306/basededados";
   String user = "root";
   String password = "";
   String driver = "com.mysql.jdbc.Driver";
   
    public void openConectionMySql(){
        try{
            Class.forName(driver).newInstance();
            con = DriverManager.getConnection(url,user, password);
            
            stmt = con.createStatement();
        }
        catch(Exception e){
            JOptionPane.showMessageDialog(null, "Tentativa de conexão ao banco falhou. ", "Mensagem de erro", JOptionPane.ERROR_MESSAGE, null);
        }
    }
    

    /**
     * Conectar ao banco
     * @return
     * @throws Exception
     */
    public Connection abrir() throws Exception {
        // Registrar o driver
        Class.forName(driver);
        // Capturar a conexão
        Connection conn = DriverManager.getConnection(url, user, password);
        // Retorna a conexao aberta
        return conn;


    }
}
