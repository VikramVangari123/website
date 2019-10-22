
$(function() {

    $(".tab1").click(function(){               
        $('.content1').addClass("active-tab");
    });
    // menu
    //  (window width greater than 1024px)
    if ($(window).innerWidth() >= 1025) {
        // $('.mega-menu').on('mouseover', '.megamenu-item', function() {
        //     $(this).addClass('active').siblings().removeClass('active');
        // });
        $('.megamenu-sub-menu').on('mouseover', 'li', function() {
            $(this).addClass('hover-active').removeClass('hover-not-active').siblings().addClass('hover-not-active').removeClass('hover-active');
		});
		$('.megamenu-sub-menu').children().first().addClass('active').siblings().removeClass('active');
		$('.industry .megamenu-sub-menu').children().first().addClass('active').siblings().removeClass('active');
		$('.business-area .megamenu-sub-menu').children().first().next().addClass('active').siblings().removeClass('active');
		
	}
	
    else{
        $("h5 .sub-menu-arrow").click(function(){               
            $(this).parent().parent('.megamenu-item').toggleClass("active-submenu").siblings().removeClass("active-submenu").children().removeClass("active-submenu");
        });
        $("li .sub-menu-arrow").click(function(){
            $(this).parent('.megamenu-sub-menu li').toggleClass("active-submenu").siblings().removeClass("active-submenu");  
        });
		$(".industry .mega-menu .megamenu-item").first().toggleClass("active-submenu").siblings().removeClass("active-submenu");
        $(".business-area .mega-menu .megamenu-item").first().toggleClass("active-submenu").siblings().removeClass("active-submenu");
        
        $(".openNav").click(function(){
            $('.mega-menu .active').removeClass("active");                    
            //$('.active-submenu').removeClass("active-submenu");      
        });
    }   
	
        // sticky header
        $(window).scroll(function() {    
            var scroll = $(window).scrollTop();
        
            if (scroll >= 150) {
                $("header").addClass("fixedheader");
            } else {
                $("header").removeClass("fixedheader");
            }
            return false;
        });
        $(window).on('load', function() {    
            var scroll = $(window).scrollTop();
        
            if (scroll >= 150) {
                $("header").addClass("fixedheader");
            } else {
                $("header").removeClass("fixedheader");
            }
            return false;
        });
    
        //section height
       $('.full-height').css({
          'height': (($(window).height())) + 'px'
        });
        $(window).bind('resize', function() {
          $('.full-height').css({
              'height': (($(window).height())) + 'px'
          });
        });
        if ($(window).innerWidth() >= 767) {
            $('.case-study .fp-sliderSec').css({
                'height': (($(window).height())) + 'px'
            });
        };

        // section inner full height
        var sectionHeight = $('.section').height();
		// $('.section-in').css('height', (sectionHeight) + 'px');

        // testimonial 
        var sliderblockHeight = $('.sliderblock-cont').height();
        $('.slider1').css('height', (sliderblockHeight + 140) + 'px');
            // testimonial (window width leass than 767px)
        if ($(window).innerWidth() <= 767) {
           var sliderblockHeight = $('.sliderblock-cont').height();
           $('.slider1').css('height', (sliderblockHeight + 180) + 'px');
        }
            // testimonial (window width leass than 479px)
        //if ($(window).innerWidth() <= 479) {
          //  var sliderblockHeight = $('.sliderblock-cont').height();
          //  $('.slider1').css('height', (sliderblockHeight + 230) + 'px');
        //} else {
          //  var sliderblockHeight = $('.sliderblock-cont').height();
          //  $('.slider1').css('height', (sliderblockHeight + 180) + 'px');
        //}

		// column reverse
		
        if ($(window).innerWidth() <= 1024) {
            $('.flex-col-rev > div').each(function() {
                $(this).prependTo(this.parentNode);
            });
        };
        

        // recent blog post
        var recentblogpostHeight = $('.post-grid').height();
        $('.post-left').css('height', (500) + 'px');
        $('.post-right').css('height', (500) + 'px');
            // recent blog post (window width leass than 767px)
        if ($(window).innerWidth() <= 767) {
            var recentblogpostHeight = $('.post-grid').height();
            $('.post-left').css('height', 'auto');
            $('.post-right').css('height', 'auto');
        } else {
            var recentblogpostHeight = $('.post-grid').height();
            $('.post-left').css('height', (recentblogpostHeight - 100) + 'px');
            $('.post-right').css('height', (recentblogpostHeight - 100) + 'px');
        }


});

