import { Scene } from 'phaser';

export class MainMenu extends Scene {
    constructor () {
        super('MainMenu');
    }

    create () {
        let background = this.add.image(0, 0, 'background')
        .setOrigin(0, 0)  // Place l'origine en haut à gauche
        .setDisplaySize(window.innerWidth, window.innerHeight);

        this.add.image(window.innerWidth / 2, window.innerHeight / 2, 'logo')
            .setOrigin(0.5);

        this.add.text(window.innerWidth / 2, window.innerHeight / 2 + 160, 'Menu Principal', {
            fontFamily: 'Arial Black', fontSize: 38, color: '#ffffff',
            stroke: '#000000', strokeThickness: 8,
            align: 'center'
        }).setOrigin(0.5);

        this.input.once('pointerdown', () => {
            this.scene.start('Game');
        });
    }
}
