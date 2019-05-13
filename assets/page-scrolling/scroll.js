var myFullpage = new fullpage('#fullpage', {
    //Navigation
menu: '#menu',
lockAnchors: true,
anchors:['firstPage', 'secondPage'],
navigation: true,
navigationPosition: 'right',
navigationTooltips: customToolTips,
showActiveTooltip: false,
slidesNavigation: true,
slidesNavPosition: 'bottom',

//Scrolling
css3: true,
scrollingSpeed: 700,
autoScrolling: true,
fitToSection: false,
fitToSectionDelay: 1000,
scrollBar: false,
easing: 'easeInOutCubic',
easingcss3: 'ease',
loopBottom: null,
loopTop: null,
loopHorizontal: true,
continuousVertical: false,
continuousHorizontal: true,
scrollHorizontally: false,
interlockedSlides: false,
dragAndMove: false,
offsetSections: false,
resetSliders: false,
fadingEffect: true,
normalScrollElements: '#element1, .sec-full-cta',
scrollOverflow: false,
scrollOverflowReset: true,
scrollOverflowOptions: null,
touchSensitivity: 15,
normalScrollElementTouchThreshold: 5,
bigSectionsDestination: null,

//Accessibility
keyboardScrolling: true,
animateAnchor: true,
recordHistory: true,

//Design
controlArrows: true,
verticalCentered: true,
// sectionsColor : ['#ccc', '#fff'],
// paddingTop: '3em',
// paddingBottom: '10px',
fixedElements: '#header, .footer',
responsiveWidth: 0,
responsiveHeight: 0,
responsiveSlides: false,
parallax: false,
parallaxOptions: {type: 'reveal', percentage: 62, property: 'translate'},

//Custom selectors
sectionSelector: '.section',
slideSelector: '.slide',

lazyLoading: true,

//events
onLeave: function(origin, destination, direction){},
afterLoad: function(origin, destination, direction){},
afterRender: function(){},
afterResize: function(width, height){},
afterResponsive: function(isResponsive){},
afterSlideLoad: function(section, origin, destination, direction){},
onSlideLeave: function(section, origin, destination, direction){}

});