<?php
	if(!isset($_SESSION))
	{
		session_start();
	}
	//var_dump($_SESSION);
?>
<!doctype html>
<html>
	<head>
		<title>Meu Pet Sumiu</title>
		<meta charset="utf-8">
		<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
		<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
	</head>
	<body>
	<nav class="navbar navbar-expand-lg navbar-light bg-light">
	<div class="container-fluid">
    <a class="navbar-brand" href="#">meu pet sumiu</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarNav">
      <ul class="navbar-nav">
        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="#">Home</a>
        </li>
		<?php
		if(isset($_SESSION["id"]))	
		{
			echo "<li class='nav-item'>
			<a class='nav-link' href='index.php?controle=PetController&metodo=inserir'>Cadastrar Pets</a>
			</li>
			<li class='nav-item'>
			<a class='nav-link' href='index.php?controle=UsuarioController&metodo=logout'>Sair</a>
			</li>";
		}
		else
		{
        echo "<li class='nav-item'>
				<a class='nav-link' href='index.php?controle=UsuarioController&metodo=inserir'>Criar Conta</a>
			  </li>
			  <li class='nav-item'>
				<a class='nav-link' href='index.php?controle=UsuarioController&metodo=login'>Login</a>	
			  </li>";
		}
		?>
        
      </ul>
    </div>
  </div>
</nav>