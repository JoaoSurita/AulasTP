<?php
    if($_GET) {
        //Outras rotas
        $controle = $_GET["controle"];
        $metodo = $_GET["metodo"];
        require_once "Controllers/$controle.class.php";
        $obj = new $controle();
        $obj->$metodo();
    } else {
        // Rota inicial
        require_once "Controllers/inicioController.class.php";
        $obj = new inicioController();
        $obj->inicio();
    }

?>