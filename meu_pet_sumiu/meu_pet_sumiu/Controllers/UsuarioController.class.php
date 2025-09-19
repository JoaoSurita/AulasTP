<?php
	require_once "Models/Usuarios.class.php";
	class UsuarioController
	{
		public function login()
		{
			//require views formulário
			if($_POST)
			{
				//verificar os dados
				//verificar no banco de dados se existe esse usuário
			}
		}//fim do login
		public function inserir()
		{
			$msg = array("","","","");
			$erro = false;
			if($_POST)
			{
				if(empty($_POST["nome"]))
				{
					$msg[0] = "Preencha o nome";
					$erro = true;
				}
				if(empty($_POST["email"]))
				{
					$msg[1] = "Preencha o email";
					$erro = true;
				}
				else
				{
					//verificar se já não tem um usuário com esse email cadastrado
					$usuario = new Usuarios(email:$_POST["email"]);
				}
				if(empty($_POST["senha"]))
				{
					$msg[2] = "Preencha o senha";
					$erro = true;
				}
				if(empty($_POST["celular"]))
				{
					$msg[3] = "Preencha o celular";
					$erro = true;
				}
				if(!$erro)
				{
					$usuario = new Usuarios(0,$_POST["nome"], $_POST["email"], $_POST["senha"], $_POST["celular"]);
					//cadastrar no banco de dados
				}
				
			}
			require_once "Views/form_usuario.php";
		}
	}//fim da classe
?>