package painel.funcoesPrincipal;

import java.sql.*;
import java.util.HashMap;
import net.sf.jasperreports.engine.*;

public class Ordenar extends javax.swing.JPanel {

    private static int cont;

    public Ordenar() {
        initComponents();
        this.setSize(658, 309);

    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        buttonGroup1 = new javax.swing.ButtonGroup();
        jLabel9 = new javax.swing.JLabel();
        Ord = new javax.swing.JComboBox();
        Ordem = new javax.swing.JComboBox();
        bOk = new javax.swing.JButton();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();

        setLayout(null);
        add(jLabel9);
        jLabel9.setBounds(0, 0, 0, 0);

        Ord.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "Código", "Nome" }));
        add(Ord);
        Ord.setBounds(210, 100, 100, 20);

        Ordem.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "Crescente", "Decrescente" }));
        add(Ordem);
        Ordem.setBounds(320, 100, 100, 20);

        bOk.setIcon(new javax.swing.ImageIcon(getClass().getResource("/painel/funcoesPrincipal/file_acrobat.gif"))); // NOI18N
        bOk.setText("Exportar como pdf");
        bOk.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                bOkActionPerformed(evt);
            }
        });
        add(bOk);
        bOk.setBounds(210, 160, 220, 25);

        jLabel1.setText("Ordenar por:");
        add(jLabel1);
        jLabel1.setBounds(210, 80, 100, 14);

        jLabel2.setText("Tipo de ordenação:");
        add(jLabel2);
        jLabel2.setBounds(320, 80, 140, 14);
    }// </editor-fold>//GEN-END:initComponents

    private void bOkActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_bOkActionPerformed

        try {
            String nomearq = "CodAsc";
            if (Ord.getSelectedIndex() == 0 && Ordem.getSelectedIndex() == 0) {
                nomearq = "CodAsc";
            }
            if (Ord.getSelectedIndex() == 0 && Ordem.getSelectedIndex() == 1) {
                nomearq = "CodDesc";
            }
            if (Ord.getSelectedIndex() == 1 && Ordem.getSelectedIndex() == 0) {
                nomearq = "NomeAsc";
            }
            if (Ord.getSelectedIndex() == 1 && Ordem.getSelectedIndex() == 1) {
                nomearq = "NomeDesc";
            }
            Connection con = Conecta.getConexao();
            HashMap map = new HashMap();
            String arquivoJasper = "jaspers/" + nomearq + ".jasper";
            JasperPrint rel = JasperFillManager.fillReport(arquivoJasper, map, con);
            JasperExportManager.exportReportToPdfFile(rel, "relatorio_" + cont + ".pdf");
            cont++;
        } catch (Exception e) {

            e.printStackTrace();
        }

}//GEN-LAST:event_bOkActionPerformed
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JComboBox Ord;
    private javax.swing.JComboBox Ordem;
    private javax.swing.JButton bOk;
    private javax.swing.ButtonGroup buttonGroup1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel9;
    // End of variables declaration//GEN-END:variables
}
