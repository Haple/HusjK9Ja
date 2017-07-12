/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package projeto.restaurante;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.Vector;
import javax.swing.DefaultComboBoxModel;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;

/**
 *
 * @author i14505i
 */
public class Produto {

    public Produto() {
    
    }

    //Todos os produtos
    public DefaultComboBoxModel obterProdutos() {

        Vector items = new Vector();

        try {
            Class.forName("com.mysql.jdbc.Driver");

            Connection c = (Connection) DriverManager.getConnection("jdbc:mysql://localhost:3306/projeto_restaurante", "root", "");

            PreparedStatement comando = (PreparedStatement) c.prepareStatement("SELECT NOME FROM PRODUTOS");

            ResultSet resultado_consulta = comando.executeQuery();

            while (resultado_consulta.next()) {

                items.add(resultado_consulta.getString("NOME"));

            }

            c.close();

        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "ERRO AO BUSCAR");
        }

        DefaultComboBoxModel modeloComboBox = new DefaultComboBoxModel(items);
        return modeloComboBox;

    }

    public String obterValor(String nome) {

        try {
            Class.forName("com.mysql.jdbc.Driver");

            Connection c = (Connection) DriverManager.getConnection("jdbc:mysql://localhost:3306/projeto_restaurante", "root", "");

            PreparedStatement comando = (PreparedStatement) c.prepareStatement("SELECT VALOR FROM PRODUTOS WHERE NOME = ?");

            comando.setString(1, nome);

            ResultSet resultado_consulta = comando.executeQuery();

            while (resultado_consulta.next()) {

                return (resultado_consulta.getString("VALOR"));

            }

            c.close();

        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "ERRO AO BUSCAR");
        }

        return null;
    }
    
    
   
    

}
