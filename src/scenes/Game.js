import { Scene } from 'phaser';

export class Game extends Scene
{
    constructor ()
    {
        super('Game');
        this.player;
    }

    preload() {
        this.load.image('player', 'assets/player.png')
    }

    create ()
    {
        this.player = this.physics.add.sprite(this.scale.width * 0.5, this.scale.height * 0.9, 'player');
        this.player.setCollideWorldBounds(true);
        this.cursors = this.input.keyboard.createCursorKeys();

        this.cameras.main.setBackgroundColor(0x00ff00);

        this.add.image(512, 384, 'background').setAlpha(0.5);
    }

    update() {
        // Réinitialiser la vélocité du joueur
        this.player.setVelocity(0);

        // Vérifier les touches enfoncées
        if (this.cursors.left.isDown) {
            this.player.setVelocityX(-160);  // Déplace vers la gauche
        }
        else if (this.cursors.right.isDown) {
            this.player.setVelocityX(160);   // Déplace vers la droite
        }
    }
}
