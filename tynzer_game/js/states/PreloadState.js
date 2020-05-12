var PreloadState = {
	//load the game assets before the game starts
  preload: function() {

    this.logo = this.add.sprite(this.game.world.centerX, this.game.world.centerY, 'logo');
    this.logo.anchor.setTo(0.5);

    this.preloadBar = this.add.sprite(this.game.world.centerX, this.game.world.centerY + 128, 'preloadBar');
    this.preloadBar.anchor.setTo(0.5);
    this.load.setPreloadSprite(this.preloadBar);

    this.load.image('backyard', 'assets/images/backyard.png');
    this.load.image('arrow', 'assets/images/arrow.png');
    this.load.image('bow', 'assets/images/bow.png');
    this.load.image('corn', 'assets/images/corn.png');
    this.load.image('weed1', 'assets/images/weed1.png');
    this.load.image('weed2', 'assets/images/weed2.png');
    this.load.image('score', 'assets/images/gold_coin.png');
    this.load.image('clock', 'assets/images/clock.png');
    this.load.image('replay', 'assets/images/replay.png');
    this.load.spritesheet('pet', 'assets/images/pet.png', 97, 83, 5, 1, 1);
  },
  create: function() {
    this.state.start('HomeState');
  }
};
