package frame;

import javax.swing.JOptionPane;
import painel.funcoesAdicional.*;
import painel.funcoesPrincipal.*;

public class Principal extends javax.swing.JFrame {

    /** Creates new form Principal */
    public Principal() {
        try{
            Class.forName("com.mysql.jdbc.Driver");
        }
        catch(Exception ex){
            ex.printStackTrace();
        }
        initComponents();
        img = new Img();
        this.getContentPane().add(img);
        img.setBounds(0, 0, 660, 360);
        img.setVisible(true);

        i = new Inserir();
        this.getContentPane().add(i);
        i.setBounds(0, 0, 660, 360);
        i.setVisible(false);

        e = new Excluir();
        this.getContentPane().add(e);
        e.setBounds(0, 0, 660, 360);
        e.setVisible(false);

        p = new Procurar();
        this.getContentPane().add(p);
        p.setBounds(0, 0, 660, 360);
        p.setVisible(false);

        v = new Visualizar();
        this.getContentPane().add(v);
        v.setBounds(0, 0, 660, 360);
        v.setVisible(false);

        o = new Ordenar();
        this.getContentPane().add(o);
        o.setBounds(0, 0, 660, 360);
        o.setVisible(false);
    }

 
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jMenuBar1 = new javax.swing.JMenuBar();
        imInserir = new javax.swing.JMenu();
        jMenuItem3 = new javax.swing.JMenuItem();
        imExluir = new javax.swing.JMenuItem();
        imVisualizar = new javax.swing.JMenuItem();
        imProcurar = new javax.swing.JMenuItem();
        imOrdenar = new javax.swing.JMenuItem();
        jSeparator2 = new javax.swing.JSeparator();
        imFechar = new javax.swing.JMenuItem();
        jMenu2 = new javax.swing.JMenu();
        imAjuda = new javax.swing.JMenuItem();
        jSeparator1 = new javax.swing.JSeparator();
        imSobre = new javax.swing.JMenuItem();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("MM agenda");
        setResizable(false);

        imInserir.setText("Opções");

