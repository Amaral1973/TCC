# TCC
Arquivos de mobile e web, para suporte no TCC das turmas TDS - SENAI

Arquivos 

<a href="https://bit.ly/3IrcAV8">FlyoutPage</a>

<h1>Combobox Dinamico</h1>

$pesquisa = mysqli_query($conn, "SELECT * FROM projeto");
            $row = mysqli_num_rows($pesquisa);
            echo '<select class="form-select" name="projeto" style="width: 400px;">';
            if($row > 0){
                while($registro = $pesquisa-> fetch_array()){
                     echo '<option value="'.$registro['id'].'">'.$registro['projeto'].'</option>';
                }
            }
            echo '</select>';
