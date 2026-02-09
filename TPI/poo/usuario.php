<?php
    // class Usuario {
    //     public function __construct(public string $nome = "",
    //         public string $email = "",
    //         public string $senha = "" /*Não é necessário tipar*/) {}
    // }

    class Usuario {
        public function __construct(private string $nome = "",
            private string $email = "",
            private string $senha = "" /*Não é necessário tipar*/) {}

        public function getNome()
        {
            return $this->nome;
        }

        public function getEmail()
        {
            return $this->email;
        }

        public function getSenha()
        {
            return $this->senha;
        }

        public function setNome($nome)
        {
            $this->nome = $nome;
        }

        public function setEmail($email)
        {
            $this->email = $email;
        }

        public function setSenha($senha)
        {
            $this->senha = $senha;
        }
    } //Fim da classe
?>