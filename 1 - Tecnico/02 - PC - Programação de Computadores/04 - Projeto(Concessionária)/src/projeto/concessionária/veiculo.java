/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package projeto.concessionária;

import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import javax.swing.JOptionPane;

/**
 *
 * @author i14505i
 */
public class veiculo {

    private String placa;
    private String marca;
    private String ano;

    //MÉTODO: NOVO CARRO
    //FUNÇÃO: ADICONAR UM NOVO CARRO
    //PARÂMETROS: PLACA_VEICULO, MARCA_VEICULO, ANO_VEICULO
    public void novoCarro(String placa_veiculo, String marca_veiculo, String ano_veiculo) {
        placa = placa_veiculo;
        marca = marca_veiculo;
        ano = ano_veiculo;

        try {
            BufferedWriter bw = new BufferedWriter(new FileWriter(".\\Cadastro veiculo.txt", true));
            bw.write(placa + ":");
            bw.write(marca + ":");
            bw.write(ano);
            bw.newLine();
            bw.flush();
            bw.close();
            JOptionPane.showMessageDialog(null, "Veículo cadastrado com louvor!");
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "Veículo não cadastrado! Falhou!");
        }

    }

    //MÉTODO: EXCLUIR CARRO
    //FUNÇÃO: DELETAR UM NOVO CARRO
    //PARÂMETROS: PLACA_VEICULO   
    public void excluirCarro(String placa_veiculo) {
        try {
            File cadastroVeiculo = new File(".\\Cadastro veiculo.txt");
            File cadastroVeiculoTemporario = new File(".\\Temporatio.txt");

            BufferedReader reader = new BufferedReader(new FileReader(cadastroVeiculo));
            BufferedWriter writer = new BufferedWriter(new FileWriter(cadastroVeiculoTemporario));

            String linhaRemover = placa_veiculo;
            String linhaAtual;

            while ((linhaAtual = reader.readLine()) != null) {
                // trim newline when comparing with lineToRemove
                String trimmedLine = linhaAtual.trim();
                if (trimmedLine.equals(linhaRemover)) {
                    continue;
                }
                writer.write(linhaAtual + System.getProperty(":"));
            }
            writer.close();
            reader.close();
            boolean successful = cadastroVeiculoTemporario.renameTo(cadastroVeiculo);
            JOptionPane.showMessageDialog(null, "Veículo excluido com sucesso!");
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "Veículo não cadastrado! Falhou!");
        }
    }

    //MÉTODO: LISTAR CARRO
    //FUNÇÃO: MOSTRAR OS VEICULOS 
    //PARÂMETROS: MARCA_VEICULO E ANO_VEICULO    
    public void listarCarro() {

    }
}
