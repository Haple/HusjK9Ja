/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package simulado;

//import android.os.AsyncTask;
import java.io.BufferedReader;
import java.io.DataOutputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;

/**
 *
 * @author unknow
 */
public class Usuario {

    String resposta;

    public String Cadastrar(String nome, String senha, String rg, String telefone, String email) {

        String dados = "nome_completo=" + nome
                + "&senha=" + senha
                + "&rg=" + rg
                + "&telefone=" + telefone
                + "&email=" + email;

        try {
            
            URL url = new URL("http://pontodaesfiha.pe.hu/newUsuario.php");
            HttpURLConnection con = (HttpURLConnection) url.openConnection();
            
            con.setDoOutput(true);
            con.setDoInput(true);
            con.setUseCaches(true);
            
            con.setRequestMethod("POST");
            con.setRequestProperty("Content-type", "application/x-www-form-urlencoded");

            DataOutputStream printer = new DataOutputStream(con.getOutputStream());
            printer.writeBytes(dados);
            printer.flush();
            printer.close();

            BufferedReader reader = new BufferedReader(new InputStreamReader(con.getInputStream(), "ISO-8859-1"));
            String line = null;
            while ((line = reader.readLine()) != null) {
                resposta = line;
            }
        } catch (Exception e) {
            resposta = "" + e;
        }
        return resposta;

    }
}
