import { Scene } from 'phaser';
import Player from '../classes/player.js'

export class Game extends Scene
{
    constructor ()
    {
        super('Game');
        this.player;
    }

    preload () 
    {
        this.load.image('player', '../../public/assets/player.png')
    }

    create ()
    {
        this.player = new Player(this, this.scale.width * 0.5, this.scale.height * 0.9, 'player');

        this.cameras.main.setBackgroundColor(0x00ff00);

        this.cursors = this.input.keyboard.createCursorKeys();
    }

    update() {
        this.player.move(this.cursors);
    }
}
