
package painel.funcoesPrincipal;

import java.sql.*;
import javax.swing.JOptionPane;

public class Inserir extends javax.swing.JPanel {

    /** Creates new form Inserir */
    public Inserir() {
        initComponents();
        this.setSize(658,309);
       
    }

 
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel9 = new javax.swing.JLabel();
        jLabel7 = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        jLabel6 = new javax.swing.JLabel();
        jLabel8 = new javax.swing.JLabel();
        tEmail = new javax.swing.JTextField();
        tTelTrab = new javax.swing.JTextField();
        tTelCasa = new javax.swing.JTextField();
        tTelCel = new javax.swing.JTextField();
        bInserir = new javax.swing.JButton();
        jLabel2 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        bVer = new javax.swing.JButton();
        tCod = new javax.swing.JTextField();
        tNome = new javax.swing.JTextField();
        tApelido = new javax.swing.JTextField();
        jLabel3 = new javax.swing.JLabel();
        jLabel10 = new javax.swing.JLabel();
        jLabel11 = new javax.swing.JLabel();
        jLabel13 = new javax.swing.JLabel();
        jLabel16 = new javax.swing.JLabel();
        jLabel14 = new javax.swing.JLabel();
        tEst = new javax.swing.JTextField();
        tBairro = new javax.swing.JTextField();
        tSobre = new javax.swing.JTextField();
        tRua = new javax.swing.JTextField();
        jLabel12 = new javax.swing.JLabel();
        tNum = new javax.swing.JTextField();
        tCid = new javax.swing.JTextField();
        jScrollPane1 = new javax.swing.JScrollPane();
        tComent = new javax.swing.JTextArea();

        setLayout(null);
        add(jLabel9);
        jLabel9.setBounds(0, 0, 0, 0);

        jLabel7.setText("Tel. trab.:");
        add(jLabel7);
        jLabel7.setBounds(30, 180, 60, 14);

        jLabel5.setText("E-mail:");
        add(jLabel5);
        jLabel5.setBounds(30, 120, 130, 14);

        jLabel6.setText("Tel. casa:");
        add(jLabel6);
        jLabel6.setBounds(30, 150, 150, 14);

        jLabel8.setText("Tel. cel.:");
        add(jLabel8);
        jLabel8.setBounds(30, 210, 140, 14);

        tEmail.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        add(tEmail);
        tEmail.setBounds(90, 120, 210, 20);

        tTelTrab.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        add(tTelTrab);
        tTelTrab.setBounds(90, 180, 120, 20);

        tTelCasa.setColumns(8);
        tTelCasa.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        add(tTelCasa);
        tTelCasa.setBounds(90, 150, 120, 20);

        tTelCel.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        add(tTelCel);
        tTelCel.setBounds(90, 210, 120, 20);

