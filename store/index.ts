import { defineStore } from 'pinia'

export const useMainStore = defineStore('main', {
    state: () => ({
        gameType: '',
        boardSize: '',
    }),

    actions: {
        setGameType(gameType) {
            this.gameType = gameType;
        },
        setBoardSize(boardSize) {
            this.boardSize = boardSize;
        },
        updateGameSettings({ gameType, boardSize }) {
            this.setGameType(gameType);
            this.setBoardSize(boardSize);
        },
    },
})
