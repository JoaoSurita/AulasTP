<?php
	require_once "Models/Conexao.class.php";
	require_once "Models/Usuarios.class.php";
	require_once "Models/Pet.class.php";
	require_once "Models/petDAO.class.php";
	
	if(!isset($_SESSION))
	{
		session_start();
	}
	
	class petController
	{
		public function inserir()
		{
			$msg = array("","","","","","","");
			if($_POST)
			{
				$erro = false;
				if($_POST["porte"] == 0)
				{
					$msg[0] = "Preencha o porte do pet";
					$erro = true;
				}
				
				if(empty($_POST["local"]))
				{
					$msg[1] = "Preencha onde o pet foi encontrado ou perdido";
					$erro = true;
				}
				if(empty($_POST["data"]))
				{
					$msg[2] = "Preencha a data em que o pet foi encontrado ou perdido";
					$erro = true;
				}
				
				if(empty($_POST["cor_olhos"]))
				{
					$msg[3] = "Preencha a cor dos olhos do pet";
					$erro = true;
				}
				
				if(empty($_POST["cor"]))
				{
					$msg[4] = "Preencha as cores do pet";
					$erro = true;
				}
				
				if(!isset($_POST["situacao"]))
				{
					$msg[5] = "Escolha a situação";
					$erro = true;
				}
					
				
				if($_FILES["imagem"]["name"] == "")
				{
					$msg[6] = "Selecione a imagem do pet";
					$erro = true;
				}
				else
				{
					if($_FILES["imagem"]["type"] != "image/png" &&    $_FILES["imagem"]["type"] != "image/jpg" && 
					$_FILES["imagem"]["type"] != "image/jpeg")
					{
						$msg[6] = "Tipo de imagem invalido";
						$erro = true;
					}
				}
				
				if(!$erro)
				{
					//inserir no BD - instanciar os objetos
					$usuario = new Usuarios($_SESSION["id"]);
					
					$pet = new Pet(0,$_POST["nome"], $_POST["idade"], $_POST["raca"],$_POST["porte"],$_POST["local"], $_POST["data"], $_FILES["imagem"]["name"], $_POST["cor_olhos"], $_POST["cor"],
					$_POST["observacoes"], $_POST["situacao"], $usuario);
						
					$petDAO = new petDAO();
					
					$petDAO->inserir($pet);
					//fazer upload da imagem
					
					header("location:index.php");
					die();
					
				}
				
			}//fim if post
			
			require_once "Views/form_pet.php"; 
		}
		public function alterar()
		{
		}
		public function mudar_situacao()
		{
		}
		public function listar()
		{
		}
		
	}//fim classe
?>