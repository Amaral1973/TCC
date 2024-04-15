![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)![CSS3](https://img.shields.io/badge/css3-%231572B6.svg?style=for-the-badge&logo=css3&logoColor=white)![HTML5](https://img.shields.io/badge/html5-%23E34F26.svg?style=for-the-badge&logo=html5&logoColor=white)![JavaScript](https://img.shields.io/badge/javascript-%23323330.svg?style=for-the-badge&logo=javascript&logoColor=%23F7DF1E)![PHP](https://img.shields.io/badge/php-%23777BB4.svg?style=for-the-badge&logo=php&logoColor=white)![GitHub](https://img.shields.io/badge/github-%23121011.svg?style=for-the-badge&logo=github&logoColor=white)

# TCC
Arquivos de mobile, web e C# com Windows Forms, para suporte no TCC das turmas TDS - SENAI

## Arquivos Mobile

<a href="https://bit.ly/3IrcAV8">=>FlyoutPage</a><br/>
<a href="https://bit.ly/3IrcAV8">=>RadioButton</a>

## Links

[Tutoriais do Xamarin.Forms](https://learn.microsoft.com/pt-br/xamarin/get-started/tutorials/)<br/>
[API WhatsApp](https://learn.microsoft.com/pt-br/xamarin/get-started/tutorials/)<br/>
[Gráficos no Xamarin](https://bertuzzi.medium.com/o-x-do-xamarin-forms-gr%C3%A1ficos-6b0f384de5c6)

## Combobox Dinamico
```
$pesquisa = mysqli_query($conn, "SELECT * FROM projeto");
$row = mysqli_num_rows($pesquisa);
echo '<select class="form-select" name="projeto" style="width: 400px;">';
    if($row > 0){
       while($registro = $pesquisa-> fetch_array()){
       echo '<option value="'.$registro['id'].'">'.$registro['projeto'].'</option>';
       }
   }
echo '</select>';
```

## Menu Dinamico
```
<?php
    $con = mysqli_connect("localhost","root","","babearia");
    if(!$con)
    {
       echo "erro";
    }
    $usuario = $_SESSION["user"];
    $pesquisa = mysqli_query($con, "SELECT cpf,tipo FROM usuario WHERE cpf=$usuario");
    $row = mysqli_num_rows($pesquisa);
    if($row > 0){
        while($registro = $pesquisa-> fetch_array()){
            $tipo = $registro['tipo'];
        }
    }
    if ($tipo == "admin") {
        echo "administrador";
    }
    elseif ($tipo == "funcionario") {
        echo "funcionario";
    }
    elseif ($tipo == "cliente") {
        echo "cliente";
    }
    else {
        echo "publico";
    }
?>
```
## Combobox Dinamico
```
$pesquisa = mysqli_query($conn, "SELECT * FROM projeto");
$row = mysqli_num_rows($pesquisa);
echo '<select class="form-select" name="projeto" style="width: 400px;">';
    if($row > 0){
       while($registro = $pesquisa-> fetch_array()){
       echo '<option value="'.$registro['id'].'">'.$registro['projeto'].'</option>';
       }
   }
echo '</select>';
```
