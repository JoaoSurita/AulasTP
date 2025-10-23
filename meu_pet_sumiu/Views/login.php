<?php
	require_once "cabecalho.php";
?>
<div class="content">
<div class="container">
<h1 style="margin-top:60px;margin-bottom:20px;">Login</h1>
<div class="col-md-6 text-danger"><?php echo $msg[2];?></div>
<form class="row g-3" action="#" method="post">
  
  <div class="col-md-6">
    <label for="email" class="form-label">Email</label>
    <input type="email" class="form-control" id="email" name="email">
  </div>
  
  <div class="col-md-6">
    <label for="senha" class="form-label">Senha</label>
    <input type="password" class="form-control" id="senha" name="senha">
  </div>
  
  <div class="col-md-6 text-danger"><?php echo $msg[0];?></div>
  <div class="col-md-6 text-danger"><?php echo $msg[1];?></div>
  <div class="col-12">
    <button type="submit" class="btn btn-primary">Enviar</button>
  </div>
</form>
<a href="index.php?controle=usuarioController&metodo=esqueci_senha">Esqueci minha senha</a>
</div>
</div>
</body>
</html>