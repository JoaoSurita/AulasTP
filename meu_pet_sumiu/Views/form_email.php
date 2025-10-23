<?php
	require_once "cabecalho.php";
?>
<div class="content">
<div class="container">
<h1 style="margin-top:60px;margin-bottom:20px;">Recuperar Senha</h1>
<div class="col-md-6 text-danger"><?php echo $msg_email;?></div>
<?php
	//retirar quando for possível o envio do email
	if($link != "")
	{
		echo "<a href='" . $link . "' >Clique Aqui</a>";
	}
?>
<form class="row g-3" action="#" method="post">
  
  <div class="col-md-6">
    <label for="email" class="form-label">Email</label>
    <input type="email" class="form-control" id="email" name="email">
  </div>
   
  <div class="col-md-6 text-danger"><?php echo $msg;?></div>
  
  <div class="col-12">
    <button type="submit" class="btn btn-primary">Enviar</button>
  </div>
</form>

</div>
</div>
</body>
</html>