// ========== slider with multiple items ===============
(function($){

    // ==== BEGINS PLUGGIN ====
    $.fn.multislider = function(data, callback){

        // ==== CACHE DOM ====
        var $multislider = $(this);
        var $msContent = $multislider.find('.MS-content');
        var $msRight = $multislider.find('button.MS-right');
        var $msLeft = $multislider.find('button.MS-left');
        var $imgFirst = $msContent.find('.item:first');

        // === DETERMINE ACTION ====
        // string = method | object or nothing is to initialize
        if(typeof data === 'string'){
            getStringArgs(data);
            return $multislider;
        } else if (typeof data === 'object' || typeof data  ==='undefined'){
            init();
        };

        // ==== PLUGGIN VARIABLES ====
        var $imgLast,
        currentMargin,
        percentageRemaining,
        totalWidth,
        numberVisibleSlides,
        numberTotalSlides,
        animateDistance,
        animateSlideRight,
        animateSlideLeft,
        defaults,
        settings,
        animateDuration,
        autoSlideInterval;

        // = INITIALIZE =
        function init(){
            minifyContent();        // minify html
            createSettings();       // merge defaults and user provided options
            saveData();             // add data object to DOM el with reference to animation functions, allows for methods to reference at any time
            selectAnimations();     // choose default animation
        };


        // ==== EVENT HANDLERS ====
        $msRight.on('click', animateSlideLeft);
        $msLeft.on('click', animateSlideRight);
        $multislider.on('click','.MS-right, .MS-left', resetInterval);
        $(window).on('resize', findItemWidth);


        // ==== FUNCTIONS (for days...) ====
        // =================================

        function pauseAbove(){
            if (window.innerWidth > settings.pauseAbove){ $multislider.addClass('ms-PAUSE'); }
            $(window).on('resize',function(){
                if (window.innerWidth > settings.pauseAbove){
                    $multislider.addClass('ms-PAUSE');
                } else {
                    $multislider.removeClass('ms-PAUSE');
                }
            });
        }

        function pauseBelow(){
            if (window.innerWidth < settings.pauseBelow){ $multislider.addClass('ms-PAUSE'); }
            $(window).on('resize',function(){
                if (window.innerWidth < settings.pauseBelow){
                    $multislider.addClass('ms-PAUSE');
                } else {
                    $multislider.removeClass('ms-PAUSE');
                }
            });
        }

        // used if method is called after initialization
        function getStringArgs(str){
            if (typeof $multislider.data(str) !== 'undefined'){
                $multislider.data(str)();
            } else {
                console.error("Multislider currently only accepts the following methods: next, prev, pause, play")
            }
        }

        // saves data object to DOM element
        function saveData(){
            $multislider.data({
                "pause":function(){ $multislider.addClass('ms-PAUSE'); },
                "unPause":function(){ $multislider.removeClass('ms-PAUSE'); },
                "continuous":function(){ $multislider.removeClass('ms-PAUSE'); continuousLeft(); },
                "next":function(){ overRidePause(singleLeft); },
                "nextAll":function(){ overRidePause(allLeft); },
                "prev":function(){ overRidePause(singleRight); },
                "prevAll":function(){ overRidePause(allRight); },
                "settings":settings
            });
        }

        // used when calling 'next', 'prev' methods
        function overRidePause(animation){
            if ($multislider.hasClass('ms-PAUSE')){
                $multislider.removeClass('ms-PAUSE');
                animation();
                $multislider.addClass('ms-PAUSE');
            } else {
                animation();
            }
            resetInterval();
        }

        // CRITICAL for items to be perfectly side-by-side without floating them
        function minifyContent(){
            $msContent.contents().filter(function(){
                return (this.nodeType == 3 && !/\S/.test(this.nodeValue));
            }).remove();
        }

        // updated options with defaults, measure slide widths for animation calculations, carry out setting implementations
        function createSettings() {
            defaults = settings || {
    			continuous: false,	// endless scrolling with no pauses
    			slideAll: false,	// slide all visible slides, or just one at a time
    			// autoSlide: true,	// DEPRECATED
    			interval: 2000,		// time bewteen slide animation, 0 or 'false' prevents auto-sliding
    			duration: 500,	    // duration of slide animation
    			hoverPause: true,	// pause slideshow on hover
                pauseAbove: null,   // pause above specified screen width
                pauseBelow: null   // pause below specified screen width
    		}
    		settings = $.extend({},defaults,data);

            findItemWidth();
            animateDuration = settings.duration;

            if (settings.hoverPause){pauseHover();};
            // autoSlide is being depricated | Feb 2 2017
            if (settings.continuous !== true && settings.interval !== 0 && settings.interval !== false && settings.autoSlide !== false){autoSlide();}
            if (settings.pauseAbove !== null && typeof settings.pauseAbove === 'number'){ pauseAbove(); }
            if (settings.pauseBelow !== null && typeof settings.pauseBelow === 'number'){ pauseBelow(); }
        }

        // determine between single and multi-slide animations
        function selectAnimations () {
            if (settings.continuous){
                settings.autoSlide = false;
                continuousLeft();
            } else if (settings.slideAll){
                animateSlideRight = $multislider.data('prevAll');
                animateSlideLeft = $multislider.data('nextAll');
            } else {
                animateSlideRight = $multislider.data('prev');
                animateSlideLeft = $multislider.data('next');
            }
        }

        // measure slide width, for animation calculations
        function findItemWidth(){
            reTargetSlides();
            animateDistance = $imgFirst.width();
            var left = parseInt($msContent.find('.item:first').css('padding-left'));
            var right = parseInt($msContent.find('.item:first').css('padding-right'));
            if (left !== 0){animateDistance += left;}
            if (right !== 0){animateDistance += right;}
        }

        // recursive auto-slide loop
        function autoSlide() {
            autoSlideInterval = setInterval(function(){
                if (!$multislider.hasClass('ms-PAUSE')){
                    animateSlideLeft();
                }
            }, settings.interval);
        };

        function resetInterval() {
            if (settings.interval !== 0 && settings.interval !== false && settings.continuous !== true){
                clearInterval(autoSlideInterval);
                autoSlide();
            }
        }

        // target first and last visible slides before each new animation
        function reTargetSlides(){
            $imgFirst = $msContent.find('.item:first');
            $imgLast = $msContent.find('.item:last');
        }

        // prevent animation firing if multislider is currently animating
        // all animations pass through this function, which emits events, and adds/removes animating class
        function isItAnimating(callback){
			if(!$multislider.hasClass('ms-animating') &&
               !$multislider.hasClass('ms-HOVER') &&
               !$multislider.hasClass('ms-PAUSE')){
                    $multislider.trigger('ms.before.animate'); // event!
                    $multislider.addClass('ms-animating');
                    callback();    //callback is animation
			}
		}

        // update multislider at the end of each animation
        function doneAnimating() {
			if($multislider.hasClass('ms-animating')){
				$multislider.removeClass('ms-animating');
                $multislider.trigger('ms.after.animate'); // event!
            }
		}

        // logic for pausing and restarting the multislider on hover
        function pauseHover() {
            // continuous scroll pause slightly different
            if(settings.continuous){
				$msContent.on('mouseover',function(){
					doneAnimating();
					$msContent.children('.item:first').stop();
				});
				$msContent.on('mouseout',function(){
					continuousLeft();
				});
			} else {
            // regular animation pausing
                $msContent.on('mouseover',function(){
                    $multislider.addClass('ms-HOVER');
                });
                $msContent.on('mouseout',function(){
                    $multislider.removeClass('ms-HOVER');
                });
			}
        }

        // calculate remaining animation, if stopped mid-animation and resuming
        function midAnimateResume(){
            animateDuration = settings.duration;
            var currentMargin = parseFloat($msContent.find('.item:first').css("margin-left"));
            var percentageRemaining = 1-(currentMargin/-(animateDistance-1));
            animateDuration = percentageRemaining*animateDuration;
        }

        // determine how many slides need to be moved over, if slideAll is true
        function calcNumSlidesToMove(){
            totalWidth = $msContent.width();						          // total width of .MS-content containing all visible slides
		    numberVisibleSlides = Math.round(totalWidth/animateDistance);     // number of (visible) slides needed to be moved in each animation
        }


        // ==== ANIMATION FUNCTIONS ====
        // =============================
        function continuousLeft () {
            isItAnimating(function(){
                reTargetSlides();
                midAnimateResume();
                $imgFirst.animate(
                    {marginLeft: -(animateDistance+1)},
                    {
                        duration: animateDuration,
                        easing: "swing",
                        complete: function(){
                            $imgFirst.insertAfter($imgLast).removeAttr("style");
                            doneAnimating();
                            continuousLeft ();
                        }
                    }
                );
            });
        }

        function allLeft(){
            isItAnimating(function(){
                reTargetSlides();
                calcNumSlidesToMove();

                var $clonedItemSet = $msContent.children('.item').clone();
                var filteredClones = $clonedItemSet.splice(0, numberVisibleSlides);

                $msContent.append(filteredClones);

                $imgFirst.animate(
                    {marginLeft: -totalWidth}, {
                        duration: animateDuration,
                        easing: "swing",
                        complete: function(){
                            $($msContent.children('.item').splice(0,numberVisibleSlides)).remove();
                            doneAnimating();
                        }
                    }
                );
            });
        }

        function allRight() {
            isItAnimating(function(){
                reTargetSlides();
                calcNumSlidesToMove();

                var numberTotalSlides = $msContent.children('.item').length;
                var $clonedItemSet = $msContent.children('.item').clone();
                var filteredClones = $clonedItemSet.splice(numberTotalSlides-numberVisibleSlides,numberTotalSlides);

                $($(filteredClones)[0]).css('margin-left',-totalWidth); // give clone array negative margin before preppending
                $msContent.prepend(filteredClones);

                reTargetSlides();

                $imgFirst.animate(
                    {
                        marginLeft: 0
                    }, {
                        duration: animateDuration,
                        easing: "swing",
                        complete: function(){
                            numberTotalSlides = $msContent.find('.item').length;
                            $($msContent.find('.item').splice(numberTotalSlides-numberVisibleSlides,numberTotalSlides)).remove();
                            $imgFirst.removeAttr('style');
                            doneAnimating();
                        }
                    }
                );
            });
        }

        function singleLeft(){
            isItAnimating(function(){
                reTargetSlides();
                $imgFirst.animate(
                    {
                        marginLeft: -animateDistance
                    }, {
                        duration: animateDuration,
                        easing: "swing",
                        complete: function(){
                            $imgFirst.detach().removeAttr('style').appendTo($msContent);
                            doneAnimating();
                        }
                    }
                );
            });
        }

        function singleRight(){
            isItAnimating(function(){
                reTargetSlides();
                $imgLast.css('margin-left',-animateDistance).prependTo($msContent);
                $imgLast.animate(
                    {
                        marginLeft: 0
                    }, {
                        duration: animateDuration,
                        easing: "swing",
                        complete: function(){
                            $imgLast.removeAttr("style");
                            doneAnimating();
                        }
                    }
                );
            });
        }
    return $multislider;
    }
})(jQuery);

