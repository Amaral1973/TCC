# TCC
Arquivos de mobile e web, para suporte no TCC das turmas TDS - SENAI

Arquivos 

<a href="https://bit.ly/3IrcAV8">FlyoutPage</a>

## Combobox Dinamico

$pesquisa = mysqli_query($conn, "SELECT * FROM projeto");</br>
            $row = mysqli_num_rows($pesquisa);</br>
            echo '<select class="form-select" name="projeto" style="width: 400px;">';</br>
            if($row > 0){</br>
                while($registro = $pesquisa-> fetch_array()){</br>
                     echo '<option value="'.$registro['id'].'">'.$registro['projeto'].'</option>';</br>
                }</br>
            }</br>
            echo '</select>';</br>
