<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
      <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Free Bootstrap Admin Template : Binary Admin</title>
	<!-- BOOTSTRAP STYLES-->
    <link href="assets/css/bootstrap.css" rel="stylesheet" />
     <!-- FONTAWESOME STYLES-->
    <link href="assets/css/font-awesome.css" rel="stylesheet" />
     <!-- MORRIS CHART STYLES-->

        <!-- CUSTOM STYLES-->
    <link href="assets/css/custom.css" rel="stylesheet" />
     <!-- GOOGLE FONTS-->
   <link href='http://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css' />
     <!-- TABLE STYLES-->
    <link href="assets/js/dataTables/dataTables.bootstrap.css" rel="stylesheet" />
</head>
<body>
    <div id="wrapper">
        <nav class="navbar navbar-default navbar-cls-top " role="navigation" style="margin-bottom: 0">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".sidebar-collapse">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="index.html">Voz d'Arte</a>
            </div>
  <div style="color: white;
padding: 15px 50px 5px 50px;
float: right;
font-size: 16px;">  <a href="#" class="btn btn-danger square-btn-adjust">Logout</a> </div>
        </nav>
           <!-- /. NAV TOP  -->
                <nav class="navbar-default navbar-side" role="navigation">
            <div class="sidebar-collapse">
                <ul class="nav" id="main-menu">
				<li class="text-center">
                    <img src="assets/img/find_user.png" class="user-image img-responsive"/>
					</li>


                    <li>
                        <a  href="index.html"><i class="fa fa-dashboard fa-3x"></i> Gerenciador de Narrações</a>
                    </li>
					<!--
                   <li>
                        <a  href="ui.html"><i class="fa fa-desktop fa-3x"></i> UI Elements</a>
                    </li>
                    <li>
                        <a  href="tab-panel.html"><i class="fa fa-qrcode fa-3x"></i> Tabs & Panels</a>
                    </li>
						   <li  >
                        <a  href="chart.html"><i class="fa fa-bar-chart-o fa-3x"></i> Morris Charts</a>
                    </li>
                      <li  >
                        <a class="active-menu"  href="table.html"><i class="fa fa-table fa-3x"></i> Table Examples</a>
                    </li>
                    <li  >
                        <a  href="form.html"><i class="fa fa-edit fa-3x"></i> Forms </a>
                    </li>


                    <li>
                        <a href="#"><i class="fa fa-sitemap fa-3x"></i> Multi-Level Dropdown<span class="fa arrow"></span></a>
                        <ul class="nav nav-second-level">
                            <li>
                                <a href="#">Second Level Link</a>
                            </li>
                            <li>
                                <a href="#">Second Level Link</a>
                            </li>
                            <li>
                                <a href="#">Second Level Link<span class="fa arrow"></span></a>
                                <ul class="nav nav-third-level">
                                    <li>
                                        <a href="#">Third Level Link</a>
                                    </li>
                                    <li>
                                        <a href="#">Third Level Link</a>
                                    </li>
                                    <li>
                                        <a href="#">Third Level Link</a>
                                    </li>

                                </ul>

                            </li>
                        </ul>
                      </li>
                  <li  >
                        <a   href="blank.html"><i class="fa fa-square-o fa-3x"></i> Blank Page</a>
                    </li>
					
				-->	
                </ul>

            </div>

        </nav>
        <!-- /. NAV SIDE  -->
        <div id="page-wrapper" >
            <div id="page-inner">
                <div class="row">
                    <div class="col-md-12">
                     <h2>Já narrou alguma pintura hoje?</h2>
                        <h5>Estimule a imaginação de seus alunos. Conte uma história com uma pintura!</h5>

                    </div>
                </div>
                 <!-- /. ROW  -->
                 <hr />

                 <div class="row">

                    <div class="col-md-12">
                         <!--   Basic Table  -->
                         <button type="button" class="btn btn-info btn-lg" data-toggle="modal" data-target="#modalCadastro">Cadastrar</button>
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                Tabela das obras
                            </div>
                            <div class="panel-body">
                                <div class="table-responsive">
                                    <table class="table">
                                        <thead>
                                            <tr>
                                                <th>Imagem</th>
                                                <th>Titulo</th>
                                                <th>Ações</th>
                                                <th>Movimento</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                          <?php
                                            $i = 0;
                                              require_once("functions.php");
                                              $database = connect_DB();
                                              $result = mysqli_query($database,"SELECT * FROM obras");
                                              while($row = mysqli_fetch_assoc($result))
                                              {
                                                $cod = $row["cod"];
                                                $img = $row["img"];
                                                $titulo = $row["titulo"];
                                                $voz = $row["voz"];
                                                $tag = $row["tag"];
                                                echo "<tr>
                                                          <td>
                                                            <img src=\"$img\" width=\"150px\" height=\"150px\">
                                                          </td>
                                                          <td>$titulo</td>
                                                          <td>
                                                            <button type=\"button\" class=\"btn btn-primary\" style=\"float:left;\" data-toggle=\"modal\" data-target=\"#modalEditar$i\">Editar</button>
                                                            <form action=\"remover.php\" method=\"POST\">
                                                              <input type=\"hidden\" name=\"cod\" value=\"$cod\">
                                                              <input type=\"hidden\" name=\"img\" value=\"$img\">
                                                              <input type=\"hidden\" name=\"titulo\" value=\"$titulo\">
                                                              <input type=\"hidden\" name=\"voz\" value=\"$voz\">
                                                              <button type=\"submit\" class=\"btn btn-danger\" style=\"float:left;margin-left:20px;\">Remover</button>
                                                            </form>
                                                          </td>
                                                          <td>
                                                          $tag
                                                          </td>
                                                      </tr>";

                                                    echo "<div id=\"modalEditar$i\" class=\"modal fade\" role=\"dialog\">
                                                            <div class=\"modal-dialog\">

                                                              <!-- Modal content-->
                                                              <div class=\"modal-content\">
                                                                <div class=\"modal-header\">
                                                                  <button type=\"button\" class=\"close\" data-dismiss=\"modal\">&times;</button>
                                                                  <h4 class=\"modal-title\">Editar</h4>
                                                                </div>
                                                                <div class=\"modal-body\">
                                                                  <form action=\"editar.php\" method=\"POST\" enctype=\"multipart/form-data\">
                                                                    <input type=\"hidden\" name=\"cod\" value=\"$cod\">
                                                                    <input type=\"hidden\" name=\"tipo\" value=\"update\">
                                                                      <b>Titulo</b><input type=\"text\" name=\"titulo\" value=\"$titulo\">
                                                                      <br><br>
                                                                      <b>Imagem</b><input type=\"file\" name=\"arquivo\">
                                                                      <br><br>
                                                                      <b>Audio</b><input type=\"file\" name=\"audio\">
                                                                      <br><br>
                                                                      <b>Movimento:</b><select name=\"tag\">";
                                                                              if($tag == "Humanismo")
                                                                              {
                                                                                  echo "<option value=\"Humanismo\" selected>Humanismo</option>
                                                                                  <option value=\"Romantismo\">Romantismo</option>
                                                                                  <option value=\"Modernismo\">Modernismo</option>";
                                                                              }
                                                                              else if($tag == "Romantismo")
                                                                              {
                                                                                  echo "<option value=\"Humanismo\">Humanismo</option>
                                                                                  <option value=\"Romantismo\" selected>Romantismo</option>
                                                                                  <option value=\"Modernismo\">Modernismo</option>";
                                                                              }
                                                                              else if($tag == "Modernismo")
                                                                              {
                                                                                  echo "<option value=\"Humanismo\">Humanismo</option>
                                                                                  <option value=\"Romantismo\">Romantismo</option>
                                                                                  <option value=\"Modernismo\" selected>Modernismo</option>";
                                                                              }
                                                                              echo "
                                                                              </select>
                                                                      <br><br>
                                                                      <button type=\"submit\" class=\"btn btn-primary\">Editar</button>
                                                                  </form>
                                                                </div>
                                                                <div class=\"modal-footer\">
                                                                  <button type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\">Close</button>
                                                                </div>
                                                              </div>

                                                            </div>
                                                          </div>";
                                                          $i++;
                                              }

                                          ?>

                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                          <!-- End  Basic Table  -->
                    </div>
                </div>

                <!-- /. ROW  -->
        </div>
        <div id="modalCadastro" class="modal fade" role="dialog">
          <div class="modal-dialog">

            <!-- Modal content-->
            <div class="modal-content">
              <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal">&times;</button>
                <h4 class="modal-title">Cadastrar</h4>
              </div>
              <div class="modal-body">
                <form action="cadastrar.php" method="POST" enctype="multipart/form-data">
                    <input type="hidden" name="tipo" value="insert">
                    <b>Titulo</b><input type="text" name="titulo">
                    <br><br>
                    <b>Imagem</b><input type="file" name="arquivo">
                    <br><br>
                    <b>Audio</b><input type="file" name="audio">
                    <br><br>
                    <b>Movimento:</b><select name="tag">
                              <option value="Humanismo">Humanismo</option>
                              <option value="Romantismo">Romantismo</option>
                              <option value="Modernismo">Modernismo</option>
                            </select>
                    <br><br>
                    <button type="submit" class="btn btn-primary">Cadastrar</button>
                </form>
              </div>
              <div class="modal-footer">
                <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
              </div>
            </div>

          </div>
        </div>
    </div>
             <!-- /. PAGE INNER  -->
            </div>
         <!-- /. PAGE WRAPPER  -->
     <!-- /. WRAPPER  -->
    <!-- SCRIPTS -AT THE BOTOM TO REDUCE THE LOAD TIME-->
    <!-- JQUERY SCRIPTS -->
    <script src="assets/js/jquery-1.10.2.js"></script>
      <!-- BOOTSTRAP SCRIPTS -->
    <script src="assets/js/bootstrap.min.js"></script>
    <!-- METISMENU SCRIPTS -->
    <script src="assets/js/jquery.metisMenu.js"></script>
     <!-- DATA TABLE SCRIPTS -->
    <script src="assets/js/dataTables/jquery.dataTables.js"></script>
    <script src="assets/js/dataTables/dataTables.bootstrap.js"></script>
        <script>
            $(document).ready(function () {
                $('#dataTables-example').dataTable();
            });
    </script>
         <!-- CUSTOM SCRIPTS -->
    <script src="assets/js/custom.js"></script>


</body>
</html>
