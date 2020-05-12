var HomeState = {

  init: function(message) {
    this.message = message;
  },

  create: function() {
    var background = this.game.add.sprite(0,0,'backyard');
    background.inputEnabled = true;

    this.clock = this.game.add.sprite(10, 10, 'clock');
    this.score = this.game.add.sprite(300, 10, 'score');

    background.events.onInputDown.add(function(){
      this.state.start('GameState');
    }, this);

    var style = {font: '35px Arial', fill: '#fff'};
    this.game.add.text(30, this.game.world.centerY + 200, 'TOUCH TO START', style);

    if(this.message) {
      this.game.add.text(60, this.game.world.centerY - 200, "GAME OVER", style);
      this.game.add.text(60, this.game.world.centerY - 100, "Your Score: " + this.message, style);
    }
  }
};
