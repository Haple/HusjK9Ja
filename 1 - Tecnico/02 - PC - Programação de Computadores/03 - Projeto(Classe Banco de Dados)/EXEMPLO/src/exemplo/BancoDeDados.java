/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exemplo;

import java.sql.Connection;
import java.sql.DriverManager;

/**
 *
 * @author 42929
 */
public class BancoDeDados {
    
    private static Connection connection = null;

    public static Connection getConnection() {

        if (connection != null) {
            return connection;
        } else {
            try {

                Class.forName("com.mysql.jdbc.Driver");

                connection = DriverManager.getConnection("jdbc:mysql://localhost:3306/info3","root","");

            } catch (Exception e) {
            }
            return connection;
        }
    }
}
