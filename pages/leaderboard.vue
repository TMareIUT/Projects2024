<template>
  <div :class="['leaderboard-container', { dark: isDarkMode }]">
    <div class="button-container">
      <button @click="restartGame" class="btn">Rejouer</button>
      <button @click="goToSettings" class="btn">Nouvelle partie</button>
      <button @click="toggleDarkMode" class="btn toggle-btn">
        {{ isDarkMode ? 'Mode Clair' : 'Mode Sombre' }}
      </button>
    </div>

    <table class="leaderboard-table">
      <thead>
        <tr>
          <th>Rank</th>
          <th>Pseudo</th>
          <th>Score</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="(player, index) in players" :key="index">
          <td>{{ index + 1 }}</td>
          <td>{{ player.name }}</td>
          <td>{{ player.score }}</td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<script>
export default {
  data() {
    return {
      players: [
        { name: 'Alice', score: 100 },
        { name: 'Bob', score: 80 },
        { name: 'Charlie', score: 60 },
      ],
      isDarkMode: false, // Ajout de la propriété pour le mode sombre
    };
  },
  methods: {
    restartGame() {
      alert('Le jeu redémarre !');
      // Rediriger vers la page de jeu si nécessaire
    },
    goToSettings() {
      this.$router.push('/settings');
    },
    toggleDarkMode() {
      this.isDarkMode = !this.isDarkMode; // Basculer entre les modes
    },
  }
};
</script>

<style scoped>
.leaderboard-container {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  max-width: 800px;
  margin: 0 auto;
  padding: 20px;
  border-radius: 8px;
  box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
  text-align: center;
  margin-top: 13%;
  background-color: #f9f9f9; /* Couleur de fond par défaut (mode clair) */
  transition: background-color 0.3s, color 0.3s; /* Transition pour le changement de couleur */
}

.dark {
  background-color: #333; /* Couleur de fond en mode sombre */
  color: #f9f9f9; /* Couleur de texte en mode sombre */
}

h1 {
  font-family: 'Arial', sans-serif;
  color: inherit;
  margin-bottom: 20px;
}

.button-container {
  margin-bottom: 20px;
  display: flex;
  justify-content: center;
}

.btn {
  padding: 10px 20px;
  margin: 0 5px;
  background-color: #007bff;
  color: white;
  border: none;
  border-radius: 5px;
  cursor: pointer;
  font-size: 16px;
  transition: background-color 0.3s, transform 0.2s;
}

.btn:hover {
  background-color: #0056b3;
  transform: translateY(-2px);
}

.toggle-btn {
  background-color: #28a745; /* Couleur du bouton toggle */
}

.toggle-btn:hover {
  background-color: #218838; /* Couleur au survol */
}

.leaderboard-table {
  width: 100%;
  border-collapse: collapse;
}

.leaderboard-table th, .leaderboard-table td {
  border: 1px solid #ddd;
  padding: 12px;
  text-align: left;
}

.leaderboard-table th {
  background-color: #007bff;
  color: white;
  font-weight: bold;
}

.leaderboard-table tr:nth-child(even) {
  background-color: #f2f2f2;
}

.leaderboard-table tr:hover {
  background-color: #e9ecef;
}

.dark .leaderboard-table th {
  background-color: #0056b3; /* Couleur des en-têtes en mode sombre */
}

.dark .leaderboard-table tr:nth-child(even) {
  background-color: #444; /* Couleur des lignes paires en mode sombre */
}

.dark .leaderboard-table tr:hover {
  background-color: #555; /* Couleur des lignes au survol en mode sombre */
}
</style>
