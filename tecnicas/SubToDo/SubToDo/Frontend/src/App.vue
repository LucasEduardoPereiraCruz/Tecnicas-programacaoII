<template>
  <div>

    <h1>Cadastro de Serviços</h1>

    <div class="formulario">

      <div class="formulario-grupo">
        <label>Descrição</label>
        <input v-model="descricao" placeholder="Ex: Troca de Tela">
      </div>

      <div class="formulario-grupo">
        <label>Categoria</label>
        <input v-model="categoria" placeholder="Ex: Celular">
      </div>

      <div class="formulario-grupo">
        <label>Valor</label>
        <input type="number" v-model.number="valor">
      </div>

      <button @click="salvarServico">
        Cadastrar
      </button>

    </div>

    <hr>

    <table>

      <thead>
        <tr>
          <th>Descrição</th>
          <th>Categoria</th>
          <th>Valor</th>
        </tr>
      </thead>

      <tbody>

        <tr
          v-for="item in servicos"
          :key="item.id"
        >

          <td>{{ item.descricao }}</td>
          <td>{{ item.categoria }}</td>
          <td>R$ {{ item.valor }}</td>

        </tr>

      </tbody>

    </table>

  </div>
</template>

<script setup>

import { ref, onMounted } from "vue";
import axios from "axios";

const API_URL = "http://localhost:5017/api/Servicos";

const servicos = ref([]);

const descricao = ref("");
const categoria = ref("");
const valor = ref(0);

const buscarServicos = async () => {

    const resposta = await axios.get(API_URL);

    servicos.value = resposta.data;

}

const salvarServico = async () => {

    if(descricao.value.trim() == "" ||
       categoria.value.trim() == "")
    {
        alert("Preencha todos os campos!");
        return;
    }

    try{

        await axios.post(API_URL,{

            descricao: descricao.value,
            categoria: categoria.value,
            valor: valor.value

        });

        alert("Serviço cadastrado com sucesso!");

        descricao.value = "";
        categoria.value = "";
        valor.value = 0;

        // Atualiza automaticamente a tabela
        await buscarServicos();

    }
    catch(erro){

        console.error("Erro ao cadastrar", erro);

    }

};


onMounted(buscarServicos);

</script>