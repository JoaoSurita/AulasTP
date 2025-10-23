<?php
require_once 'PHPMailer/PHPMailer/PHPMailer.php';
require_once 'PHPMailer/PHPMailer/SMTP.php';
require_once 'PHPMailer/PHPMailer/Exception.php';

use PHPMailer\PHPMailer\PHPMailer;
use PHPMailer\PHPMailer\Exception;
use PHPMailer\PHPMailer\SMTP;

function sendMail($assunto, $mensagem, $remetente, $nomeRemetente, $destino, $nomeDestino)
{
	try
	{
		$mail = new PHPMailer(true); //INICIA A CLASSE

		$mail->IsSMTP(); //Habilita envio SMTP
		$mail->SMTPAuth = true; //Ativa email autenticado
		$mail->Host = 'smtp.gmail.com'; 
		//$mail->SMTPDebug = 1;  // debugging: 1 = errors and messages, 2 = messages only
		$mail->SMTPSecure = 'ssl'; // secure transfer enabled REQUIRED for GMail
		$mail->Port = 465; 
		$mail->Username = $email_username;
		$mail->Password = $email_password;
		/*
		HOTMAIL
		Host: smtp.live.com
		Port: 587
		SMTPSecure: tls
		Desbloqueio no Servidor: Não é necessário
		*/
		$mail->From = $remetente; //Remetente
		$mail->FromName = utf8_decode($nomeRemetente); //Remetente nome

		$mail->IsHTML(true);

		$mail->Subject = utf8_decode($assunto); //Assunto
		$mail->Body = utf8_decode($mensagem); //Mensagem
		$mail->AddAddress($destino,utf8_decode($nomeDestino)); //Email e nome do destino - repetir essa linha se for enviar para mais do que um destinatario
		//$mail->AddCC('ciclano@site.net', 'Ciclano'); // Copia 
		//$mail->AddBCC('beltrano@site.net', 'Beltrano'); // Cópia Oculta 
		// Define os anexos (opcional) 
		//$mail->AddAttachment("../images/carrinho.jpg");  // Insere um anexo 

		$ret = $mail->Send();
		// Limpa os destinatários e os anexos
		$mail->ClearAllRecipients();
		$mail->ClearAttachments();
		return true;
	}
	catch(Exception $e)
	{
		return false;
	}
}
?>