/**************Tab slider*****************************/
$(document).ready(function(){
  
    $('#tab-slider #tabs li[id^="tab"]').click(function(){
    var targetID = $(this).attr('href');
    var target = $('#slider-content #'+targetID);
        
        $('#tab-slider #tabs li').removeClass('active');
        $(this).addClass('active');
        
        $('#slider-content li[id^="tab"]').hide();
        target.show();
    });

    //SlideShow
    var width= $('#slideshow li').width();
    
    
    // $('#slideshow').css({'margin-left':-width});
    
    $('#slideshow li:last-child').prependTo($(this).parent('ul'));
    
        $('#tab-slider ul#slider-content li div#prev').click(function(){
        var targ = $(this).parent('li').find('ul');
        
        targ.animate({'left':'+=33.3333%'},300,function(){
            targ.find('li:last-child').prependTo(targ);
            targ.css('left','');
        });        
    });
    
    $('#tab-slider ul#slider-content li div#nex').click(function(){
        var targ = $(this).parent('li').find('ul');
        targ.animate({'left':'-=33.3333%'},300,function(){
            targ.find('li:first-child').appendTo(targ);
            targ.css('left','');
        });
    });
    
});

// testimonials
$(document).ready(function(){
var flkty = new Flickity( '.flickable-slider', {
    cellAlign: 'left',
    contain: true,
    wrapAround: true,
    prevNextButtons: true,
    autoPlay: 5000
});

//slider responsive
function resetPos() {
    $('.slider-resp-in ul li').removeClass('transition');
    $('.slider-resp-in ul li').removeClass('left right');
  }
  
  //clicks
  $('.prev').on('click', function(){
    $('.slider-resp-in ul li').addClass('transition right');
    
    setTimeout(function(){
      prev();
      resetPos();
    }, 300);
  });
  
  $('.next').on('click', function(){
    $('.slider-resp-in ul li').addClass('transition left');
    
    setTimeout(function(){
      next();
      resetPos();
    }, 300);
  });
  
  
  
  ///////////////////////////////////////////////////////////////
  function init() {
    $('.slider-resp-in ul li').each(function(){
      var curPos = $(this).index();
      $(this).css('order', curPos+1);
    });
  }
  
  function prev() {
    var slider = $('.slider-resp-in');
    var sliderLength = slider.find('ul li').length;
    $('.slider-resp-in ul li').each(function(){
      var curPos = parseInt($(this).css('order'));
      var sliderLength = slider.find('ul li').length;
      if (curPos < sliderLength) {
        $(this).css('order', curPos+1);  
      }
      else {
        curPos = 1;
        $(this).css('order', curPos);  
      }
    });
  }
  
  function next() {
    var slider = $('.slider-resp-in');
    var sliderLength = slider.find('ul li').length;
    $('.slider-resp-in ul li').each(function(){
      var curPos = parseInt($(this).css('order'));
      var sliderLength = slider.find('ul li').length;
      if (curPos > 0) {
        $(this).css('order', curPos-1);  
      }
      else {
        curPos = sliderLength-1;
        $(this).css('order', curPos);  
      }
    });
  }
  
  $(document).ready(function(){
    init();
  });
//slider responsive end


var head = document.getElementsByTagName('head')[0];
var js = document.createElement("script");

js.type = "text/javascript";

if (screen.width > 1024)
{
    js.src = "../assets/page-scrolling/scroll.js";
}
else if(screen.width < 1025)
{
    js.src = "../assets/page-scrolling/scroll_m.js";
}

head.appendChild(js);  

});

