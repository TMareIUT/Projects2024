// plugins/pixi.js
import * as PIXI from 'pixi.js';

export default (_: any, inject: (key: string, value: any) => void) => {
    inject('pixi', PIXI);
};