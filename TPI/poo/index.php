<?php
    //Criando um objeto

    //  include "usuario.php";
    //  include_once "usuario.php";
    //  require "usuario.php";
     require_once "usuario.php";

     $usuario1 = new Usuario("Maria", "maria@gmail.com", "m123");
     $usuario2 = new Usuario(email:"anonimo@gmail.com", senha:"anonimo");
 
     // echo "<pre>";
     // var_dump($usuario1);
     // echo "</pre>";
     // echo "<pre>";
     // var_dump($usuario2);
     // echo "</pre>";
 
     echo "Nome:{$usuario1->getNome()}<br>";
     echo "Email:{$usuario1->getEmail()}<br>";
     echo "Senha:{$usuario1->getSenha()}<br>";
 
     //Alterando os valores do atributo
     $usuario1->setNome("Maria da Silva");
     $usuario1->setEmail("mariasilva@gmai.com");
     $usuario1->setSenha("maria123");

     echo "<hr>";
     echo "Nome:{$usuario1->getNome()}<br>";
     echo "Email:{$usuario1->getEmail()}<br>";
     echo "Nome:{$usuario1->getSenha()}<br>";
?>