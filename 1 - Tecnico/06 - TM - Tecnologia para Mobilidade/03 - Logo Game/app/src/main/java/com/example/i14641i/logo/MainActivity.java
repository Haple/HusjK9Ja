package com.example.i14641i.logo;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    EditText nome;
    int fase=1;
    TextView resultado;
    int acertos=0;
    int erros=0;

    ImageView Botao_Confirmar;
    ImageView Botao_Proximo;
    ImageView Imagem_Logo;



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        nome = (EditText)findViewById(R.id.txt_nome);
        resultado = (TextView)findViewById(R.id.lbl_resultado);
        Botao_Confirmar = (ImageView) findViewById(R.id.confirmar);
        Botao_Proximo = (ImageView) findViewById(R.id.proximo);
        Imagem_Logo = (ImageView)findViewById(R.id.img_logo);

        carregarfase();
        Botao_Confirmar.setOnClickListener(EventoConfirmar);
        Botao_Proximo.setOnClickListener(EventoProximo);


    }


    private void carregarfase(){

        nome.setText("");
        nome.setFocusable(true);
        resultado.setText("");

        switch (fase) {

            case 1:
                Imagem_Logo.setImageResource(R.drawable.serjao);
                Imagem_Logo.setTag("SERJÃO BERRANTEIRO");
                break;
            case 2:
                Imagem_Logo.setImageResource(R.drawable.jailson);
                Imagem_Logo.setTag("JAILSON MENDES");
                break;
            case 3:
                Imagem_Logo.setImageResource(R.drawable.gugunegro);
                Imagem_Logo.setTag("GUGU");
                break;
            case 4:
                Imagem_Logo.setImageResource(R.drawable.derp);
                Imagem_Logo.setTag("DERP");
                break;
            case 5:
                Imagem_Logo.setImageResource(R.drawable.faustao);
                Imagem_Logo.setTag("FAUSTÃO");
                break;
            case 6:
                Imagem_Logo.setImageResource(R.drawable.irineu);
                Imagem_Logo.setTag("IRINEU");
                break;
            case 7:
                Imagem_Logo.setImageResource(R.drawable.andre);
                Imagem_Logo.setTag("ANDRE MARQUES");
                break;
            case 8:
                Imagem_Logo.setImageResource(R.drawable.jo);
                Imagem_Logo.setTag("JÔ SOARES");
                break;
            case 9:
                Imagem_Logo.setImageResource(R.drawable.pele);
                Imagem_Logo.setTag("PELÉ");
                break;
            case 10:
                Imagem_Logo.setImageResource(R.drawable.fofao);
                Imagem_Logo.setTag("FOFÃO");
                break;
            case 11:
                Imagem_Logo.setImageResource(R.drawable.ben);
                Imagem_Logo.setTag("BEN 10");
                break;
        }


    }



    private void verificarResposta(){
        String nome_da_imagem = Imagem_Logo.getTag().toString();
        String nome_digitado = nome.getText().toString().trim().toUpperCase();
        if (nome_digitado.equals(nome_da_imagem)){

            acertos ++;
            resultado.setText("Acertou!!");
        } else {

            erros ++;
            resultado.setText("Errou!!");

        }
    }

    private View.OnClickListener EventoConfirmar = new View.OnClickListener(){
        public void onClick(View view){

            verificarResposta();
        }

    };

    private View.OnClickListener EventoProximo = new View.OnClickListener(){
        public void onClick(View view){

            fase ++;
            carregarfase();
        }

    };





}
