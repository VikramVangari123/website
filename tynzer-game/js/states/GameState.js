//this game will have only 1 state
var GameState = {

  init: function() {
    //adapt to screen size, fit all the game
    this.scale.scaleMode = Phaser.ScaleManager.SHOW_ALL;
    this.scale.pageAlignHorizontally = true;
    this.scale.pageAlignVertically = true;

    this.game.physics.startSystem(Phaser.Physics.ARCADE);
  },

  //executed after everything is loaded
  create: function() {
    this.background = this.game.add.sprite(0, 0, 'backyard');
    this.background.inputEnabled = true;
    this.background.events.onInputDown.add(this.placeItem, this);

    this.clock = this.game.add.sprite(10, 10, 'clock');
    this.score = this.game.add.sprite(300, 10, 'score');

    this.replay = this.game.add.sprite(330, 610, 'replay');


    this.weed1_1 = this.game.add.sprite(200, 220, 'weed1');
    this.game.physics.arcade.enable(this.weed1_1);
    this.weed2_1 = this.game.add.sprite(20, 290, 'weed2');
    this.game.physics.arcade.enable(this.weed2_1);
    this.weed1_2 = this.game.add.sprite(140, 450, 'weed1');
    this.game.physics.arcade.enable(this.weed1_2);
    this.weed2_2 = this.game.add.sprite(260, 330, 'weed2');
    this.game.physics.arcade.enable(this.weed2_2);

    this.weed1_3 = this.game.add.sprite(87, 340, 'weed1');
    this.game.physics.arcade.enable(this.weed1_3);
    this.weed2_3 = this.game.add.sprite(140, 270, 'weed2');
    this.game.physics.arcade.enable(this.weed2_3);

    var group = this.game.add.group();

    group.createMultiple(9, 'corn', [0, 1, 2, 3], true);

    group.align(6, -1, 60, 60, Phaser.CENTER);

    group.x = 0;
    group.y = 220;


    this.bow = this.game.add.sprite(this.game.world.centerX, 600, 'bow');
    this.bow.anchor.setTo(0.5);

    this.arrow = this.game.add.sprite(this.game.world.centerX, 580, 'arrow');
    this.arrow.anchor.setTo(0.5);
    this.game.physics.arcade.enable(this.arrow, Phaser.Physics.ARCADE);
    this.arrow.body.allowRotation = false;


    //nothing is selected
    this.selectedItem = null;

    //the user interface (UI) is not blocked at the start
    this.uiBlocked = false;

    var style = { font: '14px Arial', fill: '#fff'};
    this.gameScore = 0;
    this.funText = this.game.add.text(330, 18, '00', style);

    this.funText.text = this.gameScore;
    game1 = this;
    //decrease the health every 5 seconds
    this.statsDecreaser = this.game.time.events.loop(Phaser.Timer.SECOND * 30, this.gameOver, this);

  },
  pickItem: function(sprite, event) {

    //if the UI is blocked we can't pick an item
    if(!this.uiBlocked) {
      console.log('pick item');

      this.clearSelection();

      //alpha to indicate selection
      sprite.alpha = 0.4;

      this.selectedItem = sprite;
    }
  },
  clearSelection: function() {

    //remove transparency from all buttons
    this.buttons.forEach(function(element, index){
      element.alpha = 1;
    });

    //we are not selecting anything now
    this.selectedItem = null;
  },
  killWeed: function(arrow, weed) {
    weed.destroy();
    console.log(game1.gameScore);
    game1.funText.text = (game1.gameScore+=1).toString();

  },
  placeItem: function(sprite, event) {
    if(!this.uiBlocked) {
      var x = event.position.x;
      var y = event.position.y;

      var arrowMovement = this.game.add.tween(this.arrow);

      arrowMovement.to({x: x, y: y}, 600);


      arrowMovement.start();

      this.uiBlocked = true;

      arrowMovement.onComplete.add(function(){

        arrowMovement.to( {alpha: 0 }, 2000);
        arrowMovement.start();

        //destroy the apple/candy/duck
        this.arrow.destroy();
        //

        this.arrow = this.game.add.sprite(this.game.world.centerX, 580, 'arrow');
        this.arrow.anchor.setTo(0.5);
        this.game.physics.arcade.enable(this.arrow, Phaser.Physics.ARCADE);
        this.arrow.body.allowRotation = false;

        //release the ui
        this.uiBlocked = false;


      }, this);

    }

  },
  //executed multiple times per second
  update: function() {
    game1.arrow.rotation = game.physics.arcade.angleToPointer(game1.arrow);
    this.game.physics.arcade.collide(this.arrow, this.weed1_1, this.killWeed);
    this.game.physics.arcade.collide(this.arrow, this.weed2_1, this.killWeed);
    this.game.physics.arcade.collide(this.arrow, this.weed1_2, this.killWeed);
    this.game.physics.arcade.collide(this.arrow, this.weed2_2, this.killWeed);
    this.game.physics.arcade.collide(this.arrow, this.weed1_3, this.killWeed);
    this.game.physics.arcade.collide(this.arrow, this.weed2_3, this.killWeed);

  },
  gameOver: function() {
    this.state.start('HomeState', true, false, game1.gameScore);
  }


};
