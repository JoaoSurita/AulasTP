<?php
	require_once "Pessoa.class.php";
	require_once "Fisica.class.php";
	require_once "Juridica.class.php";
	
	$pessoaFisica = new Fisica("123.123.345-34", "João da Silva", "(14)99992828", "Rua XV de Novembro, 123, 17000000");
	
	echo "<pre>";
	var_dump($pessoaFisica);
	echo "</pre>";
	
	echo $pessoaFisica->inserir($pessoaFisica);
	echo $pessoaFisica->alterar($pessoaFisica);
	
	$pessoa = new Pessoa("Maria", "(14)999999", "Endereço");
?>