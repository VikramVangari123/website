
$(function() {

    $(".tab1").click(function(){               
        $('.content1').addClass("active-tab");
    });
    // menu
    //  (window width leass than 767px)
    if ($(window).innerWidth() >= 768) {
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

        // section inner full height
        var sectionHeight = $('.section').height();
		$('.section-in').css('height', (sectionHeight) + 'px');

        // testimonial 
        var sliderblockHeight = $('.sliderblock-cont').height();
        //$('.slider1').css('height', (sliderblockHeight + 140) + 'px');
            // testimonial (window width leass than 767px)
        if ($(window).innerWidth() <= 767) {
           var sliderblockHeight = $('.sliderblock-cont').height();
           //$('.slider1').css('height', (sliderblockHeight + 180) + 'px');
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
var flkty = new Flickity( '.testimonials', {
    cellAlign: 'left',
    contain: true,
    wrapAround: true,
    prevNextButtons: true,
    autoPlay: 5000
});

// Neo pager

;(function ( $, window, document, undefined ) {

		// Create the defaults once
		var namespace = "neo",
		pluginName = "pager",
		defaults = {
			pageClass: "page", // class selector for all pages
			parentDotId: "dot-holder", // id of the dot holder
			activeDotClass: "page-nav-dot-current", // current active dot
			dotOutAnimClass: "", // used to animate the dot hide
			dotInAnimClass: "", // used to animate the dot show
			dotClass: "page-nav-dot", // the main dot holder class,
			dotSelectionVisible: true, // doe's dot selection bar is visible
			dotAnimSpeed: 800, // if no animate class is used
			dotDelay: 200, // if no animate class is used
			pageFactorUp: 0.01, // how we recognize the current page (0.5 = half page, values from 0..1)
			pageFactorDown: 0.95, // how we recognize the current page (0.5 = half page, values from 0..1)
			autoScrollPages: false, // if true it will auto scroll to next current page
			pageScrollSpeed: 800, // animation of page scroll
			onDotHide: null, // event after dot animation hide finish
			onDotShow: null, // event after dot animation show finish
			onPageIn: null, // event when page become active
			onPageOut: null, // event when page become inactive
			onScroll: null, // event on page scroll
			onAutoScrollStart: null, // event after auto scroll start
			onAutoScrollEnd: null, // event after auto scroll end
			useDefaultCss: true, // if true, plugin css will be created
			hintClass: "hint--left hint--rounded hint--page", // classes that descripbe hint side position, how hint will be shown, and hint style
			addHintStyle: true
		};
		
		// Private object to help us enable and disable page scrolling
		var UserScrollDisabler = function() {
			// spacebar: 32, pageup: 33, pagedown: 34, end: 35, home: 36
			// left: 37, up: 38, right: 39, down: 40
			this.scrollEventKeys = [32, 33, 34, 35, 36, 37, 38, 39, 40];
			this.$window = $(window);
			this.$document = $(document);
		};
		UserScrollDisabler.prototype = {
			disable_scrolling : function() {
				var t = this;
				t.$window.on("mousewheel.UserScrollDisabler DOMMouseScroll.UserScrollDisabler", this._handleWheel);
				t.$document.on("mousewheel.UserScrollDisabler touchmove.UserScrollDisabler", this._handleWheel);
				t.$document.on("keydown.UserScrollDisabler", function(event) {
					t._handleKeydown.call(t, event);
				});
			},
			enable_scrolling : function() {
				var t = this;
				t.$window.off(".UserScrollDisabler");
				t.$document.off(".UserScrollDisabler");
			},
			_handleKeydown : function(event) {
				for (var i = 0; i < this.scrollEventKeys.length; i++) {
					if (event.keyCode === this.scrollEventKeys[i]) {
						event.preventDefault();
						return;
					}
				}
			},
			_handleWheel : function(event) {
				event.preventDefault();
			}
		};

		// The actual plugin constructor
		function Plugin ( element, options ) {
			this.el = element;
			this.$el = $(element);
			this.settings = $.extend( {}, defaults, options );
			this._defaults = defaults;
			this._namespace = namespace;
			this._name = pluginName;
			if (!window[namespace]) {
				window[namespace] = {};
			}
			if (!window[namespace][pluginName]) {
				window[namespace][pluginName] = {};
			}
			this.repo = {
				pages: null,
				dotParent: null,
				dots: null,
				currentDot: null,
				currentDotInd: -1,
				scrollObj: new UserScrollDisabler(),
				dotsVisible: true,
				currentScrollPos: 0,
				inAutoScroll: false,
				inClickDotScroll: false
			};
			this._init();
		}

		// Avoid Plugin.prototype conflicts
		$.extend(Plugin.prototype, {
				_init: function () {
					// get the start scroll position
					this.repo.currentScrollPos = $(document).scrollTop();
					// get pages
					this._getPages();
					// init or create visual dots
					this._initDots();
					// Init anchor smooth scroll 
					this._initSmoothScrollAnchors();
					// init the scroll event
					this._initScroll();
					// setup css
					this._setupCss();
					// hide dots if setted by user
					if (!this.settings.dotSelectionVisible) {
						this.hideDots(true);
					}
					// set first page selection
					this._onScroll();
				},
				_setupCss: function () {
					var cssToAdd = "",
					exist = false,
					links = window.document.getElementsByTagName('link');
					if (this.settings.addHintStyle) {
						$(links).each(function() {
							var path = $(this).attr('href');
							if (path.indexOf("hint.css") != -1) {
								exist = true;
								console.log(path);  // this is your href for the link tag in the loop
								return false;
							}	
						});
					} else {
						exist = true;
					}
					if (!exist) {
						cssToAdd += " " + ".hint,[data-hint]{position:relative;display:inline-block}.hint:before,.hint:after,[data-hint]:before,[data-hint]:after{position:absolute;-webkit-transform:translate3d(0,0,0);-moz-transform:translate3d(0,0,0);transform:translate3d(0,0,0);visibility:hidden;opacity:0;z-index:1000000;pointer-events:none;-webkit-transition:.3s ease;-moz-transition:.3s ease;transition:.3s ease}.hint:hover:before,.hint:hover:after,[data-hint]:hover:before,[data-hint]:hover:after{visibility:visible;opacity:1}.hint:before,[data-hint]:before{content:none;position:absolute;background:transparent;border:6px solid transparent;z-index:1000001}.hint:after,[data-hint]:after{content:attr(data-hint);background:#000;color:#fff;padding:8px 10px;font-size:12px;line-height:12px;white-space:nowrap;)}.hint--top:before{border-top-color:#383838}.hint--bottom:before{border-bottom-color:#383838}.hint--left:before{border-left-color:#383838}.hint--right:before{border-right-color:#383838}.hint--top:before{margin-bottom:-12px}.hint--top:after{margin-left:-18px}.hint--top:before,.hint--top:after{bottom:100%;left:50%}.hint--top:hover:after,.hint--top:hover:before{-webkit-transform:translateY(-8px);-moz-transform:translateY(-8px);transform:translateY(-8px)}.hint--bottom:before{margin-top:-12px}.hint--bottom:after{margin-left:-18px}.hint--bottom:before,.hint--bottom:after{top:100%;left:50%}.hint--bottom:hover:after,.hint--bottom:hover:before{-webkit-transform:translateY(8px);-moz-transform:translateY(8px);transform:translateY(8px)}.hint--right:before{margin-left:-12px;margin-bottom:-6px}.hint--right:after{margin-bottom:-14px}.hint--right:before,.hint--right:after{left:100%;bottom:50%}.hint--right:hover:after,.hint--right:hover:before{-webkit-transform:translateX(8px);-moz-transform:translateX(8px);transform:translateX(8px)}.hint--left:before{margin-right:-12px;margin-bottom:-6px}.hint--left:after{margin-bottom:-14px}.hint--left:before,.hint--left:after{right:100%;bottom:60%}.hint--left:hover:after,.hint--left:hover:before,{-webkit-transform:translateX(-8px);-moz-transform:translateX(-8px);transform:translateX(-8px)}.hint--error:after{background-color:#b34e4d;text-shadow:0 -1px 0 #592726}.hint--error.hint--top:before{border-top-color:#b34e4d}.hint--error.hint--bottom:before{border-bottom-color:#b34e4d}.hint--error.hint--left:before{border-left-color:#b34e4d}.hint--error.hint--right:before{border-right-color:#b34e4d}.hint--warning:after{background-color:#c09854;text-shadow:0 -1px 0 #6c5328}.hint--warning.hint--top:before{border-top-color:#c09854}.hint--warning.hint--bottom:before{border-bottom-color:#c09854}.hint--warning.hint--left:before{border-left-color:#c09854}.hint--warning.hint--right:before{border-right-color:#c09854}.hint--info:after{background-color:#3986ac;text-shadow:0 -1px 0 #193b4d}.hint--info.hint--top:before{border-top-color:#3986ac}.hint--info.hint--bottom:before{border-bottom-color:#3986ac}.hint--info.hint--left:before{border-left-color:#3986ac}.hint--info.hint--right:before{border-right-color:#3986ac}.hint--success:after{background-color:#458746;text-shadow:0 -1px 0 #1a321a}.hint--success.hint--top:before{border-top-color:#458746}.hint--success.hint--bottom:before{border-bottom-color:#458746}.hint--success.hint--left:before{border-left-color:#458746}.hint--success.hint--right:before{border-right-color:#458746}.hint--always:after,.hint--always:before{opacity:1;visibility:visible}.hint--always.hint--top:after,.hint--always.hint--top:before{-webkit-transform:translateY(-8px);-moz-transform:translateY(-8px);transform:translateY(-8px)}.hint--always.hint--bottom:after,.hint--always.hint--bottom:before{-webkit-transform:translateY(8px);-moz-transform:translateY(8px);transform:translateY(8px)}.hint--always.hint--left:after,.hint--always.hint--left:before{-webkit-transform:translateX(-8px);-moz-transform:translateX(-8px);transform:translateX(-8px)}.hint--always.hint--right:after,.hint--always.hint--right:before{-webkit-transform:translateX(8px);-moz-transform:translateX(8px);transform:translateX(8px)}.hint--rounded:after{border-radius:25px}.hint--bounce:before,.hint--bounce:after{-webkit-transition:opacity .3s ease,visibility .3s ease,-webkit-transform .3s cubic-bezier(0.71,1.7,0.77,1.24);-moz-transition:opacity .3s ease,visibility .3s ease,-moz-transform .3s cubic-bezier(0.71,1.7,0.77,1.24);transition:opacity .3s ease,visibility .3s ease,transform .3s cubic-bezier(0.71,1.7,0.77,1.24)}";
					}
					if (this.settings.useDefaultCss) {
						cssToAdd += " " + "#dot-holder{position:fixed;right:30px;top:50%; transform: translateY(-50%);width:30px}#dot-holder .page-nav-dot{list-style-type:none}#dot-holder .page-nav-dot span{display:inline-block;position:relative;width:8px;height:8px;border-radius:50%;background:#000;margin:9px 10px;cursor:pointer;border:2px solid transparent; opacity: 0.3;}#dot-holder .page-nav-dot span.page-nav-dot-current{background: #000;border: 2px solid transparent;opacity:1;width: 12px;height: 12px;margin: 8px;}#dot-holder .page-nav-dot span.page-nav-dot-current:after{content:'';width:11px;height:11px;position:absolute;top:0px;left:0px;border-radius:50%;filter:progid:DXImageTransform.Microsoft.gradient(startColorstr='#859398',endColorstr='#859398',GradientType=0)}#dot-holder.page-nav-dot{margin:5px 0}.hint--page:after.hint--page:after{background-color:#000;text-shadow:0 -1px 0 #000;text-transform:capitalize}.hint--page.hint--top:before{border-top-color:#859398;text-transform:capitalize}.hint--page.hint--bottom:before{border-bottom-color:#859398;text-transform:capitalize}.hint--page.hint--left:before{border-left-color:#000;text-transform:capitalize}.hint--page.hint--right:before{border-right-color:#859398;text-transform:capitalize}";
					}
					if (cssToAdd != "") {
						$("head").append("<style>" + cssToAdd + "</style>");
					}
				},
				_getPages: function () {
					// get the pages from 'this' element
					this.repo.pages = this.$el.find("." + this.settings.pageClass);
					if (this.repo.pages.length <= 0) {
						throw new Error(
							"Error detected. No pages found in parent element with id '" + 
							this.$el.attr("id") + "'! -You need to provide elements with" +
							" class name '" + this.settings.pageClass + "' that will represent page blocks."
						);
					}
					for (var k = 0, j = this.repo.pages.length; k < j; ++k) {
						var $page = $(this.repo.pages[k]);
						if (!$page.attr("id")) {
							$page.attr("id", "page_" + (k+1));
						}
					}
				},
				_initDots: function () {
					this.repo.dotParent = $("#" + this.settings.parentDotId);
					// we need to create dot holder if doesnt exist
					if (this.repo.dotParent.length <= 0) {
						$(document.body).append("<div id='" + this.settings.parentDotId + "'></div>");
						this.repo.dotParent = $("#" + this.settings.parentDotId);
					}
					for (var k = 0, j = this.repo.pages.length; k < j; ++k) {
						var $page = $(this.repo.pages[k]),
						hint = $page.data("hint-text"),
						hintInfo = "",
						text = $page.data("dot-text") || "";
						if (hint) {
							hintInfo = "class='" + this.settings.hintClass + "' data-hint='" + hint + "'";
						}
						this.repo.dotParent.append("<div class='" + this.settings.dotClass + "'><a " +
							hintInfo + " href='#" + $page.attr("id") + "' data-index='" + k + "'><span>" + text + "</span></a></div>");
					}
					this.repo.dots = $("." + this.settings.dotClass);
				},
				_initSmoothScrollAnchors: function () {
					var that = this;
					$('a[href*=#]:not([href=#])').click(function() {
						if (location.pathname.replace(/^\//,'') == this.pathname.replace(/^\//,'') && location.hostname == this.hostname) {
							var ind = $(this).data("index"),
							target = $(this.hash);
							target = target.length ? target : $('[name=' + this.hash.slice(1) +']');
							if (target.length) {
								that.repo.inClickDotScroll = true;
								that._removeDotActive();
								that._addDotActive(that.repo.dots[ind], ind);
								if (that.settings.onAutoScrollStart) {
									that.settings.onAutoScrollStart(that.repo.dots[ind], ind);
								}
								that._scrollToPos(target.offset().top, false, function () {
									setTimeout(function () {
										that.repo.inClickDotScroll = false;
										that.repo.currentScrollPos = $(document).scrollTop();
										if (that.settings.onAutoScrollEnd) {
											that.settings.onAutoScrollEnd(that.repo.dots[ind], ind);
										}
									}, 100);
								});
								return false;
							}
						}
					});	
				},
				_scrollToPos: function (pos, notAnim, callBack) {
					var that = this;
					$('html,body').stop();
					if (notAnim === true) {
						$('html,body').scrollTop(pos);
					} else {
						this.disableScroll();
						this.repo.inAutoScroll = true;
						var callOne = false;
						$('html,body').animate({
							scrollTop: pos
						}, that.settings.pageScrollSpeed, function () {
							that.enableScroll();
							if (callBack && !callOne) {
								callBack.call(that, pos);
								callOne = true;
							}
							setTimeout(function () {
								that.repo.inAutoScroll = false;
							}, 100);
						});
					}
				},
				_initScroll: function () {
					$(document).on("scroll", $.proxy(this._onScroll, this));
				},
				_getPageIndex: function () {
					if (this.repo.pages) {
						var windowTop = $(document).scrollTop(),
						h = window.innerHeight || /* ie */ document.documentElement.offsetHeight,
						returnValue = 0;
						if (windowTop == 0) {
							return {
								ind: 0,
								scrollTop: windowTop,
								docHeight: h
							};
						}
						if (windowTop + screen.height >= $(document).height()) {
							return {
								ind: this.repo.pages.length-1,
								scrollTop: windowTop,
								docHeight: h
							};
						}
						var factor = this.settings.pageFactorUp;
						if (windowTop > this.repo.currentScrollPos) {
							factor = this.settings.pageFactorDown;
						}
						var topPos = 0, c = -1,
						that = this,
						pageT = 0;
						$(this.repo.pages).each(function () {
							++c;
							topPos = Math.round($(this).offset().top);
							pageT = topPos - h * factor;
							if (pageT < windowTop) {
								returnValue = c;
							}
						});
						return {
							ind: returnValue > -1 ? returnValue : 0,
							scrollTop: windowTop,
							docHeight: h
						};
					}
					return {
						ind: 0,
						scrollTop: windowTop,
						docHeight: h
					};
				},
				_onScroll: function () {
					if (this.repo.inAutoScroll) return;
					if (this.repo.inClickDotScroll) return;
					var indObj = this._getPageIndex();
					if (indObj.ind > -1 && this.repo.currentDotInd != indObj.ind) {
						this._removeDotActive();
						this._addDotActive(this.repo.dots[indObj.ind], indObj.ind);
						if (this.settings.autoScrollPages) {
							if (this.settings.onAutoScrollStart) {
								this.settings.onAutoScrollStart(this.repo.dots[indObj.ind], indObj.ind);
							}
							this.scrollToPage(indObj.ind, function () {
								if (this.settings.onAutoScrollEnd) {
									this.settings.onAutoScrollEnd(this.repo.dots[indObj.ind], indObj.ind);
								}
							});
						}
					}
					if (this.settings.onScroll) {
						this.settings.onScroll.call(this, indObj.scrollTop, indObj.docHeight, indObj.ind);
					}
					this.repo.currentScrollPos = indObj.scrollTop;
				},
				_removeDotActive: function () {
					if (this.repo.currentDot != null) {
						$(this.repo.currentDot).find("a span").removeClass(this.settings.activeDotClass);
						if (this.settings.onPageOut) {
							this.settings.onPageOut.call(this, this.repo.currentDot, this.repo.currentDotInd);
						}
						this.repo.currentDot = null;
					}
				},
				_addDotActive: function (dot, ind) {
					if (!dot) {
						dot = this.repo.dots[0];
						ind = 0;
					}
					$(dot).find("a span").addClass(this.settings.activeDotClass);
					this.repo.currentDot = dot;
					if (this.settings.onPageIn) {
						this.settings.onPageIn.call(this, dot, ind, this.repo.currentDotInd);
					}
					this.repo.currentDotInd = ind;
				},
				disableScroll: function () {
					this.repo.scrollObj.disable_scrolling();
				},
				enableScroll: function () {
					this.repo.scrollObj.enable_scrolling();
				},
				hideDots: function (noAnim) {
					if (!this.repo.dotsVisible) {
						return this.$el;
					}
					$("#" + this.settings.parentDotId).css("overflow", "hidden");
					if (this.repo.dotParent) {
						this.repo.dotsVisible = false;
						if (noAnim === true) {
							$(this.repo.dotParent).hide();
							$(this.repo.dots).each(function () {
								$(this).css("margin-left", "25px");
								$(this).css("opacity", "0");
							});
							$("#" + this.settings.parentDotId).css("overflow", "inherit");
							return this.$el;
						}
						if (this.settings.dotOutAnimClass != "") {
							var k = 1, c = this.repo.dots.length,
							that = this;
							$(this.repo.dots).each(function () {
								$(this).removeClass(that.settings.dotInAnimClass);
								$(this).stop();
								if (k >= c) {
									$(this).addClass(that.settings.dotOutAnimClass);
									$(this).one("animationend webkitAnimationEnd oAnimationEnd MSAnimationEnd", function(){ 
										$(that.repo.dotParent).hide();
										if (that.settings.onDotHide) {
											that.settings.onDotHide.call(that);
										}
										$("#" + that.settings.parentDotId).css("overflow", "inherit");
									});
								} else {
									$(this).addClass(that.settings.dotOutAnimClass);
								}
								k++;
							});
						} else {
							$(this).css("margin-left", "0px");
							$(this).css("opacity", "1");
							var delay = this.settings.dotDelay, 
							delVal = 0, 
							k = 1,
							c = this.repo.dots.length,
							that = this;
							$(this.repo.dots).each(function () {
								$(this).removeClass(that.settings.dotInAnimClass);
								$(this).stop();
								if (delVal > 0) {
									if (k >= c) {
										$(this).delay(delVal).animate({marginLeft: "25px", opacity: "0"}, that.settings.dotAnimSpeed, function () {
											$(that.repo.dotParent).hide();
											if (that.settings.onDotHide) {
												that.settings.onDotHide.call(that);
											}
											$("#" + that.settings.parentDotId).css("overflow", "inherit");
										});
									} else { 
										$(this).delay(delVal).animate({marginLeft: "25px", opacity: "0"}, that.settings.dotAnimSpeed);
									}
								} else {
									$(this).animate({marginLeft: "25px", opacity: "0"}, that.settings.dotAnimSpeed);
								}
								delVal += delay;
								k++;
							});
						}
					}
					return this.$el;
				},
				showDots: function (noAnim) {
					if (this.repo.dotsVisible) {
						return this.$el;
					}
					$("#" + this.settings.parentDotId).css("overflow", "hidden");
					if (this.repo.dotParent) {
						this.repo.dotsVisible = true;
						$(this.repo.dotParent).show();
						if (noAnim === true) {
							$(this.repo.dots).each(function () {
								$(this).css("margin-left", "0px");
								$(this).css("opacity", "1");
							});
							$("#" + this.settings.parentDotId).css("overflow", "inherit");
							return this.$el;
						}
						if (this.settings.dotInAnimClass != "") {
							var k = 1, c = this.repo.dots.length,
							that = this;
							$(this.repo.dots).each(function () {
								$(this).removeClass(that.settings.dotOutAnimClass);
								$(this).stop();
								if (k >= c) {
									$(this).addClass(that.settings.dotInAnimClass);
									$(this).one("animationend webkitAnimationEnd oAnimationEnd MSAnimationEnd", function(){ 
										if (that.settings.onDotShow) {
											that.settings.onDotShow.call(that);
										}
										$("#" + that.settings.parentDotId).css("overflow", "inherit");
									});
								} else {
									$(this).addClass(that.settings.dotInAnimClass);
								}
								k++;
							});
						} else {
							var delay = this.settings.dotDelay, 
							delVal = 0, 
							k = 1,
							c = this.repo.dots.length,
							that = this;
							$(this.repo.dots).each(function () {
								$(this).removeClass(that.settings.dotOutAnimClass);
								$(this).stop();
								$(this).css("margin-left", "25px");
								$(this).css("opacity", "0");
								if (delVal > 0) {
									if (k >= c) {
										$(this).delay(delVal).animate({marginLeft: "0px", opacity: "1"}, that.settings.dotAnimSpeed, function () {
											if (that.settings.onDotShow) {
												that.settings.onDotShow.call(that);
											}
											$("#" + that.settings.parentDotId).css("overflow", "inherit");
										});
									} else { 
										$(this).delay(delVal).animate({marginLeft: "0px", opacity: "1"}, that.settings.dotAnimSpeed);
									}
								} else {
									$(this).animate({marginLeft: "0px", opacity: "1"}, that.settings.dotAnimSpeed);
								}
								delVal += delay;
								k++;
							});
						}
					}
					return this.$el;
				},
				goToPage: function (ind) {
					if (this.repo.pages && ind >= 0 && ind < this.repo.pages.length) {
						this._scrollToPos($(this.repo.pages[ind]).offset().top, true);
					}
					return this.$el;
				},
				scrollToPage: function (ind, callBack) {
					if (this.repo.pages && ind >= 0 && ind < this.repo.pages.length) {
						this._scrollToPos($(this.repo.pages[ind]).offset().top, false, callBack);
					}
					return this.$el;
				},
				getCurrentPage: function () {
					return this.repo.currentDotInd;
				},
				getInstance: function () {
					return this;
				}
		});

		// A really lightweight plugin wrapper around the constructor,
		// preventing against multiple instantiations
		$.fn[ namespace + "_" + pluginName ] = function ( options, args ) {
			var res = this;
			this.each(function() {
				if ( !$.data( this, "plugin_" + pluginName ) ) {
						$.data( this, "plugin_" + pluginName, new Plugin( this, options ) );
				} else {
					var that = $.data( this, "plugin_" + pluginName );
					if (typeof options === "string") {
						res = that[options].apply(that, args);
					}
				}
			});
			return res;
		};

})( jQuery, window, document );  
  
	// log for all callbacks
	$("#pager-holder").neo_pager({
		autoScrollPages: true,
		useDefaultCss: true
	});

	// content transitions
	$(document).ready(function () {
		AOS.init({
			duration: 1200,
		});
	});

	// footer navigation		
	var footerHeight = $('footer').height();
	$('footer').css('height', (footerHeight) + 'px');

	// footer navigation arrow
	// $("#toBtm").click(function() {
	// 	$('html, body').animate({scrollTop: '+=240px'}, 400);
	// 		$(this).addClass('footer-visible');
	// });
});
