<template>
  <div>
    <h1>Minhas Tarefas</h1>
    <input v-model="tituloTarefa" placeholder="Digite o Título da Tarefa">
    <textarea v-model="descricaoTarefa" placeholder="Digite a descrição da Tarefa"></textarea>
    <button @click="adicionarTarefa">Adicionar</button>
    <ul>
      <li v-for="item in tarefas":key="item.id">{{ item.titulo }} - {{ item.concluida ?"Concluída": "Aguardando" }}</li>
    </ul>
  </div>
</template>
<script setup>
  import { ref, onMounted } from 'vue';
  import axios from "axios";
  const tarefas = ref([]);
  const tituloTarefa = ref("");
  const descricaoTarefa = ref("");
  const API_URL = "http://localhost:5081/api/tarefas"
  const buscarTarefas = async()=>{
    const resposta = await axios.get(API_URL);
    tarefas.value = resposta.data;
  };
  const adicionarTarefa = async()=>{
    if (!tituloTarefa.value && !descricaoTarefa.value) return;
    await axios.post(API_URL, {
      titulo : tituloTarefa.value,
      descricao: descricaoTarefa.value,
      concluida: false
    });
    tituloTarefa.value = "";
    descricaoTarefa.value = "";
    buscarTarefas();
  }
  onMounted(buscarTarefas);
</script>