<?php
    require_once ('ultramsg.class.php');
	
$token="qxuntt4pxhb77j0n";
$instance_id="instance47747";
$client = new UltraMsg\WhatsAppApi($token,$instance_id);
	
$to="5544984198747"; 
$body="Teste mostrando para o Marcola e o Terrorista..."; 
$api=$client->sendChatMessage($to,$body);
print_r($api);
?>