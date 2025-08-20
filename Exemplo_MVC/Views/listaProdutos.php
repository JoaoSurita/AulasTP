<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Lista de Produtos</title>
</head>
<body>
    <h1>Produtos</h1>
    <a href="index.php?controle=produtoController&metodo=inserir">Novo Produto</a>
    <table style="border: 1px solid grey;">
        <tr>
            <th>Produto</th>
            <th>Preço</th>
            <th>Estoque</th>
            <th>Ações</th>
        </tr>
    <?php
        foreach($resultado as $dado) {
            $preco = number_format($dado->preco, 2, ",", ".");
            echo "<tr>
                <td>{$dado->nome}</td>
                <td>$preco</td>
                <td>{$dado->estoque}</td>
                <td>
                    <a href='index.php?controle=produtoController&metodo=alterar&id={$dado->id_produto}'>Alterar</a>&nbsp;&nbsp;
                    <a href='index.php?controle=produtoController&metodo=excluir&id={$dado->id_produto}'>Excluir</a>&nbsp;&nbsp
                </td>
                </tr>";
        }
    ?>
    </table>
</body>
</html>