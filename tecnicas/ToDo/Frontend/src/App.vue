<template>
  <div>
    <h1>Minhas Tarefas</h1>
    <div class="formulario">
  
  <div class="formulario-grupo">
    <label>O que precisa ser feito?</label>
    <input v-model="tituloTarefa" placeholder="Ex: Estudar C#..." />
  </div>

  <div class="formulario-grupo">
    <label>Detalhes (Opcional)</label>
    <textarea v-model="descricaoTarefa" placeholder="Ex: Ler o artigo sobre Repository Pattern..."></textarea>
  </div>

  <button @click="salvarTarefa" class="btn-salvar">
    <span>Salvar</span>
  </button>

</div>
    <table class="tabela-tarefas">
  <thead>
    <tr>
      <th>Título</th>
      <th>Descrição</th>
      <th>Status</th>
      <th>Ações</th> </tr>
  </thead>
  <tbody>
    <tr v-for="item in tarefas" :key="item.id">
      <td>{{ item.titulo }}</td>
      <td>{{ item.descricao || 'Sem descrição' }}</td>
      <td>
        <span :class="item.cancelado ? 'status-cancelado' : 'status-ativo'">
          {{ item.cancelado ? "Cancelada" : "Ativa" }}
        </span>
      </td>
      
      <td>
  <div class="acoes-col">
    <!--item vem do v-for e contem um objeto tarefa-->
    <button @click="alternarCancelado(item)" 
            :class="['btn-circular', item.cancelado ? 'btn-reabrir' : 'btn-cancelar']" 
            :title="item.cancelado ? 'Ativar tarefa' : 'Cancelar tarefa'">
      <i :class="item.cancelado ? 'fa-solid fa-rotate-left' : 'fa-solid fa-check'"></i>
    </button>

    <button @click="prepararEdicao(item)" 
            class="btn-circular btn-editar" 
            title="Editar tarefa">
      <i class="fa-solid fa-pen-to-square"></i>
    </button>

    <button @click="deletarTarefa(item.id)" 
            class="btn-circular btn-deletar" 
            title="Excluir tarefa">
      <i class="fa-solid fa-trash-can"></i>
    </button>
  </div>
</td>
    </tr>
  </tbody>
</table>
  </div>
</template>


<script setup>
import { ref, onMounted } from "vue";
import axios from "axios";


const tarefas = ref([]);
const tituloTarefa = ref('');
const descricaoTarefa = ref('');
const idTarefaEmEdicao = ref(null); 

const API_URL = "http://localhost:5144/api/tarefas";

const buscarTarefas = async () => {
  try {
    const resposta = await axios.get(API_URL);
    tarefas.value = resposta.data;
    console.log(tarefas.value);
  } catch (erro) {
    console.error("Erro ao buscar tarefas:", erro);
  }
};

const salvarTarefa = async () => {
  if (!tituloTarefa.value) return; // Só valida o título (descrição é opcional)

  const dadosTarefa = {
    titulo: tituloTarefa.value,
    descricao: descricaoTarefa.value,
    cancelado: false 
  };

  try {
    if (idTarefaEmEdicao.value) {
      // Se tem ID guardado, fazemos um PUT para atualizar a tarefa toda
      await axios.put(`${API_URL}/${idTarefaEmEdicao.value}`, dadosTarefa);
      idTarefaEmEdicao.value = null; 
    } else {
      // Se não tem ID, é uma tarefa nova (POST)
      await axios.post(API_URL, dadosTarefa);
    }

    // Limpa os campos da tela
    tituloTarefa.value = "";
    descricaoTarefa.value = "";
    buscarTarefas(); // Recarrega a tabela
  } catch (erro) {
    console.error("Erro ao salvar tarefa:", erro);
  }
};

//edição da tarefa
const prepararEdicao = (item) => {
  tituloTarefa.value = item.titulo;
  descricaoTarefa.value = item.descricao;
  idTarefaEmEdicao.value = item.id; 
};

// deletar tarefa
const deletarTarefa = async (id) => {
  if (confirm("Tem certeza que deseja excluir permanentemente esta tarefa?")) {
    try {
      await axios.delete(`${API_URL}/${id}`);
      buscarTarefas();
    } catch (erro) {
      console.error("Erro ao deletar tarefa:", erro);
    }
  }
};

// alterar cancelado
const alternarCancelado = async (item) => {
  try {
    // Inverte o valor atual do booleano cancelado
    // se está true vira false e vice-versa
    const novoStatus = !item.cancelado;

    // Faz o PATCH enviando o ID na URL e o booleano puro no corpo
    await axios.patch(`${API_URL}/${item.id}`, novoStatus, {
      headers: { 'Content-Type': 'application/json' }
    });

    buscarTarefas();
  } catch (erro) {
    console.error("Erro ao alternar status:", erro);
  }
};
onMounted(buscarTarefas);
</script>