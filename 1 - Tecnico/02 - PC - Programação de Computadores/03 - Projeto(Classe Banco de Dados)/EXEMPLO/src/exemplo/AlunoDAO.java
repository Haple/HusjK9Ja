/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exemplo;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author 42929
 */
public class AlunoDAO {

    private Connection connection;



    public AlunoDAO() {
        connection = BancoDeDados.getConnection();
    }

    public void addAluno(Aluno aluno) {
        try {

            PreparedStatement preparedStatement = connection
                    .prepareStatement("insert into aluno(ra,nome) values (?, ?)");

            preparedStatement.setInt(1, aluno.getRA());

            preparedStatement.setString(2, aluno.getNome());

            preparedStatement.executeUpdate();

        } catch (Exception e) {            
        }
    }



    public void deleteAluno(int ra) {

        try {

            PreparedStatement preparedStatement = connection
                    .prepareStatement("delete from aluno where ra=?");

            preparedStatement.setInt(1, ra);

            preparedStatement.executeUpdate();

        } catch (Exception e) {
        }
    }

    public void updateAluno(Aluno aluno) {

        try {

            PreparedStatement preparedStatement = connection

                    .prepareStatement("update aluno set nome=? where ra=?");

            preparedStatement.setString(1, aluno.getNome());
            
            preparedStatement.setInt(2, aluno.getRA());

            preparedStatement.executeUpdate();

        } catch (Exception e) {

        }
    }

    public List<Aluno> getTodosAlunos() {

        List<Aluno> lista_aluno = new ArrayList<Aluno>();

        try {

            Statement statement = connection.createStatement();

            ResultSet rs = statement.executeQuery("select * from aluno");

            while (rs.next()) {

                Aluno aluno = new Aluno();

                aluno.setRA(rs.getInt("ra"));

                aluno.setNome(rs.getString("nome"));

                lista_aluno.add(aluno);
            }
        } catch (Exception e) {
        }
        
        return lista_aluno;
    }



    public Aluno getAlunoPorRA(int ra) {

        Aluno aluno = new Aluno();

        try {

            PreparedStatement preparedStatement = connection.

                    prepareStatement("select * from aluno where ra=?");

            preparedStatement.setInt(1, ra);

            ResultSet rs = preparedStatement.executeQuery();


            if (rs.next()) {

                aluno.setRA(rs.getInt("ra"));

                aluno.setNome(rs.getString("nome"));               
            }

        } catch (Exception e) {            

        }

        return aluno;
    }


}
