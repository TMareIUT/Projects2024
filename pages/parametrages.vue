<script setup lang="ts">

</script>

<template>
  <div class="u-flex u-flex-direction-column u-align-content-center">
    <h1>Paramétrages</h1>
    <h2>Taille du plateau</h2>
    <h2>Mode</h2>
    <input type="radio" class="mode">
    <label for="mode">2048</label>
    <input type="radio" class="mode">
    <label for="mode">Infini</label>
  </div>
  <div class="u-flex u-justify-content-end">
    <NuxtLink to="/">Retour</NuxtLink>
    <NuxtLink to="/jeu"> Confirmer</NuxtLink>
  </div>
</template>

<style scoped>
</style>