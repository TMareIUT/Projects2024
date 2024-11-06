<script setup lang="ts">

</script>

<template>
  <div class="u-flex u-flex-direction-column u-gap30">
    <h1>Paramétrages</h1>

    <form class="border u-flex u-flex-direction-column u-align-self-center u-gap20">
      <div class="u-flex u-justify-content-center u-gap20">
        <h2>Taille du plateau</h2>
          <input type="number" id="size" name="size" min="4" max="10">
      </div>

      <div class="u-flex u-p20 u-justify-content-center u-gap50">
        <h2 class="u-flex u-justify-content-center">Type</h2>
        <div class="vertical-align u-flex u-justify-content-center u-gap5">
          <input type="radio" class="mode">
          <label for="mode">2048</label>
        </div>
        <div class="vertical-align u-flex u-justify-content-center u-gap5">
          <input type="radio" class="mode">
          <label for="mode">Infini</label>
        </div>
      </div>
      <div class="u-flex u-justify-content-center u-gap20">
        <NuxtLink to="/" class="red-button">Retour</NuxtLink>
        <NuxtLink to="/jeu" class="beige-button"> Confirmer</NuxtLink>
      </div>
    </form>
  </div>

</template>

<style scoped>

.border {
  border: 1px solid lightgray;
  border-radius: 8px;
  margin: 20px;
  padding: 50px;
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
  font-size: 30px;

  h2 {
    font-size: 50px;
  }
}

.beige-button, .red-button {
  color: black;
  border: none;
  padding: 10px 20px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  font-size: 16px;
  cursor: pointer;
  border-radius: 8px;
}

.beige-button {
  background-color: #bbada0;
}

.red-button {
  background-color: red;
}

h1 {
  background-color: #bbada0;
  padding: 30px;
  font-size: 70px;
  text-align: center;
}

h2 {
  font-size: 25px;
  text-align: center;
}

.vertical-align {
  display: flex;
  align-items: center;
}

</style>