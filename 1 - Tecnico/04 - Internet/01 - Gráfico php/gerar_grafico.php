<?php

header('Content-Type: text/html; charset=utf-8');

$mes = '06';
//$mes = $_GET['param_mes'];


mysql_connect('localhost', 'root', '');

mysql_select_db('sistema');

$resultado = mysql_query("SELECT DATE_FORMAT(PEDIDO_DATA, '%d/%m') AS DIA, PEDIDO_VALOR_TOTAL AS TOTAL FROM PEDIDOS WHERE MONTH(PEDIDO_DATA) = '$mes'");

$dados = array();

while($linha = mysql_fetch_array($resultado,MYSQL_ASSOC))
{	
	  $dados[] = array($linha['DIA'], $linha['TOTAL']);
}



require_once 'phplot.php';



$grafico = new PHPlot(800, 600);

#Indicamos o título do gráfico e o título dos dados no eixo X e Y do mesmo
$grafico->SetTitle("GRÁFICO TOTAL DE PEDIDO POR DIA ( JUNHO )");
$grafico->SetXTitle("DIA DO MÊS");
$grafico->SetYTitle("VALOR TOTAL POR DIA");
$grafico->SetDataValues($dados);
//$grafico->SetUseTTF(true);
$grafico->SetDefaultTTFont('./arial.ttf');
//$grafico->SetDefaultTTFont('https://fonts.googleapis.com/css?family=Roboto');


#Exibimos o gráfico
$grafico->DrawGraph();


?>