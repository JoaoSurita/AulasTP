<?php
	class Pet
	{
		public function __construct(
			private int    $id_pet = 0,
			private string $nome = "",
			private string $idade = "",
			private string $raca = "",
			private string $porte = "",
			private string $local = "",
			private string $data = "",
			private string $imagem = "",
			private string $cor_olhos = "",
			private string $cor = "",
			private string $observacoes = "",
			private string $situacao = "",
			private Usuarios $usuario = new Usuarios()){}
		
			public function getNome()
			{
				return $this->nome;
			}
			public function getIdade()
			{
				return $this->idade;
			}
			public function getPorte()
			{
				return $this->porte;
			}
			public function getRaca()
			{
				return $this->raca;
			}
			public function getImagem()
			{
				return $this->imagem;
			}
			public function getCor()
			{
				return $this->cor;
			}
			public function getCor_olhos()
			{
				return $this->cor_olhos;
			}
			public function getObservacoes()
			{
				return $this->observacoes;
			}
			public function getLocal()
			{
				return $this->local;
			}
			public function getData()
			{
				return $this->data;
			}
			public function getUsuario()
			{
				return $this->usuario;
			}
			public function getId_pet()
			{
				return $this->id_pet;
			}
			public function getSituacao()
			{
				return $this->situacao;
			}
			
	}//fim da classe
?>