        jMenuItem3.setIcon(new javax.swing.ImageIcon(getClass().getResource("/frame/page_new.gif"))); // NOI18N
        jMenuItem3.setText("Inserir");
        jMenuItem3.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jMenuItem3ActionPerformed(evt);
            }
        });
        imInserir.add(jMenuItem3);

        imExluir.setIcon(new javax.swing.ImageIcon(getClass().getResource("/frame/page_text_delete.gif"))); // NOI18N
        imExluir.setText("Excluir");
        imExluir.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                imExluirActionPerformed(evt);
            }
        });
        imInserir.add(imExluir);

        imVisualizar.setIcon(new javax.swing.ImageIcon(getClass().getResource("/frame/list_users.gif"))); // NOI18N
        imVisualizar.setText("Visualizar");
        imVisualizar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                imVisualizarActionPerformed(evt);
            }
        });
        imInserir.add(imVisualizar);

        imProcurar.setIcon(new javax.swing.ImageIcon(getClass().getResource("/frame/page_find.gif"))); // NOI18N
        imProcurar.setText("Procurar");
        imProcurar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                imProcurarActionPerformed(evt);
            }
        });
        imInserir.add(imProcurar);

        imOrdenar.setIcon(new javax.swing.ImageIcon(getClass().getResource("/frame/action_refresh.gif"))); // NOI18N
        imOrdenar.setText("Ordenar");
        imOrdenar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                imOrdenarActionPerformed(evt);
            }
        });
        imInserir.add(imOrdenar);
        imInserir.add(jSeparator2);

        imFechar.setIcon(new javax.swing.ImageIcon(getClass().getResource("/frame/action_stop.gif"))); // NOI18N
        imFechar.setText("Fechar");
        imFechar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                imFecharActionPerformed(evt);
            }
        });
        imInserir.add(imFechar);

        jMenuBar1.add(imInserir);

        jMenu2.setText("Ajuda");

        imAjuda.setIcon(new javax.swing.ImageIcon(getClass().getResource("/frame/icon_info.gif"))); // NOI18N
        imAjuda.setText("Ajuda");
        imAjuda.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                imAjudaActionPerformed(evt);
            }
        });
        jMenu2.add(imAjuda);
        jMenu2.add(jSeparator1);

        imSobre.setIcon(new javax.swing.ImageIcon(getClass().getResource("/frame/page_script.gif"))); // NOI18N
        imSobre.setText("Sobre");
        imSobre.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                imSobreActionPerformed(evt);
            }
        });
        jMenu2.add(imSobre);

        jMenuBar1.add(jMenu2);

        setJMenuBar(jMenuBar1);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 647, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 351, Short.MAX_VALUE)
        );

        java.awt.Dimension screenSize = java.awt.Toolkit.getDefaultToolkit().getScreenSize();
        setBounds((screenSize.width-655)/2, (screenSize.height-406)/2, 655, 406);
    }// </editor-fold>//GEN-END:initComponents

    private void jMenuItem3ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jMenuItem3ActionPerformed
        i.setVisible(true);
        img.setVisible(false);
        e.setVisible(false);
        p.setVisible(false);
        v.setVisible(false);
        o.setVisible(false);
    }//GEN-LAST:event_jMenuItem3ActionPerformed

    private void imSobreActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_imSobreActionPerformed
     JOptionPane.showMessageDialog(this, "Software desenvolvido para o trabalho da\ndisciplina Programação Orientada a Objetos II\n\nProgramadores: José Antônio Duarte Junior\n                                Julian Luis Fagundes de Souza\nProfessor: Rolf\nData: 16/11/2008", "Sobre o MM phonebook", 1);

}//GEN-LAST:event_imSobreActionPerformed

    private void imFecharActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_imFecharActionPerformed
       System.exit(0);
}//GEN-LAST:event_imFecharActionPerformed

    private void imExluirActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_imExluirActionPerformed
        e.setVisible(true);
        i.setVisible(false);
        img.setVisible(false);
        p.setVisible(false);
        v.setVisible(false);
        o.setVisible(false);
}//GEN-LAST:event_imExluirActionPerformed

    private void imProcurarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_imProcurarActionPerformed
        e.setVisible(false);
        i.setVisible(false);
        img.setVisible(false);
        p.setVisible(true);
        v.setVisible(false);
        o.setVisible(false);
}//GEN-LAST:event_imProcurarActionPerformed

    private void imAjudaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_imAjudaActionPerformed
        JOptionPane.showMessageDialog(this, "Não implementado\nno windows funcionou a ajuda em html, no linux nao");
        
        
        /*AbreBrowser browser = new AbreBrowser();
        String URL = ("file:///"+System.getProperty("user.dir") + "/ajuda/inicio.html");
        String URLSend = AbreBrowser.URLCaracteresInvalidos(URL);
        browser.AbreBrowser(URLSend);*/

}//GEN-LAST:event_imAjudaActionPerformed

    private void imVisualizarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_imVisualizarActionPerformed
        e.setVisible(false);
        i.setVisible(false);
        img.setVisible(false);
        p.setVisible(false);
        v.setVisible(true);
        o.setVisible(false);
    }//GEN-LAST:event_imVisualizarActionPerformed

    private void imOrdenarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_imOrdenarActionPerformed
        e.setVisible(false);
        i.setVisible(false);
        img.setVisible(false);
        p.setVisible(false);
        v.setVisible(false);
        o.setVisible(true);
    }//GEN-LAST:event_imOrdenarActionPerformed

    public static void main(String args[]) {
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Principal().setVisible(true);
            }
        });
    }
    Inserir i;
    Excluir e;
    Procurar p;
    Visualizar v;
    Ordenar o;
    Img img;

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JMenuItem imAjuda;
    private javax.swing.JMenuItem imExluir;
    private javax.swing.JMenuItem imFechar;
    private javax.swing.JMenu imInserir;
    private javax.swing.JMenuItem imOrdenar;
    private javax.swing.JMenuItem imProcurar;
    private javax.swing.JMenuItem imSobre;
    private javax.swing.JMenuItem imVisualizar;
    private javax.swing.JMenu jMenu2;
    private javax.swing.JMenuBar jMenuBar1;
    private javax.swing.JMenuItem jMenuItem3;
    private javax.swing.JSeparator jSeparator1;
    private javax.swing.JSeparator jSeparator2;
    // End of variables declaration//GEN-END:variables

}
