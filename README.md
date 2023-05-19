![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)![CSS3](https://img.shields.io/badge/css3-%231572B6.svg?style=for-the-badge&logo=css3&logoColor=white)![HTML5](https://img.shields.io/badge/html5-%23E34F26.svg?style=for-the-badge&logo=html5&logoColor=white)![JavaScript](https://img.shields.io/badge/javascript-%23323330.svg?style=for-the-badge&logo=javascript&logoColor=%23F7DF1E)![PHP](https://img.shields.io/badge/php-%23777BB4.svg?style=for-the-badge&logo=php&logoColor=white)![GitHub](https://img.shields.io/badge/github-%23121011.svg?style=for-the-badge&logo=github&logoColor=white)

# TCC
Arquivos de mobile e web, para suporte no TCC das turmas TDS - SENAI

## Arquivos Mobile:alien:

<a href="https://bit.ly/3IrcAV8">FlyoutPage</a>
<a href="https://bit.ly/3IrcAV8">RadioButton</a>

## Links:alien:

<a href="https://learn.microsoft.com/pt-br/xamarin/get-started/tutorials/">Tutoriais do Xamarin.Forms</a>

## Combobox Dinamico:alien:
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
