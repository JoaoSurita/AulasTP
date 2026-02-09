<?php
	require_once "cabecalho.php";
?>
<div class="content">
<div class="container">
	<br><br><h1>Pet</h1><br>
	<form action="#" method="post" enctype="multipart/form-data">
		<label for="nome">Nome:</label>
		<input type="text" name="nome" id="nome">
		
		<br><br>
		<label>Idade</label><br>
		<input type="text" name="idade" id="idade">
		
		<br><br>
		<label for="preco">Raça:</label>
		<input type="text" name="raca" id="raca">
		
		<br><br>
		<label>Porte:</label>
		<select name="porte">
			<option value="0">Escolha o porte do pet</option>
			<option>Mini</option>
			</option>
			<option>Pequeno</option>
			</option>
			<option>Médio</option>
			</option>
			<option>Grande</option>
		</select>
		<div style="color:red;font-size:11px;"><?php echo $msg[0]; ?></div>
		<br><br>
		<label for="local">Local:</label>
		<input type="text" name="local" id="local">
		<div style="color:red;font-size:11px;"><?php echo $msg[1]; ?></div>
		<br><br>
		<label for="data">Data:</label>
		<input type="date" name="data" id="data">
		<div style="color:red;font-size:11px;"><?php echo $msg[2]; ?></div>
		<br><br>
		<label for="cor_olhos">Cor dos Olhos:</label>
		<input type="text" name="cor_olhos" id="cor_olhos">
		<div style="color:red;font-size:11px;"><?php echo $msg[3]; ?></div>
		<br><br>
		<label for="cor">Cor:</label>
		<input type="text" name="cor" id="cor">
		<div style="color:red;font-size:11px;"><?php echo $msg[4]; ?></div>
		<br><br>
		<label for="situacao">Situação:</label>
		<input type="radio" name="situacao" value="Procurando o Pet">
		<label>Procurando o Pet</label>
		<input type="radio" name="situacao" value="Procurando o Tutor">
		<label>Procurando o Tutor</label>
		<div style="color:red;font-size:11px;"><?php echo $msg[5]; ?></div>
		<br><br>
		<label for="observacoes">Observações:</label>
		<textarea name="observacoes"></textarea>
		
		<br><br>
		<label>Imagem:</label>
		<input type="file" name="imagem" onchange="mostrar(this)">
		<div style="color:red;font-size:11px;"><?php echo $msg[6]; ?></div>
		<br>
		<img src="" id="img">
		<br><br>
		<input type="submit" class="btn btn-primary">
	</form>
</div>
</div>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.3/jquery.min.js"></script>
	<script>
		function mostrar(img)
		{
			if(img.files  && img.files[0])
			{
				var reader = new FileReader();
				reader.onload = function(e){
					$('#img')
					.attr('src', e.target.result)
					.width(170)
					.height(100);
				};
				reader.readAsDataURL(img.files[0]);
			}
		}
	</script>
</body>
</html>