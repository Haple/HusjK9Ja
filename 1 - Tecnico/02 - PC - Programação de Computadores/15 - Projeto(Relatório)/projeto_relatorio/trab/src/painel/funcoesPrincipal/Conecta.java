package painel.funcoesPrincipal;

import java.sql.Connection;
import java.sql.DriverManager;



public class Conecta {
	private static Connection con;
	public static Connection getConexao() {
		String driver = "com.mysql.jdbc.Driver";
		String url = "jdbc:mysql://localhost:3306/agenda";
		String login = "root";
		String senha = "root";
		try {
			Class.forName(driver);
			con = DriverManager.getConnection(url, login, senha);
		} catch (Exception e) {
                        e.printStackTrace();
                }
		return con;
	}
}