        bInserir.setText("Inserir");
        bInserir.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                bInserirActionPerformed(evt);
            }
        });
        add(bInserir);
        bInserir.setBounds(260, 260, 80, 23);

        jLabel2.setText("Nome:");
        add(jLabel2);
        jLabel2.setBounds(30, 60, 40, 14);

        jLabel4.setText("Apelido:");
        add(jLabel4);
        jLabel4.setBounds(30, 90, 50, 14);

        bVer.setText("Ver Código de cadastro");
        bVer.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                bVerActionPerformed(evt);
            }
        });
        add(bVer);
        bVer.setBounds(30, 20, 170, 23);

        tCod.setEditable(false);
        tCod.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        tCod.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        add(tCod);
        tCod.setBounds(210, 20, 90, 21);

        tNome.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        add(tNome);
        tNome.setBounds(90, 60, 210, 20);

        tApelido.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        add(tApelido);
        tApelido.setBounds(90, 90, 210, 20);

        jLabel3.setText("Sobrenome:");
        add(jLabel3);
        jLabel3.setBounds(320, 60, 70, 14);

        jLabel10.setText("Rua:");
        add(jLabel10);
        jLabel10.setBounds(320, 90, 120, 14);

        jLabel11.setText("Bairro:");
        add(jLabel11);
        jLabel11.setBounds(320, 120, 130, 14);

        jLabel13.setText("Cidade:");
        add(jLabel13);
        jLabel13.setBounds(320, 150, 140, 14);

        jLabel16.setText("Comentário:");
        add(jLabel16);
        jLabel16.setBounds(320, 180, 130, 14);

        jLabel14.setText("UF:");
        add(jLabel14);
        jLabel14.setBounds(550, 120, 120, 14);

        tEst.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        add(tEst);
        tEst.setBounds(580, 120, 60, 20);

        tBairro.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        add(tBairro);
        tBairro.setBounds(390, 120, 150, 20);

        tSobre.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        add(tSobre);
        tSobre.setBounds(390, 60, 250, 20);

        tRua.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        add(tRua);
        tRua.setBounds(390, 90, 150, 20);

        jLabel12.setText("Núm.:");
        add(jLabel12);
        jLabel12.setBounds(550, 90, 130, 14);

        tNum.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        add(tNum);
        tNum.setBounds(580, 90, 60, 20);

        tCid.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        add(tCid);
        tCid.setBounds(390, 150, 250, 20);

        tComent.setColumns(20);
        tComent.setRows(5);
        jScrollPane1.setViewportView(tComent);

        add(jScrollPane1);
        jScrollPane1.setBounds(390, 180, 250, 50);
    }// </editor-fold>//GEN-END:initComponents

    private void bInserirActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_bInserirActionPerformed
      
       try{
            con = Conecta.getConexao();
            st = con.createStatement();
            String nome = tNome.getText();
            String sobrenome = tSobre.getText();
            String apelido = tApelido.getText();
            String email = tEmail.getText();
            String telCasa;
            String telTrab;
            String telCel;
            telCasa = tTelCasa.getText();
            telTrab = tTelTrab.getText();
            telCel  = tTelCel.getText();
            String rua = tRua.getText();
            String bairro = tBairro.getText();
            String aux = tNum.getText();
            if(aux.compareTo("")==0){
                aux="0";
            }
            int num = Integer.parseInt(aux);
            String cidade = tCid.getText();
            String estado = tEst.getText();
            String coment = tComent.getText();
            int res = st.executeUpdate("insert into agenda (nome, sobrenome, apelido, email, telCasa, telTrab, telCel, rua, bairro, num, cidade, estado, coment) values('"+nome+"','"+sobrenome+"', '"+apelido+"','"+email+"','"+telCasa+"','"+telTrab+"','"+telCel+"','"+rua+"','"+bairro+"',"+num+",'"+cidade+"','"+estado+"','"+coment+"')");
            if(res==1)
                JOptionPane.showMessageDialog(this, "Cadastrado com sucesso !");
            con.close();

            tCod.setText("");
            tNome.setText("");
            tSobre.setText("");
            tApelido.setText("");
            tEmail.setText("");
            tTelCasa.setText("");
            tTelTrab.setText("");
            tTelCel.setText("");
            tRua.setText("");
            tBairro.setText("");
            tNum.setText("");
            tCid.setText("");
            tEst.setText("");
            tCid.setText("");
            tComent.setText("");
       }catch(Exception ex){
          ex.printStackTrace();
       }
    }//GEN-LAST:event_bInserirActionPerformed

    private void bVerActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_bVerActionPerformed
        try{
             con = Conecta.getConexao();
             st = con.createStatement();
             rs = st.executeQuery("select max(cod) from agenda");
             if(rs.next()){
                int cod=rs.getInt(1);
                 tCod.setText(String.valueOf(cod+1));
             }
             con.close();
        }catch(Exception ex){
         ex.printStackTrace();
        }

    }//GEN-LAST:event_bVerActionPerformed
Connection con;
Statement st;
ResultSet  rs;



    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton bInserir;
    private javax.swing.JButton bVer;
    private javax.swing.JLabel jLabel10;
    private javax.swing.JLabel jLabel11;
    private javax.swing.JLabel jLabel12;
    private javax.swing.JLabel jLabel13;
    private javax.swing.JLabel jLabel14;
    private javax.swing.JLabel jLabel16;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JLabel jLabel8;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTextField tApelido;
    private javax.swing.JTextField tBairro;
    private javax.swing.JTextField tCid;
    private javax.swing.JTextField tCod;
    private javax.swing.JTextArea tComent;
    private javax.swing.JTextField tEmail;
    private javax.swing.JTextField tEst;
    private javax.swing.JTextField tNome;
    private javax.swing.JTextField tNum;
    private javax.swing.JTextField tRua;
    private javax.swing.JTextField tSobre;
    private javax.swing.JTextField tTelCasa;
    private javax.swing.JTextField tTelCel;
    private javax.swing.JTextField tTelTrab;
    // End of variables declaration//GEN-END:variables

}
