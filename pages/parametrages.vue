<script setup lang="ts">
</script>

<template>
  <div class="u-flex u-flex-direction-column u-gap30">
    <h1>Paramétrages</h1>

    <form class="border u-flex u-flex-direction-column u-align-self-center u-gap20">
      <div class="u-flex u-p20 u-justify-content-center u-gap50">
        <h2 class="u-flex u-justify-content-center">Type</h2>
        <div class="vertical-align u-flex u-justify-content-center u-gap5">
          <input type="radio" id="2048" name="type" value="2048" />
          <label for="mode">2048</label>
        </div>
        <div class="vertical-align u-flex u-justify-content-center u-gap5">
          <input type="radio" id="Infini" name="type" value="Infini" />
          <label for="mode">Infini</label>
        </div>
      </div>
      <div class="u-flex u-justify-content-center u-gap20">
        <h2>Taille du plateau</h2>
        <div class="vertical-align u-flex u-justify-content-center u-gap5">
          <input type="radio" id="4x4" name="taille" value="4x4" />
          <label for="taille">4x4</label>
        </div>
        <div class="vertical-align u-flex u-justify-content-center u-gap5">
          <input type="radio" id="5x5" name="taille" value="5x5" />
          <label for="taille">5x5</label>
          <div class="vertical-align u-flex u-justify-content-center u-gap5">
            <input type="radio" id="6x6" name="taille" value="6x6" />
            <label for="taille">6x6</label>
          </div>
          <div class="vertical-align u-flex u-justify-content-center u-gap5">
            <input type="radio" id="7x7" name="taille" value="7x7" />
            <label for="taille">7x7</label>
          </div>
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
  font-size: 2vw;

}

h1 {
  background-color: #bbada0;
  padding: 30px;
  font-size: 3.5vw;
  text-align: center;
}


h2 {
  font-size: 2.5vw;
}

.beige-button, .red-button {
  color: black;
  border: none;
  padding: 10px 20px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  font-size: 1vw;
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
  font-size: 3.5vw;
  text-align: center;
}

h2 {
  font-size: 1.5vw;
  text-align: center;
}

input, select {
  font-size: 1.5vw;
}

.vertical-align {
  display: flex;
  align-items: center;
}

/* Media Queries for Responsiveness */
@media (max-width: 1300px) {
  .border {
    padding: 20px;
    font-size: 24px;
  }

  h1 {
      font-size: 32px;
  }

  h2 {
    font-size: 20px;
  }

  input, select {
    font-size: 20px;
  }

  .beige-button, .red-button {
    font-size: 16px;
    padding: 8px 16px;
  }
}

@media (max-width: 480px) {
  .border {
    padding: 10px;
    font-size: 16px;
  }

  h1 {
    font-size: 24px;
  }

  h2 {
    font-size: 16px;
  }

  input, select {
    font-size: 16px;
  }

  .beige-button, .red-button {
    font-size: 14px;
    padding: 6px 12px;
  }
}
</style>