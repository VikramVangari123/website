@charset "UTF-8";
@import 'https://fonts.googleapis.com/css?family=Roboto:100,300';
@import 'https://fonts.googleapis.com/css?family=Just+Another+Hand';
@-webkit-keyframes zoomIn {
  0% {
    opacity: 0;
    -webkit-transform: scale3d(0.3, 0.3, 0.3);
    transform: scale3d(0.3, 0.3, 0.3);
  }
  100% {
    opacity: 1;
    -webkit-transform: scale3d(0.5, 0.5, 0.5);
    transform: scale3d(0.5, 0.5, 0.5);
  }
}
@keyframes zoomIn {
  0% {
    opacity: 0;
    -webkit-transform: scale3d(0.3, 0.3, 0.3);
    transform: scale3d(0.3, 0.3, 0.3);
  }
  100% {
    opacity: 1;
    -webkit-transform: scale3d(0.5, 0.5, 0.5);
    transform: scale3d(0.5, 0.5, 0.5);
  }
}
/*** media queries **/
/* 
  ##Device = Desktops
  ##Screen = 1281px to higher resolution desktops
*/
/* 
##Device = Laptops, Desktops
##Screen = B/w 1025px to 1280px
*/
/* 
##Device = Tablets, Ipads (portrait)
##Screen = B/w 768px to 1024px
*/
/* 
##Device = Tablets, Ipads (landscape)
##Screen = B/w 768px to 1024px
*/
/* 
##Device = Low Resolution Tablets, Mobiles (Landscape)
##Screen = B/w 481px to 767px
*/
/* 
##Device = Most of the Smartphones Mobiles (Portrait)
##Screen = B/w 320px to 479px
*/
/**max-height 450px **/
/*********** testimonials *************************/
.timeline {
  box-sizing: border-box;
  position: relative;
}
.timeline *,
.timeline *::before,
.timeline *::after {
  box-sizing: inherit;
}
.timeline:not(.timeline--horizontal)::before {
  background-image: linear-gradient(to right, #FF9966 0%, #FF5E62 100%);
  background-position: center;
  bottom: 0;
  content: "";
  left: 50%;
  margin-left: -2px;
  position: absolute;
  top: 0;
  width: 4px;
  z-index: 1;
}

.timeline__wrap {
  overflow: hidden;
  position: relative;
  z-index: 2;
}

.timeline__item {
  font-size: 1rem;
  padding: 10px 40px 10px 0;
  position: relative;
  width: 50%;
  z-index: 2;
}
.timeline__item::after {
  background-color: #fff;
  border: 3px solid #ff7864;
  border-radius: 50%;
  content: "";
  height: 20px;
  position: absolute;
  right: -10px;
  transform: translateY(-50%);
  top: 50%;
  width: 20px;
  z-index: 1;
}
.timeline__item.animated {
  animation-duration: 1s;
  animation-fill-mode: both;
  opacity: 0;
}
.timeline__item.fadeIn {
  animation-name: fadeIn;
}

.timeline__item--left {
  left: 0;
}

.timeline__item--bottom .timeline-icon {
  top: -13px;
}

.timeline__item--right {
  left: 50%;
  padding: 10px 0 10px 40px;
}
.timeline__item--right::after {
  left: -10px;
}
.timeline__item--right .timeline__content::before {
  border-bottom: 10px solid transparent;
  border-right: 12px solid #CCC;
  border-left: none;
  border-top: 10px solid transparent;
  left: -12px;
}
.timeline__item--right .timeline__content::after {
  border-bottom: 9px solid transparent;
  border-right: 11px solid #FFF;
  border-left: none;
  border-top: 9px solid transparent;
  left: -10px;
}

.timeline__content {
  background-color: #FFF;
  -webkit-box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
  box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
  border-radius: 10px;
  color: #333;
  display: block;
  padding: 12px;
  position: relative;
}
.timeline__content::before, .timeline__content::after {
  content: "";
  height: 0;
  position: absolute;
  transform: translateY(-50%);
  top: 50%;
  width: 0;
}
.timeline__content::before {
  border-bottom: 10px solid transparent;
  border-left: 12px solid #CCC;
  border-top: 10px solid transparent;
  right: -12px;
  z-index: 1;
}
.timeline__content::after {
  border-bottom: 9px solid transparent;
  border-left: 11px solid #FFF;
  border-top: 9px solid transparent;
  right: -10px;
  z-index: 2;
}
.timeline__content h2 {
  font-size: 20px;
  font-weight: 700;
  margin: 0 0 10px;
}
.timeline__content p {
  font-size: 15px;
  line-height: 1.5;
  margin-bottom: 10px;
}
.timeline__content p:last-child {
  margin-bottom: 0;
}
.timeline__content .date {
  font-size: 14px;
  margin-bottom: 0px;
}

.timeline--horizontal {
  font-size: 0;
  padding: 0 50px;
  overflow: hidden;
  white-space: nowrap;
}
.timeline--horizontal .timeline-divider {
  background-image: linear-gradient(to right, #FF9966 0%, #FF5E62 100%);
  background-position: center;
  display: block;
  height: 4px;
  left: 40px;
  position: absolute;
  transform: translateY(-50%);
  right: 40px;
  z-index: 1;
}
.timeline--horizontal .timeline__items {
  transition: all 0.8s;
  will-change: transform;
}
.timeline--horizontal .timeline__item {
  display: inline-block;
  left: 0;
  padding: 0 5px 30px;
  position: relative;
  transition: none;
  vertical-align: top;
  white-space: normal;
}
.timeline--horizontal .timeline__item::after {
  left: 50%;
  right: auto;
  transform: translate(-50%, -50%);
  top: 100%;
}
.timeline--horizontal .timeline__item .timeline__item__inner {
  display: table;
  height: 100%;
  width: 100%;
}
.timeline--horizontal .timeline__item .timeline__content__wrap {
  display: table-cell;
  margin: 0;
  padding: 0;
  vertical-align: bottom;
}
.timeline--horizontal .timeline__item .timeline__content::before {
  border-left: 12px solid transparent;
  border-right: 12px solid transparent;
  border-top: 12px solid #f7f7f7;
  left: 50%;
  right: auto;
  transform: translateX(-50%);
  top: 100%;
}
.timeline--horizontal .timeline__item .timeline__content::after {
  border-left: 10px solid transparent;
  border-right: 10px solid transparent;
  border-top: 10px solid #FFF;
  left: 50%;
  right: auto;
  transform: translateX(-50%);
  top: 100%;
}
.timeline--horizontal .timeline__item--bottom {
  padding: 30px 5px 0;
}
.timeline--horizontal .timeline__item--bottom::after {
  top: 0;
}
.timeline--horizontal .timeline__item--bottom .timeline__content__wrap {
  vertical-align: top;
}
.timeline--horizontal .timeline__item--bottom .timeline__content::before {
  border-bottom: 12px solid #f7f7f7;
  border-left: 12px solid transparent;
  border-right: 12px solid transparent;
  border-top: none;
  bottom: 100%;
  top: auto;
}
.timeline--horizontal .timeline__item--bottom .timeline__content::after {
  border-bottom: 10px solid #FFF;
  border-left: 10px solid transparent;
  border-right: 10px solid transparent;
  border-top: none;
  bottom: 100%;
  top: auto;
}

.timeline-nav-button {
  background-image: linear-gradient(to right, #FF9966 0%, #FF5E62 100%);
  background-position: center;
  border: 1px solid #FF9966;
  border-radius: 50px;
  box-sizing: border-box;
  box-shadow: none;
  cursor: pointer;
  display: block;
  height: 40px;
  outline: none;
  position: absolute;
  text-indent: -9999px;
  transform: translateY(-50%);
  top: 50%;
  width: 40px;
  z-index: 10;
}
.timeline-nav-button:disabled {
  opacity: 0.5;
  pointer-events: none;
}
.timeline-nav-button::before {
  background-position: center center;
  background-repeat: no-repeat;
  content: "";
  display: block;
  height: 14px;
  left: 50%;
  position: absolute;
  transform: translateX(-50%) translateY(-50%);
  top: 50%;
  width: 8px;
}
.timeline-nav-button--prev {
  left: 0;
}
.timeline-nav-button--prev::before {
  background-image: url("../../assets/images/arrow-left.svg");
}
.timeline-nav-button--next {
  right: 0;
}
.timeline-nav-button--next::before {
  background-image: url("../../assets/images/arrow-right.svg");
}

.timeline--mobile {
  padding: 0;
}
.timeline--mobile::before {
  left: 10px !important;
  margin: 0 !important;
}
.timeline--mobile .timeline__item {
  left: 0;
  padding-left: 35px;
  padding-right: 4px;
  width: 100%;
}
.timeline--mobile .timeline__item::after {
  left: 2px;
  margin: 0;
}
.timeline--mobile .timeline__item .timeline__content::before {
  left: -12px;
  border-bottom: 12px solid transparent;
  border-right: 12px solid #CCC;
  border-left: none;
  border-top: 12px solid transparent;
}
@media (max-width: 767px) {
  .timeline--mobile .timeline__item .timeline__content::before {
    border-right: 12px solid #f7f7f7;
  }
}
.timeline--mobile .timeline__item .timeline__content::after {
  left: -10px;
  border-bottom: 10px solid transparent;
  border-right: 10px solid #FFF;
  border-left: none;
  border-top: 10px solid transparent;
}

@keyframes fadeIn {
  0% {
    opacity: 0;
    top: 70px;
  }
  100% {
    opacity: 1;
    top: 0px;
  }
}
@keyframes liftUp {
  0% {
    top: 0px;
  }
  100% {
    top: -15px;
  }
}
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

body {
  font-size: 16px;
  font-family: "Roboto", sans-serif;
  color: #808285;
  line-height: 26px;
}

img {
  max-width: 100%;
  height: auto;
}

input,
textarea,
select,
button {
  outline: none;
}

/** select buttons **/
select {
  color: #808285;
  /** if value is empty **/
}
select option[value=""] {
  color: #808285;
}
select option {
  color: #808285;
}
select:invalid {
  color: #808285;
}

/** if value is empty **/
select:invalid {
  color: #808285;
}

/** if value is empty / **/
/** if value should be something **/
.all {
  color: #808285;
}

/** global **/
input::placeholder,
textarea::placeholder,
::placeholder {
  color: #808285 !important;
}

input:-webkit-autofill {
  -webkit-box-shadow: inset 0 0 0px 9999px transparent;
}

ul {
  list-style: none;
  margin: 0;
  padding: 0;
}

ul.list-style1 li {
  position: relative;
  padding-left: 20px;
  margin-bottom: 10px;
}

ul.list-style1 li:before {
  content: "";
  display: inline-block;
  width: 8px;
  background: #808285;
  height: 8px;
  border-radius: 8px;
  position: absolute;
  left: 0;
  top: 9px;
}

ul.list-style1 + .btn {
  margin-top: 20px;
}

a {
  color: #808285;
}

a,
a:hover,
a.active,
a:active,
a:visited,
a:focus {
  text-decoration: none;
  cursor: pointer;
}

h1, h2 {
  line-height: 36px;
}

.content {
  margin: 0;
}

.text-right {
  text-align: right;
}

.text-left {
  text-align: left;
}

.text-center {
  text-align: center;
}

.float-right {
  float: right;
}

.float-left {
  float: left;
}

.upper-case {
  text-transform: uppercase;
}

.hidden {
  display: none !important;
}

@media (min-width: 1281px) {
  .container {
    max-width: 1251px;
    padding: 0 15px;
    margin: 0 auto;
    width: 100%;
  }
}
@media (min-width: 1025px) and (max-width: 1280px) {
  .container {
    max-width: 995px;
    padding: 0 15px;
    margin: 0 auto;
    width: 100%;
  }
}
@media (max-width: 1024px) {
  .container {
    max-width: 100%;
    padding: 0 15px;
    margin: 0 auto;
    width: 100%;
  }
}
@media (max-width: 479px) {
  .container {
    max-width: 100%;
    padding: 0 10px;
    margin: 0 auto;
    width: 100%;
  }
}

.btn {
  margin: 0 0 25px;
  padding: 0px 15px;
  height: 40px;
  line-height: 40px;
  cursor: pointer;
  text-decoration: none;
  min-width: 140px;
  text-align: center;
  display: inline-block;
  vertical-align: middle;
  transition: 0.15s linear;
  -webkit-box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
  box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
  border-radius: 25px;
}
.btn:hover, .btn:focus, .btn:active {
  outline: none;
  -webkit-transform: scale(1.05);
  transform: scale(1.05);
}
@media (max-width: 479px) {
  .btn {
    height: auto;
    line-height: 35px;
    min-height: 35px;
  }
}

.btn-white {
  background: #fff;
  color: #808285;
}

.btn-black {
  background: #989898;
  color: #fff;
}

.btn-submit {
  background: #fff;
}

.home-bg {
  background-image: linear-gradient(to left, #283048 20%, #859398 100%);
  background-position: center;
}

.home-text-bg {
  background-image: linear-gradient(to left, #283048 20%, #859398 100%);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}

.hw-bg {
  background-image: linear-gradient(to right, #89f7fe 0%, #66a6ff 100%);
  background-position: center;
}

.hw-text-bg {
  background-image: linear-gradient(to right, #89f7fe 0%, #66a6ff 100%);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}

.industry-bg {
  background-image: linear-gradient(to right, #f192f5 0%, #f53335 100%);
  background-position: center;
}

.industry-text-bg {
  background-image: linear-gradient(to right, #f192f5 0%, #f53335 100%);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}

.business-area-bg {
  background-image: linear-gradient(to right, #4cbbc4 0%, #3cd3ad 100%);
  background-position: center;
}

.business-area-text-bg {
  background-image: linear-gradient(to right, #4cbbc4 0%, #3cd3ad 100%);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}

.products-bg {
  background-image: linear-gradient(to right, #bc78ec 0%, #3b2667 100%);
  background-position: center;
}

.products-text-bg {
  background-image: linear-gradient(to right, #bc78ec 0%, #3b2667 100%);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}

.ourwork-bg {
  background-image: linear-gradient(to right, #74EBD5 0%, #9FACE6 100%);
  background-position: center;
}

.ourwork-text-bg {
  background-image: linear-gradient(to right, #74EBD5 0%, #9FACE6 100%);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}

.ipgallery-bg {
  background-image: linear-gradient(to right, #1D2B64 0%, #F8CDDA 100%);
  background-position: center;
}

.ipgallery-text-bg {
  background-image: linear-gradient(to right, #1D2B64 0%, #F8CDDA 100%);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}

.brand-mng-bg {
  background-image: linear-gradient(to right, #1d2b64 0%, #f8cdda 100%);
  background-position: center;
}

.brand-mng-text-bg {
  background-image: linear-gradient(to right, #1d2b64 0%, #f8cdda 100%);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}

.blog-bg {
  background-image: linear-gradient(to right, #f5333f 0%, #ac222b 100%);
  background-position: center;
}

.blog-text-bg {
  background-image: linear-gradient(to right, #f5333f 0%, #ac222b 100%);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}

.about-bg {
  background-image: linear-gradient(to right, #FF9966 0%, #FF5E62 100%);
  background-position: center;
}

.about-text-bg {
  background-image: linear-gradient(to right, #FF9966 0%, #FF5E62 100%);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}

.contact-bg {
  background-image: linear-gradient(to right, #ff9966 0%, #ff5e62 100%);
  background-position: center;
}

.contact-text-bg {
  background-image: linear-gradient(to right, #ff9966 0%, #ff5e62 100%);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}

.pillarPage-bg {
  background-image: linear-gradient(to right, #ff9966 0%, #ff5e62 100%);
  background-position: center;
}

.pillarPage-text-bg {
  background-image: linear-gradient(to right, #ff9966 0%, #ff5e62 100%);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}

.notfound-bg {
  background-image: linear-gradient(to right, #443164 0%, #24173a 100%);
  background-position: center;
}

/*** header *************************/
header {
  padding: 30px 0 17px 0;
  height: 60px;
  width: 100%;
  position: fixed;
  z-index: 9999;
  transition: 0.2s padding ease-out;
}
header.fixedheader {
  box-shadow: 0 1px 1px rgba(0, 0, 0, 0.2), 0 -1px 1px rgba(0, 0, 0, 0);
  padding: 17px 0;
}
header .logo {
  text-transform: uppercase;
}
header .logo img {
  width: 160px;
}
header .openNav {
  float: right;
  padding-top: 4px;
}
header .openNav img {
  width: 24px;
}
header .overlay {
  height: 0%;
  width: 100%;
  position: fixed;
  z-index: 1;
  top: 0;
  left: 0;
  background-color: black;
  background-color: rgba(0, 0, 0, 0.9);
  overflow: hidden;
  transition: 0.5s;
}
@media (max-width: 767px) {
  header .overlay {
    background-image: linear-gradient(to right, #79f1a4, #0e5cad);
  }
}
@media (max-height: 450px) {
  header .overlay {
    overflow-y: auto;
  }
}
header .overlay a {
  padding: 0;
  text-decoration: none;
  display: block;
  transition: 0.3s;
  color: #fff;
}
@media (max-height: 450px) {
  header .overlay a {
    font-size: 20px;
  }
}
@media (max-width: 767px) {
  header .overlay a {
    padding: 0;
  }
}
header .overlay .container {
  position: relative;
}
header .overlay .closebtn {
  position: absolute;
  top: 21px;
  right: 15px;
  font-size: 45px;
}
@media (max-height: 450px) {
  header .overlay .closebtn {
    font-size: 40px;
    top: 15px;
    right: 15px;
  }
}
@media (max-width: 767px) {
  header .overlay .closebtn {
    top: 6px;
    right: 15px;
    font-size: 30px;
  }
}
header .overlay .overlay-content {
  position: relative;
  top: 50%;
  width: 100%;
  left: 50%;
  transform: translate(-50%, -50%);
}
@media (max-width: 767px) {
  header .overlay .overlay-content {
    top: 40px;
    left: 0;
    transform: none;
  }
}
@media (max-width: 767px) {
  header .overlay .overlay-content .mega-menu {
    position: relative;
    display: block;
    width: 100%;
    margin: 0 auto;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item {
    display: block !important;
    border-top: 1px solid #f4f4f4;
    z-index: 11;
    transition: 0.3s linear;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item h5 {
    font-size: 20px;
    text-align: left;
    cursor: pointer;
    color: #fff;
    position: relative;
    transition: 0.3s linear;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item h5 a {
    width: calc(100% - 50px);
    padding: 10px;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item .sub-menu-arrow {
    position: absolute;
    top: 0;
    right: 0;
    text-align: center;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item .sub-menu-arrow:before {
    content: "+";
    width: 50px;
    height: 45px;
    position: absolute;
    right: 0;
    display: inline-block;
    font-size: 22px;
    line-height: 48px;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item.active-submenu h5 .sub-menu-arrow:before {
    content: "−";
  }
  header .overlay .overlay-content .mega-menu .megamenu-item.active-submenu .megamenu-sub {
    display: block;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item .megamenu-sub {
    z-index: 12;
    display: none;
    padding: 0;
    overflow: hidden;
    color: #fff;
    transition: 0.3s linear;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item .megamenu-sub ul.megamenu-sub-menu {
    width: 100%;
    overflow: hidden;
    overflow-x: auto;
    white-space: nowrap;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item .megamenu-sub ul.megamenu-sub-menu li {
    margin: 0;
    display: block;
    cursor: pointer;
    position: relative;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item .megamenu-sub ul.megamenu-sub-menu li:first-child {
    border-top: 0;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item .megamenu-sub ul.megamenu-sub-menu li.active-submenu .sub-menu-arrow:before {
    content: "−";
  }
  header .overlay .overlay-content .mega-menu .megamenu-item .megamenu-sub ul.megamenu-sub-menu li.active-submenu .megamenu-tabH {
    display: block;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item .megamenu-sub ul.megamenu-sub-menu li a {
    display: block;
    overflow: hidden;
    white-space: nowrap;
    text-overflow: ellipsis;
    font-size: 18px;
    padding: 10px 10px 10px 25px;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item .megamenu-sub ul.megamenu-sub-menu .megamenu-sub-content {
    width: 100%;
    height: 100%;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item .megamenu-sub ul.megamenu-sub-menu .megamenu-sub-content .megamenu-tabH-in {
    display: block;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item .megamenu-sub ul.megamenu-sub-menu .megamenu-sub-content .megamenu-tabH-in:first-child {
    border-top: 0;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item .megamenu-sub ul.megamenu-sub-menu .megamenu-sub-content .megamenu-tabH-in a {
    padding: 10px 10px 10px 35px;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item .megamenu-sub ul.megamenu-sub-menu .megamenu-sub-content .megamenu-tabH-in img {
    margin: 40px;
    display: none;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item .megamenu-sub ul.megamenu-sub-menu .megamenu-sub-content > div {
    position: relative;
    display: none;
    height: 100%;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item .megamenu-sub ul.megamenu-sub-menu .megamenu-sub-content > div.view {
    display: block;
    width: 100%;
    min-height: 200px;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item .megamenu-sub ul.megamenu-sub-menu .megamenu-sub-content > div p {
    display: block;
    font-size: 17px;
  }
}
@media (min-width: 768px) {
  header .overlay .overlay-content .mega-menu {
    position: relative;
    display: block;
    width: 90%;
    margin: 0 auto;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item {
    display: block !important;
    width: 250px;
    background-color: transparent;
    padding-left: 16px;
    padding-right: 16px;
    padding-bottom: 10px;
    z-index: 11;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item h5 {
    font-size: 24px;
    text-align: left;
    padding: 12px;
    cursor: pointer;
    color: #fff;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item .sub-menu-arrow {
    display: none;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item .megamenu-sub {
    position: absolute;
    z-index: 12;
    display: none;
    padding: 12px 12px 12px 0;
    overflow: hidden;
    color: #fff;
    width: 750px;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item .megamenu-sub .w-3-1 {
    position: relative;
    float: left;
    width: 30%;
    margin-right: 3%;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item .megamenu-sub ul.megamenu-sub-menu {
    width: 100%;
    overflow: hidden;
    overflow-x: auto;
    white-space: nowrap;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item .megamenu-sub ul.megamenu-sub-menu li {
    margin: 0 -0.2em 0 0;
    display: inline-block;
    cursor: pointer;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item .megamenu-sub ul.megamenu-sub-menu li a {
    display: block;
    min-width: 140px;
    max-width: 300px;
    overflow: hidden;
    white-space: nowrap;
    text-overflow: ellipsis;
    font-size: 24px;
    color: #eaeaea;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item .megamenu-sub ul.megamenu-sub-menu .megamenu-sub-content {
    position: absolute;
    top: 60px;
    left: 0;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item .megamenu-sub ul.megamenu-sub-menu .megamenu-sub-content .megamenu-tabH-in {
    display: inline-block;
    background: rgba(255, 255, 255, 0.2);
    padding: 0px;
    margin-right: 20px;
    position: relative;
    vertical-align: top;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item .megamenu-sub ul.megamenu-sub-menu .megamenu-sub-content .megamenu-tabH-in a {
    font-size: 16px;
    height: 180px;
    width: 180px;
    display: flex;
    -webkit-display: flex;
    align-items: center;
    justify-content: center;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item .megamenu-sub ul.megamenu-sub-menu .megamenu-sub-content .megamenu-tabH-in a img {
    margin: 0px;
    -webkit-transition: transform 0.2s ease-in-out;
    transition: transform 0.2s ease-in-out;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item .megamenu-sub ul.megamenu-sub-menu .megamenu-sub-content .megamenu-tabH-in a:hover img {
    -webkit-transform: scale(1.05);
    -moz-transform: scale(1.05);
    transform: scale(1.05);
  }
  header .overlay .overlay-content .mega-menu .megamenu-item .megamenu-sub ul.megamenu-sub-menu .megamenu-sub-content > div {
    position: relative;
    padding: 5px;
    display: none;
    height: 100%;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item .megamenu-sub ul.megamenu-sub-menu .megamenu-sub-content > div.view {
    display: block;
    width: 100%;
    min-height: 200px;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item .megamenu-sub ul.megamenu-sub-menu .megamenu-sub-content > div p {
    display: block;
    color: #fff;
    position: absolute;
    bottom: 5px;
    text-align: center;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item:hover .megamenu-sub, header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-sub {
    display: block;
    top: 0px;
    left: 0px;
    margin-left: 249px;
    height: 100%;
    border-left: none;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item:hover .megamenu-sub .megamenu-sub-menu li.active a, header .overlay .overlay-content .mega-menu .megamenu-item:hover .megamenu-sub .megamenu-sub-menu li:hover a, header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-sub .megamenu-sub-menu li.active a, header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-sub .megamenu-sub-menu li:hover a {
    color: #fff;
  }
  header .overlay .overlay-content .mega-menu .megamenu-item:hover .megamenu-sub .megamenu-sub-menu li.active .megamenu-tabH, header .overlay .overlay-content .mega-menu .megamenu-item:hover .megamenu-sub .megamenu-sub-menu li:hover .megamenu-tabH, header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-sub .megamenu-sub-menu li.active .megamenu-tabH, header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-sub .megamenu-sub-menu li:hover .megamenu-tabH {
    display: block;
  }
}

.main {
  margin-top: 59px;
  float: left;
  width: 100%;
  overflow: hidden;
  clear: both;
}
.main .section:first-child .right50 img {
  max-width: 500px;
}
@media (min-width: 480px) and (max-width: 767px) {
  .main .section:first-child .right50 img {
    max-width: 400px;
  }
}
@media (max-width: 479px) {
  .main .section:first-child .right50 img {
    max-width: 300px;
  }
}

.title {
  display: flex;
  justify-content: space-between;
  clear: both;
}
.title .view-all {
  font-size: 18px;
  height: 22px;
  margin-top: 6px;
}
.title .view-all img {
  margin-left: 10px;
  vertical-align: text-top;
  width: 16px;
  margin-top: 3px;
}

.section {
  padding: 40px 0;
  border: 1px #b0b0b0;
  overflow: hidden;
}
@media (max-width: 1024px) {
  .section {
    height: auto !important;
  }
}
@media (max-width: 479px) {
  .section {
    padding: 25px 0 !important;
  }
}

.section-in {
  display: flex;
  align-items: center;
  justify-content: center;
  width: 100%;
}
@media (max-width: 1024px) {
  .section-in {
    display: block !important;
    height: auto !important;
  }
}
@media (max-width: 1024px) {
  .section-in.flex-col-rev {
    display: flex !important;
    flex-flow: column-reverse;
  }
  .section-in.flex-col-rev .right60, .section-in.flex-col-rev .right50 {
    margin-top: 0;
    margin-bottom: 30px;
  }
}

.pb0 {
  padding-bottom: 0 !important;
}

h2 {
  margin-bottom: 25px;
  font-size: 46px;
  line-height: 50px;
  font-weight: normal;
}
@media (max-width: 479px) {
  h2 {
    font-size: 24px;
    margin-bottom: 20px;
    line-height: 30px;
  }
}

h1 {
  font-size: 46px;
  font-weight: normal;
  line-height: 50px;
  margin-bottom: 25px;
  position: relative;
  color: #fff;
  max-width: 410px;
  font-weight: normal;
}
@media (max-width: 1024px) {
  h1 {
    font-size: 36px;
    line-height: 42px;
    max-width: 100%;
  }
}
@media (max-width: 479px) {
  h1 {
    font-size: 26px;
    line-height: 30px;
    margin-bottom: 20px;
  }
}

p + .btn {
  margin-top: 20px;
}

h3 {
  font-size: 24px;
}
@media (min-width: 480px) and (max-width: 767px) {
  h3 {
    font-size: 22px;
  }
}
@media (max-width: 479px) {
  h3 {
    font-size: 20px;
  }
}

h4 {
  font-size: 20px;
}
@media (max-width: 767px) {
  h4 {
    font-size: 18px;
  }
}

h3, h4, h5, h6 {
  font-weight: normal;
}

.bg-1 {
  background: #f4f4f4;
}

.bg-2 {
  background: #f8f8f8;
}

.bg-3 {
  background: #f1f1f1;
}

.bg-4 {
  background: #f9f9f9;
}

hr {
  width: 100%;
  border: 0;
  border-bottom: 1.5px solid #c8c8c8;
}

.left60, .right60 {
  width: 59%;
  display: inline-block;
  vertical-align: middle;
}
@media (max-width: 1024px) {
  .left60, .right60 {
    width: 100%;
    display: block;
  }
}

.right40, .left40 {
  width: 40%;
  display: inline-block;
  vertical-align: middle;
}
@media (max-width: 1024px) {
  .right40, .left40 {
    width: 100%;
    display: block;
  }
}

.left50, .right50 {
  width: 49%;
  display: inline-block;
  vertical-align: middle;
}
@media (max-width: 1024px) {
  .left50, .right50 {
    width: 100%;
    display: block;
  }
}
@media (max-width: 1024px) {
  .left50 .resp-img, .right50 .resp-img {
    max-width: 320px;
  }
}
@media (max-width: 767px) {
  .left50 .resp-img, .right50 .resp-img {
    max-width: 300px;
  }
}
@media (max-width: 479px) {
  .left50 .resp-img, .right50 .resp-img {
    max-width: 280px;
  }
}

.right60, .right50 {
  margin-top: 30px;
}

.banner-sec p {
  color: #fff;
  margin-bottom: 15px;
}
.banner-sec .social-icons span {
  margin-left: 20px;
}
.banner-sec .social-icons span a {
  display: inline-block;
  vertical-align: middle;
}
.banner-sec .social-icons span img {
  width: 75%;
  -webkit-transition: transform 0.5s ease-in-out;
  transition: transform 0.5s ease-in-out;
}
@media (max-width: 479px) {
  .banner-sec .social-icons span img {
    width: 70%;
  }
}
.banner-sec .social-icons span:hover img {
  transform: rotate(360deg);
  -webkit-transform: rotate(360deg);
}
.banner-sec .social-icons span:first-child {
  margin-left: 0;
}
@media (max-width: 1024px) {
  .banner-sec .social-icons span {
    margin-left: 8px;
  }
}

.interactive-print, .book-free-trial, .contact-cta {
  background: #f1f1f1;
}
.interactive-print p.text, .book-free-trial p.text, .contact-cta p.text {
  vertical-align: middle;
  display: inline-block;
  width: calc(100% - 240px);
}
@media (max-width: 767px) {
  .interactive-print p.text, .book-free-trial p.text, .contact-cta p.text {
    width: 100%;
    display: block;
  }
}
.interactive-print p.text + div, .book-free-trial p.text + div, .contact-cta p.text + div {
  vertical-align: middle;
  margin: 0;
  display: inline-block;
  text-align: right;
  width: 236px;
}
@media (max-width: 767px) {
  .interactive-print p.text + div, .book-free-trial p.text + div, .contact-cta p.text + div {
    width: 100%;
    display: block;
    margin-top: 10px;
    text-align: center;
  }
}
.interactive-print p.text + div .btn, .book-free-trial p.text + div .btn, .contact-cta p.text + div .btn {
  margin: 0;
}
.interactive-print .btn, .book-free-trial .btn, .contact-cta .btn {
  margin: 0;
}

.copy-right {
  text-align: center;
  color: #fff;
  background-color: #c8c8c8;
  padding: 10px 0 !important;
}
.copy-right div div {
  padding-top: 3px;
}

nav.nav-split .icon-wrap {
  position: relative;
  display: block;
  padding: 4px 0;
}
@media (max-width: 767px) {
  nav.nav-split .icon-wrap {
    padding: 1px 0;
  }
}
nav.nav-split svg.icon {
  -webkit-transition: -webkit-transform 0.3s 0.3s;
  transition: transform 0.3s 0.3s;
  fill: #fff;
  width: 16px;
}
@media (max-width: 767px) {
  nav.nav-split svg.icon {
    width: 12px;
  }
}
nav.nav-split a {
  color: #fff;
  text-decoration: none;
  position: absolute;
  display: block;
  outline: none;
  text-align: left;
  z-index: 1000;
  transition: 0.15s linear;
  width: 30px;
  height: 30px;
  border-radius: 50%;
  cursor: pointer;
  -webkit-box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
  box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
}
@media (max-width: 767px) {
  nav.nav-split a {
    width: 23px;
    height: 23px;
  }
}
nav.nav-split a svg {
  display: block;
  margin: 0 auto;
  padding: 0;
}
nav.nav-split:hover svg.icon {
  -webkit-transition-delay: 0s;
  transition-delay: 0s;
}

.svg-wrap {
  height: 0;
  width: 0;
  position: absolute;
  overflow: hidden;
}

.sec-sm-cta {
  background: none;
  padding-top: 0 !important;
}
.sec-sm-cta .sec-sm-cta-in {
  padding: 30px;
  -webkit-box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
  box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
  border-radius: 3px;
  color: #fff;
}
@media (max-width: 767px) {
  .sec-sm-cta .sec-sm-cta-in {
    padding: 20px;
  }
}
.sec-sm-cta .sec-sm-cta-in p.text {
  vertical-align: middle;
  display: inline-block;
  width: calc(100% - 240px);
  font-size: 20px;
}
@media (max-width: 767px) {
  .sec-sm-cta .sec-sm-cta-in p.text {
    width: 100%;
    display: block;
  }
}
.sec-sm-cta .sec-sm-cta-in div {
  vertical-align: middle;
  margin: 0;
  display: inline-block;
  text-align: right;
  width: 236px;
}
@media (max-width: 767px) {
  .sec-sm-cta .sec-sm-cta-in div {
    width: 100%;
    display: block;
    margin-top: 10px;
    text-align: center;
  }
}
.sec-sm-cta .sec-sm-cta-in div .btn {
  margin: 0;
}

.subscribe input#subscribe-email, .subscribe .submit-btn {
  display: table-cell;
}
@media (max-width: 767px) {
  .subscribe {
    width: 100% !important;
    text-align: center;
  }
}
.subscribe input#subscribe-email {
  position: relative;
  z-index: 2;
  color: #fff;
  float: left;
  margin-bottom: 0;
  display: block;
  width: 300px;
  height: 40px;
  padding: 6px 0px;
  background-color: transparent;
  background-image: none;
  border: 0;
  border-bottom: 1px solid #fff;
  border-radius: 0px;
  -webkit-transition: border-color ease-in-out 0.15s, -webkit-box-shadow ease-in-out 0.15s;
  -o-transition: border-color ease-in-out 0.15s, box-shadow ease-in-out 0.15s;
  transition: border-color ease-in-out 0.15s, box-shadow ease-in-out 0.15s;
}
@media (min-width: 768px) and (max-width: 1024px) {
  .subscribe input#subscribe-email {
    width: 230px;
  }
}
@media (max-width: 479px) {
  .subscribe input#subscribe-email {
    width: 200px;
  }
}
@media (max-width: 767px) {
  .subscribe input#subscribe-email {
    display: inline-block;
    float: none;
  }
}
.subscribe input#subscribe-email::placeholder {
  color: #fff !important;
}
.subscribe .submit-btn {
  width: 1%;
  white-space: nowrap;
  vertical-align: middle;
  position: relative;
}
.subscribe .submit-btn .btn {
  margin: 0;
  border: 1px solid #ccc;
  width: 120px;
  min-width: 120px;
}
@media (max-width: 479px) {
  .subscribe .submit-btn .btn {
    min-width: 100px;
    width: 100px;
  }
}
@media (max-width: 767px) {
  .subscribe .submit-btn {
    display: inline-block;
    margin-left: -4px;
    width: auto;
  }
}

.subscribe-sec {
  padding-top: 0 !important;
  color: #fff;
}
.subscribe-sec .subscribe-sec-in {
  padding: 30px;
  -webkit-box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
  box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
  border-radius: 3px;
  color: #fff;
  display: flex;
  -webkit-display: flex;
  justify-content: space-between;
  align-items: center;
}
@media (max-width: 1024px) {
  .subscribe-sec .subscribe-sec-in {
    display: block;
  }
}
.subscribe-sec .subscribe-sec-in p.text {
  font-size: 20px;
}
@media (max-width: 767px) {
  .subscribe-sec .subscribe-sec-in p.text {
    width: 100%;
    display: block;
  }
}
.subscribe-sec .subscribe-sec-in div {
  margin: 0;
}
@media (max-width: 767px) {
  .subscribe-sec .subscribe-sec-in div {
    width: 100%;
    display: block;
    margin-top: 10px;
    text-align: center;
  }
}
.subscribe-sec .subscribe-sec-in div .btn {
  margin: 0;
}

/*************************** home *****************************/
.home header .overlay {
  background-image: linear-gradient(to left, #283048 20%, #859398 100%);
  background-position: center;
}
.home header .overlay .overlay-content .mega-menu .megamenu-item.active h5 a {
  color: #78cfe2;
  font-weight: bold;
}
.home header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-tabH-in a:hover p, .home header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-tabH-in a.active p {
  color: #78cfe2;
}
.home .testimonial .pagination span.current {
  box-shadow: none;
  background-image: linear-gradient(to left, #283048 20%, #859398 100%);
  background-position: center;
}
.home .testimonial .pagination span:hover {
  box-shadow: none;
  background-image: linear-gradient(to left, #283048 20%, #859398 100%);
  background-position: center;
}
.home .sec-sm-cta .sec-sm-cta-in {
  background-image: linear-gradient(to left, #283048 20%, #859398 100%);
  background-position: center;
}
.home footer .footer-top {
  background-image: linear-gradient(to left, #283048 20%, #859398 100%);
  background-position: center;
}
.home footer .copy-right {
  background-image: linear-gradient(to left, #2c344c 20%, #6c7d84 100%);
  background-position: center;
}

/****************************** how we work page *******************************/
.how-we-work header .overlay {
  background-image: linear-gradient(to right, #89f7fe 0%, #66a6ff 100%);
  background-position: center;
}
.how-we-work header .overlay .overlay-content .mega-menu .megamenu-item.active h5 a {
  color: #448cef;
  font-weight: bold;
}
.how-we-work header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-tabH-in a:hover p, .how-we-work header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-tabH-in a.active p {
  color: #448cef;
}
.how-we-work header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-sub .megamenu-sub-menu li.active a {
  color: #448cef;
}
.how-we-work header .overlay .overlay-content .mega-menu .megamenu-item:hover .megamenu-sub .megamenu-sub-menu li.active a, .how-we-work header .overlay .overlay-content .mega-menu .megamenu-item:hover .megamenu-sub .megamenu-sub-menu li:hover a {
  color: #448cef;
}
.how-we-work footer .footer-top {
  background-image: linear-gradient(to right, #89f7fe 0%, #66a6ff 100%);
  background-position: center;
}
.how-we-work footer .copy-right {
  background-image: linear-gradient(to right, #87e5eb 0%, #5093ef 100%);
  background-position: center;
}

/*************************** industry *****************************/
.industry header .overlay {
  background-image: linear-gradient(to right, #f192f5 0%, #f53335 100%);
  background-position: center;
}
.industry header .overlay .overlay-content .mega-menu .megamenu-item.active h5 a {
  color: #f53437;
  font-weight: bold;
}
.industry header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-tabH-in a:hover p, .industry header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-tabH-in a.active p {
  color: #f53437;
}
.industry header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-sub .megamenu-sub-menu li.active a {
  color: #f53437;
}
.industry header .overlay .overlay-content .mega-menu .megamenu-item:hover .megamenu-sub .megamenu-sub-menu li.active a, .industry header .overlay .overlay-content .mega-menu .megamenu-item:hover .megamenu-sub .megamenu-sub-menu li:hover a {
  color: #f53437;
}
.industry .testimonial .pagination span.current {
  box-shadow: none;
  background-image: linear-gradient(to right, #f192f5 0%, #f53335 100%);
  background-position: center;
}
.industry .testimonial .pagination span:hover {
  box-shadow: none;
  background-image: linear-gradient(to right, #f192f5 0%, #f53335 100%);
  background-position: center;
}
.industry ul.list-style1 li:before {
  background-image: linear-gradient(to right, #f192f5 0%, #f53335 100%);
  background-position: center;
}
.industry .sec-sm-cta .sec-sm-cta-in {
  background-image: linear-gradient(to right, #f192f5 0%, #f53335 100%);
  background-position: center;
}
.industry footer .footer-top {
  background-image: linear-gradient(to right, #f192f5 0%, #f53335 100%);
  background-position: center;
}
.industry footer .copy-right {
  background-image: linear-gradient(to right, #e27be6 0%, #ef2628 100%);
  background-position: center;
}

/*************************** business area *****************************/
.business-area header .overlay {
  background-image: linear-gradient(to right, #4cbbc4 0%, #3cd3ad 100%);
  background-position: center;
}
.business-area header .overlay .overlay-content .mega-menu .megamenu-item.active h5 a {
  color: #4b96fb;
  font-weight: bold;
}
.business-area header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-tabH-in a:hover p, .business-area header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-tabH-in a.active p {
  color: #4b96fb;
}
.business-area header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-sub .megamenu-sub-menu li.active a {
  color: #4b96fb;
}
.business-area header .overlay .overlay-content .mega-menu .megamenu-item:hover .megamenu-sub .megamenu-sub-menu li.active a, .business-area header .overlay .overlay-content .mega-menu .megamenu-item:hover .megamenu-sub .megamenu-sub-menu li:hover a {
  color: #4b96fb;
}
.business-area .testimonial .pagination span.current {
  box-shadow: none;
  background-image: linear-gradient(to right, #4cbbc4 0%, #3cd3ad 100%);
  background-position: center;
}
.business-area .testimonial .pagination span:hover {
  box-shadow: none;
  background-image: linear-gradient(to right, #4cbbc4 0%, #3cd3ad 100%);
  background-position: center;
}
.business-area ul.list-style1 li:before {
  background-image: linear-gradient(to right, #4cbbc4 0%, #3cd3ad 100%);
  background-position: center;
}
.business-area .sec-sm-cta .sec-sm-cta-in {
  background-image: linear-gradient(to right, #4cbbc4 0%, #3cd3ad 100%);
  background-position: center;
}
.business-area footer .footer-top {
  background-image: linear-gradient(to right, #4cbbc4 0%, #3cd3ad 100%);
  background-position: center;
}
.business-area footer .copy-right {
  background-image: linear-gradient(to right, #5fc3cc 0%, #3ff1c4 100%);
  background-position: center;
}

/*************************** products *****************************/
.products header .overlay {
  background-image: linear-gradient(to right, #bc78ec 0%, #3b2667 100%);
  background-position: center;
}
.products header .overlay .overlay-content .mega-menu .megamenu-item.active h5 a {
  color: #412a6d;
  font-weight: bold;
}
.products header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-tabH-in a:hover p, .products header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-tabH-in a.active p {
  color: #412a6d;
}
.products header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-sub .megamenu-sub-menu li.active a {
  color: #412a6d;
}
.products header .overlay .overlay-content .mega-menu .megamenu-item:hover .megamenu-sub .megamenu-sub-menu li.active a, .products header .overlay .overlay-content .mega-menu .megamenu-item:hover .megamenu-sub .megamenu-sub-menu li:hover a {
  color: #412a6d;
}
.products .products-bg:nth-child(1) p {
  color: #fff;
  font-size: 18px;
}
.products .pagination span.current {
  box-shadow: none;
  background-image: linear-gradient(to right, #bc78ec 0%, #3b2667 100%);
  background-position: center;
}
.products .pagination span:hover {
  box-shadow: none;
  background-image: linear-gradient(to right, #bc78ec 0%, #3b2667 100%);
  background-position: center;
}
.products .sec-sm-cta .sec-sm-cta-in {
  background-image: linear-gradient(to right, #bc78ec 0%, #3b2667 100%);
  background-position: center;
}
.products footer .footer-top {
  background-image: linear-gradient(to right, #bc78ec 0%, #3b2667 100%);
  background-position: center;
}
.products footer .copy-right {
  background-image: linear-gradient(to right, #c489ed 0%, #4b2a91 100%);
  background-position: center;
}

/*************************** our work gallery header *****************************/
.ourwork-gallery header {
  padding: 17px 0;
}
.ourwork-gallery header .overlay {
  background-image: linear-gradient(to right, #74EBD5 0%, #9FACE6 100%);
  background-position: center;
}
.ourwork-gallery header .overlay .overlay-content .mega-menu .megamenu-item.active h5 a {
  color: #9FACE6;
  font-weight: bold;
}
.ourwork-gallery header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-tabH-in a:hover p, .ourwork-gallery header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-tabH-in a.active p {
  color: #9FACE6;
}
.ourwork-gallery header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-sub .megamenu-sub-menu li.active a {
  color: #9FACE6;
}
.ourwork-gallery header .overlay .overlay-content .mega-menu .megamenu-item:hover .megamenu-sub .megamenu-sub-menu li.active a, .ourwork-gallery header .overlay .overlay-content .mega-menu .megamenu-item:hover .megamenu-sub .megamenu-sub-menu li:hover a {
  color: #9FACE6;
}
.ourwork-gallery footer .footer-top {
  background-image: linear-gradient(to right, #74EBD5 0%, #9FACE6 100%);
  background-position: center;
}
.ourwork-gallery footer .copy-right {
  background-image: linear-gradient(to right, #66dfc8 0%, #92a3ed 100%);
  background-position: center;
}

/*************************** our work gallery header *****************************/
.intprint-gallery header {
  padding: 17px 0;
}
.intprint-gallery header .overlay {
  background-image: linear-gradient(to right, #1D2B64 0%, #F8CDDA 100%);
  background-position: center;
}
.intprint-gallery header .overlay .overlay-content .mega-menu .megamenu-item.active h5 a {
  color: #F8CDDA;
  font-weight: bold;
}
.intprint-gallery header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-tabH-in a:hover p, .intprint-gallery header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-tabH-in a.active p {
  color: #F8CDDA;
}
.intprint-gallery header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-sub .megamenu-sub-menu li.active a {
  color: #F8CDDA;
}
.intprint-gallery header .overlay .overlay-content .mega-menu .megamenu-item:hover .megamenu-sub .megamenu-sub-menu li.active a, .intprint-gallery header .overlay .overlay-content .mega-menu .megamenu-item:hover .megamenu-sub .megamenu-sub-menu li:hover a {
  color: #F8CDDA;
}
.intprint-gallery footer .footer-top {
  background-image: linear-gradient(to right, #1D2B64 0%, #F8CDDA 100%);
  background-position: center;
}
.intprint-gallery footer .copy-right {
  background-image: linear-gradient(to right, #203072 0%, #ebbecc 100%);
  background-position: center;
}

/*************************** brand-managers *****************************/
.brand-managers header .overlay {
  background-image: linear-gradient(to right, #1d2b64 0%, #f8cdda 100%);
  background-position: center;
}
.brand-managers header .overlay .overlay-content .mega-menu .megamenu-item.active h5 a {
  color: #ec8eab;
  font-weight: bold;
}
.brand-managers header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-tabH-in a:hover p, .brand-managers header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-tabH-in a.active p {
  color: #ec8eab;
}
.brand-managers header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-sub .megamenu-sub-menu li.active a {
  color: #ec8eab;
}
.brand-managers header .overlay .overlay-content .mega-menu .megamenu-item:hover .megamenu-sub .megamenu-sub-menu li.active a, .brand-managers header .overlay .overlay-content .mega-menu .megamenu-item:hover .megamenu-sub .megamenu-sub-menu li:hover a {
  color: #ec8eab;
}
.brand-managers .pagination span.current {
  box-shadow: none;
  background-image: linear-gradient(to right, #1d2b64 0%, #f8cdda 100%);
  background-position: center;
}
.brand-managers .pagination span:hover {
  box-shadow: none;
  background-image: linear-gradient(to right, #1d2b64 0%, #f8cdda 100%);
  background-position: center;
}
.brand-managers .sec-sm-cta .sec-sm-cta-in {
  background-image: linear-gradient(to right, #1d2b64 0%, #f8cdda 100%);
  background-position: center;
}
.brand-managers footer .footer-top {
  background-image: linear-gradient(to right, #1d2b64 0%, #f8cdda 100%);
  background-position: center;
}
.brand-managers footer .copy-right {
  background-image: linear-gradient(to right, #283670 0%, #ddaaba 100%);
  background-position: center;
}

/****************************** blog main *******************************/
.blog header {
  padding: 17px 0;
}
.blog header .overlay {
  background-image: linear-gradient(to right, #f5333f 0%, #ac222b 100%);
  background-position: center;
}
.blog header .overlay .overlay-content .mega-menu .megamenu-item.active h5 a {
  color: #653235;
  font-weight: bold;
}
.blog header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-tabH-in a:hover p, .blog header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-tabH-in a.active p {
  color: #653235;
}
.blog header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-sub .megamenu-sub-menu li.active a {
  color: #653235;
}
.blog header .overlay .overlay-content .mega-menu .megamenu-item:hover .megamenu-sub .megamenu-sub-menu li.active a, .blog header .overlay .overlay-content .mega-menu .megamenu-item:hover .megamenu-sub .megamenu-sub-menu li:hover a {
  color: #653235;
}
.blog footer .footer-top {
  background-image: linear-gradient(to right, #f5333f 0%, #ac222b 100%);
  background-position: center;
}
.blog footer .copy-right {
  background-image: linear-gradient(to right, #ef404b 0%, #ca2f39 100%);
  background-position: center;
}

/*************************** about *****************************/
.about header .overlay {
  background-image: linear-gradient(to right, #FF9966 0%, #FF5E62 100%);
  background-position: center;
}
.about header .overlay .overlay-content .mega-menu .megamenu-item.active h5 a {
  color: #ef141a;
  font-weight: bold;
}
.about header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-tabH-in a:hover p, .about header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-tabH-in a.active p {
  color: #ef141a;
}
.about header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-sub .megamenu-sub-menu li.active a {
  color: #ef141a;
}
.about header .overlay .overlay-content .mega-menu .megamenu-item:hover .megamenu-sub .megamenu-sub-menu li.active a, .about header .overlay .overlay-content .mega-menu .megamenu-item:hover .megamenu-sub .megamenu-sub-menu li:hover a {
  color: #ef141a;
}
@media (min-width: 480px) and (max-width: 1024px) {
  .about .our-team .section-in {
    display: flex !important;
  }
}
.about .member-profile {
  width: 33.333%;
  text-align: center;
}
@media (max-width: 479px) {
  .about .member-profile {
    width: 100%;
    margin-bottom: 40px;
  }
}
@media (max-width: 479px) {
  .about .member-profile:last-child {
    margin-bottom: 0px;
  }
}
.about .member-profile .member-thumb {
  width: 180px;
  height: 180px;
  margin: 0 auto;
  border-radius: 50%;
  overflow: hidden;
  -webkit-box-shadow: 0 10px 12px -4px rgba(0, 0, 0, 0.3);
  box-shadow: 0 10px 12px -4px rgba(0, 0, 0, 0.3);
}
@media (min-width: 480px) and (max-width: 1024px) {
  .about .member-profile .member-thumb {
    width: 145px;
    height: 145px;
  }
}
.about .member-profile .member-thumb img {
  width: 100%;
  height: 100%;
}
.about .member-profile .member-info {
  margin-top: 20px;
  color: #000;
}
@media (min-width: 480px) and (max-width: 1024px) {
  .about .member-profile .member-info h3 {
    font-size: 20px;
  }
}
.about .member-profile .member-info .designation {
  margin: 5px 0;
}
.about .member-profile .member-info .profile-nav {
  width: 30px;
  margin: 0 auto;
}
.about .member-profile .member-info .profile-nav a {
  width: 30px;
  height: 30px;
  background-image: linear-gradient(to right, #FF9966 0%, #FF5E62 100%);
  background-position: center;
  display: block;
  border-radius: 50%;
}
.about .member-profile .member-info .profile-nav a img {
  width: 16px;
  vertical-align: middle;
  -webkit-transition: transform 0.5s ease-in-out;
  transition: transform 0.5s ease-in-out;
}
.about .member-profile .member-info .profile-nav a:hover img {
  transform: rotate(360deg);
  -webkit-transform: rotate(360deg);
}
.about .core-values .section-in {
  display: block;
}
.about .core-values .core-values-in {
  margin: 0 -15px;
}
.about .core-values .cv-panel {
  width: calc(100% / 3 - 3px);
  padding: 17px 15px;
  display: inline-block;
  vertical-align: middle;
}
@media (max-width: 767px) {
  .about .core-values .cv-panel {
    width: 100%;
  }
}
@media (max-width: 767px) {
  .about .core-values .cv-panel:last-child {
    padding-bottom: 0 !important;
  }
}
.about .core-values .cv-panel .cv-panel-in {
  -webkit-box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
  box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
  padding: 15px;
  border-radius: 8px;
  height: 185px;
  overflow: hidden;
}
.about .core-values .cv-panel .cv-panel-in .icon img {
  width: 25px;
  margin-right: 12px;
}
.about .core-values .cv-panel .cv-panel-in .cv-title {
  color: #000;
  font-size: 22px;
}
.about .core-values .cv-panel .cv-panel-in .desc {
  margin-top: 15px;
}
@media (min-width: 1025px) and (max-width: 1280px) {
  .about .core-values .cv-panel .cv-panel-in {
    height: 200px;
  }
}
@media (min-width: 768px) and (max-width: 1024px) {
  .about .core-values .cv-panel .cv-panel-in {
    height: 250px;
  }
}
@media (max-width: 767px) {
  .about .core-values .cv-panel .cv-panel-in {
    height: auto;
  }
}
.about footer .footer-top {
  background-image: linear-gradient(to right, #FF9966 0%, #FF5E62 100%);
  background-position: center;
}
.about footer .copy-right {
  background-image: linear-gradient(to right, #fb8f5a 0%, #f55054 100%);
  background-position: center;
}

/*************************** contact *****************************/
.contact header .overlay {
  background-image: linear-gradient(to right, #ff9966 0%, #ff5e62 100%);
  background-position: center;
}
.contact header .overlay .overlay-content .mega-menu .megamenu-item.active h5 a {
  color: #f54548;
  font-weight: bold;
}
.contact header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-tabH-in a:hover p, .contact header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-tabH-in a.active p {
  color: #f54548;
}
.contact header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-sub .megamenu-sub-menu li.active a {
  color: #f54548;
}
.contact header .overlay .overlay-content .mega-menu .megamenu-item:hover .megamenu-sub .megamenu-sub-menu li.active a, .contact header .overlay .overlay-content .mega-menu .megamenu-item:hover .megamenu-sub .megamenu-sub-menu li:hover a {
  color: #f54548;
}
.contact .contact-block .title {
  justify-content: center;
}
.contact .contact-block .contact-block-in {
  width: 320px;
}
.contact .contact-block .contact-block-in label {
  position: relative;
}
.contact .contact-block .contact-block-in label:before {
  content: "";
  width: 20px;
  height: 22px;
  margin: 0;
  position: absolute;
}
.contact .contact-block .contact-block-in label.name:before {
  background: url(https://cdn2.hubspot.net/hubfs/1635524/assets/website/images/contact/user.png) center/contain no-repeat;
}
.contact .contact-block .contact-block-in label.mobile:before {
  background: url(https://cdn2.hubspot.net/hubfs/1635524/assets/website/images/contact/mobile.png) center/contain no-repeat;
}
.contact .contact-block .contact-block-in label.email:before {
  background: url(https://cdn2.hubspot.net/hubfs/1635524/assets/website/images/contact/email.png) center/contain no-repeat;
}
.contact .contact-block .contact-block-in label.query:before {
  background: url(https://cdn2.hubspot.net/hubfs/1635524/assets/website/images/contact/query.png) center/contain no-repeat;
}
.contact .contact-block .contact-block-in label.brand-name:before {
  background: url(https://cdn2.hubspot.net/hubfs/1635524/assets/website/images/contact/brand.png) center/contain no-repeat;
}
.contact .contact-block .contact-block-in label input, .contact .contact-block .contact-block-in label textarea {
  width: 100%;
  border: 0;
  border-bottom: 1px solid #7d7d7d;
  padding: 3px 0 3px 30px;
  background: 0 0;
  margin-bottom: 40px;
}
.contact .contact-block .contact-block-in label textarea {
  width: 100%;
  height: 70px;
  resize: none;
}
.contact .contact-block .contact-block-in .btn {
  width: 100%;
  border: 1px solid transparent;
  color: #fff;
  font-size: 18px;
}
.contact footer .footer-top {
  background-image: linear-gradient(to right, #ff9966 0%, #ff5e62 100%);
  background-position: center;
}
.contact footer .copy-right {
  background-image: linear-gradient(to right, #f9905c 0%, #f56266 100%);
  background-position: center;
}

/*************************** pillarPage *****************************/
.pillarPage header .overlay {
  background-image: linear-gradient(to right, #ff9966 0%, #ff5e62 100%);
  background-position: center;
}
.pillarPage header .overlay .overlay-content .mega-menu .megamenu-item.active h5 a {
  color: #f54548;
  font-weight: bold;
}
.pillarPage header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-tabH-in a:hover p, .pillarPage header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-tabH-in a.active p {
  color: #f54548;
}
.pillarPage header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-sub .megamenu-sub-menu li.active a {
  color: #f54548;
}
.pillarPage header .overlay .overlay-content .mega-menu .megamenu-item:hover .megamenu-sub .megamenu-sub-menu li.active a, .pillarPage header .overlay .overlay-content .mega-menu .megamenu-item:hover .megamenu-sub .megamenu-sub-menu li:hover a {
  color: #f54548;
}
.pillarPage footer .footer-top {
  background-image: linear-gradient(to right, #ff9966 0%, #ff5e62 100%);
  background-position: center;
}
.pillarPage footer .copy-right {
  background-image: linear-gradient(to right, #f9905c 0%, #f56266 100%);
  background-position: center;
}
.pillarPage .pillarPage-main .left {
  width: calc(100% - 420px);
  height: 100%;
  margin-right: 20px;
  float: left;
  position: relative;
}
@media (max-width: 767px) {
  .pillarPage .pillarPage-main .left {
    width: 100%;
    float: none;
  }
}
.pillarPage .pillarPage-main .left div:nth-child(1) h2 {
  margin-top: 0;
}
.pillarPage .pillarPage-main .left h2 {
  font-size: 30px;
  line-height: 36px;
  margin-bottom: 10px;
  color: #383838;
  margin-top: 30px;
}
.pillarPage .pillarPage-main .left hr {
  margin: 30px 0;
}
.pillarPage .pillarPage-main .left p {
  margin-bottom: 15px;
}
.pillarPage .pillarPage-main .left p:last-child {
  margin-bottom: 0;
}
.pillarPage .pillarPage-main .left .box {
  padding: 10px;
  display: flex;
  -webkit-display: flex;
  align-items: center;
  justify-content: center;
  color: #fff;
  margin: 40px 0;
}
.pillarPage .pillarPage-main .left .box .img {
  height: 150px;
  width: 150px;
  background: #fff;
  padding: 10px;
  text-align: center;
  margin-right: 20px;
  display: flex;
  -webkit-display: flex;
  align-items: center;
  justify-content: center;
  overflow: hidden;
}
@media (min-width: 480px) and (max-width: 767px) {
  .pillarPage .pillarPage-main .left .box .img {
    width: 120px;
    height: 120px;
  }
}
@media (max-width: 479px) {
  .pillarPage .pillarPage-main .left .box .img {
    width: 100px;
    height: 100px;
  }
}
.pillarPage .pillarPage-main .left .box .content {
  width: calc(100% - 170px);
}
.pillarPage .pillarPage-main .left .box .content h4 {
  margin-bottom: 8px;
}
@media (min-width: 480px) and (max-width: 767px) {
  .pillarPage .pillarPage-main .left .box .content {
    width: calc(100% - 140px);
  }
}
@media (max-width: 479px) {
  .pillarPage .pillarPage-main .left .box .content {
    width: calc(100% - 120px);
  }
}
.pillarPage .pillarPage-main .left .box .btn {
  margin-bottom: 0;
}
.pillarPage .pillarPage-main .left ul.list-style1 li:before {
  background-image: linear-gradient(to right, #ff9966 0%, #ff5e62 100%);
  background-position: center;
}
.pillarPage .pillarPage-main .left ul.list-style1 li:last-child {
  margin-bottom: 15px;
}
.pillarPage .pillarPage-main .left .social-share {
  margin-top: 40px;
  font-size: 20px;
}
.pillarPage .pillarPage-main .left .social-share .social-icons {
  display: inline-block;
  vertical-align: middle;
  margin-left: 20px;
}
.pillarPage .pillarPage-main .left .social-share .social-icons span {
  display: inline-block;
  vertical-align: middle;
}
.pillarPage .pillarPage-main .left .social-share .social-icons span a {
  width: 70%;
  margin-right: 20px;
  display: inline-block;
  vertical-align: middle;
}
.pillarPage .pillarPage-main .left .social-share .social-icons span a img {
  width: 75%;
}
@media (max-width: 479px) {
  .pillarPage .pillarPage-main .left .social-share .social-icons span a img {
    widh: 70%;
  }
}
.pillarPage .pillarPage-main .right {
  float: right;
  width: 360px;
  margin-left: 40px;
}
.pillarPage .pillarPage-main .right h3 {
  margin-bottom: 20px;
  color: #383838;
}
.pillarPage .pillarPage-main .right .content-table, .pillarPage .pillarPage-main .right .download-guide {
  padding: 20px;
  -webkit-box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
  box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
}
.pillarPage .pillarPage-main .right .content-table ol {
  list-style-position: outside;
  padding-left: 20px;
}
.pillarPage .pillarPage-main .right .content-table ol li {
  padding-bottom: 10px;
}
.pillarPage .pillarPage-main .right .content-table ol li a:hover {
  color: #f5333f;
}
.pillarPage .pillarPage-main .right .download-guide {
  margin-top: 30px;
}
.pillarPage .pillarPage-main .right .download-guide .download-guide-in {
  max-width: 320px;
}
.pillarPage .pillarPage-main .right .download-guide .download-guide-in label {
  position: relative;
}
.pillarPage .pillarPage-main .right .download-guide .download-guide-in label input, .pillarPage .pillarPage-main .right .download-guide .download-guide-in label textarea {
  width: 100%;
  border: 0;
  border-bottom: 1px solid #7d7d7d;
  padding: 3px 0;
  background: 0 0;
  margin-bottom: 30px;
}
.pillarPage .pillarPage-main .right .download-guide .download-guide-in .btn {
  width: 100%;
  border: 1px solid transparent;
  color: #fff;
  font-size: 18px;
  margin-bottom: 0;
}
@media (max-width: 767px) {
  .pillarPage .pillarPage-main .right {
    width: 100%;
    float: none;
    margin-left: 0;
    margin-top: 40px;
  }
}

/*************************** notfound *****************************/
.notfound header .overlay {
  background-image: linear-gradient(to right, #443164 0%, #24173a 100%);
  background-position: center;
}
.notfound header .overlay .overlay-content .mega-menu .megamenu-item.active h5 a {
  color: #805eb9;
  font-weight: bold;
}
.notfound header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-tabH-in a:hover p, .notfound header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-tabH-in a.active p {
  color: #805eb9;
}
.notfound header .overlay .overlay-content .mega-menu .megamenu-item.active .megamenu-sub .megamenu-sub-menu li.active a {
  color: #805eb9;
}
.notfound header .overlay .overlay-content .mega-menu .megamenu-item:hover .megamenu-sub .megamenu-sub-menu li.active a, .notfound header .overlay .overlay-content .mega-menu .megamenu-item:hover .megamenu-sub .megamenu-sub-menu li:hover a {
  color: #805eb9;
}
.notfound footer .footer-top {
  background-image: linear-gradient(to right, #584082 0%, #24173a 100%);
  background-position: center;
}
.notfound footer .copy-right {
  background-image: linear-gradient(to right, #443164 0%, #24173a 100%);
  background-position: center;
}

/******************************* testimonial **************************************/
.testimonial {
  /* nav.nav-split a.prev:hover svg.icon {
      -webkit-transform: translateX(-100%);
      transform: translateX(-100%);
  } */
  /* nav.nav-split a.next:hover svg.icon {
      -webkit-transform: translateX(100%);
      transform: translateX(100%);
  } */
}
.testimonial .slider1 {
  width: 100%;
  height: 400px;
  position: relative;
  display: block;
  overflow: hidden;
}
.testimonial .slider1 .slide {
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  z-index: 0;
  content: "";
  display: none !important;
}
.testimonial .slider1 .slide.active {
  z-index: 3;
  display: block !important;
}
.testimonial .slider1 .slide .testi-in {
  z-index: 3;
  display: block;
}
.testimonial .slider1 .testi-in {
  width: 100%;
  z-index: 50;
  position: absolute;
  top: 30px;
  left: 0;
  padding: 0 40px;
}
@media (max-width: 767px) {
  .testimonial .slider1 .testi-in {
    top: 10px;
  }
}
@media (max-width: 767px) {
  .testimonial .slider1 .testi-in {
    padding: 0 12px;
  }
}
.testimonial nav.nav-split .icon-wrap {
  position: relative;
  display: block;
}
.testimonial nav.nav-split a {
  position: absolute;
  top: 105px;
}
@media (max-width: 767px) {
  .testimonial nav.nav-split a {
    top: 55px;
  }
}
.testimonial nav.nav-split a.prev {
  left: 0;
}
.testimonial nav.nav-split a.next {
  right: 0;
}
.testimonial nav.pagination {
  position: absolute;
  bottom: 0;
  text-align: center;
  width: 100%;
  z-index: 10;
}
@media (max-width: 767px) {
  .testimonial nav.pagination {
    bottom: -10px;
  }
}
.testimonial nav.pagination span {
  width: 12px;
  height: 12px;
  display: inline-block;
  background-color: transparent;
  box-shadow: inset 0 0 0 8px #e5e5e5;
  -webkit-transition: box-shadow 0.3s ease;
  transition: box-shadow 0.3s ease;
  -moz-border-radius: 50%;
  -webkit-border-radius: 50%;
  border-radius: 50%;
  margin: 5px;
  cursor: pointer;
}
.testimonial nav.pagination span.current {
  box-shadow: inset 0 0 0 8px #c1c1c1;
}
.testimonial nav.pagination span:hover {
  box-shadow: inset 0 0 0 8px #c1c1c1;
}
.testimonial .testi-in {
  z-index: 0;
  display: none;
}
.testimonial .testi-in .testi-img {
  width: 180px;
  height: 180px;
  display: flex;
  justify-content: center;
  align-items: center;
}
@media (max-width: 767px) {
  .testimonial .testi-in .testi-img {
    width: 120px;
    height: 120px;
  }
}
.testimonial .testi-in .testi-img img {
  width: 100px;
}
@media (max-width: 767px) {
  .testimonial .testi-in .testi-img img {
    width: 50px;
  }
}
.testimonial .testi-in .sliderblock-cont {
  width: calc(100% - 210px);
  background: #fff;
  padding: 20px;
  position: absolute;
  left: 170px;
  top: 60px;
  display: inline-block;
  -webkit-box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
  box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
}
@media (max-width: 767px) {
  .testimonial .testi-in .sliderblock-cont {
    left: 40px;
    top: 100px;
    width: calc(100% - 62px);
  }
}
.testimonial .testi-in .sliderblock-cont .quotes {
  width: 80px;
  position: absolute;
  top: 5px;
  left: 5px;
}
@media (max-width: 767px) {
  .testimonial .testi-in .sliderblock-cont .quotes {
    width: 28px;
  }
}
.testimonial .testi-in .sliderblock-cont p {
  padding: 65px 75px 20px;
  font-size: 16px;
  font-style: italic;
  font-family: "georgia", sans-serif;
}
@media (min-width: 768px) and (max-width: 1024px) {
  .testimonial .testi-in .sliderblock-cont p {
    padding: 55px 55px 20px;
  }
}
@media (max-width: 767px) {
  .testimonial .testi-in .sliderblock-cont p {
    padding: 10px 0px 15px;
    font-size: 15px;
  }
}
.testimonial .testi-in .sliderblock-cont h4 {
  text-align: right;
  font-size: 20px;
  font-weight: normal;
}
@media (max-width: 767px) {
  .testimonial .testi-in .sliderblock-cont h4 {
    font-size: 16px;
  }
}
.testimonial .testi-in .sliderblock-cont h4 span {
  font-weight: bold;
}

/******************************* use-cases **************************************/
.use-cases .title {
  position: relative;
}
.use-cases .title .tagline {
  position: absolute;
  left: 0;
  top: 40px;
}

#tab-slider {
  position: relative;
}
@media (max-width: 1024px) {
  #tab-slider {
    padding: 30px 10px 0px;
  }
}
@media (max-width: 479px) {
  #tab-slider {
    padding: 50px 6px 0px;
  }
}
#tab-slider .tab-slider-in {
  white-space: nowrap;
  overflow: hidden;
  margin: 0 -10px;
}
@media (max-width: 767px) {
  #tab-slider .tab-slider-in {
    margin: 0;
  }
}
#tab-slider .tab-slider-in #slider-content .item {
  display: inline-block;
  width: 33.3333%;
  opacity: 1;
  position: relative;
  vertical-align: top;
  overflow: hidden;
  height: 100%;
  white-space: normal;
  padding: 0 10px;
}
@media (max-width: 1024px) {
  #tab-slider .tab-slider-in #slider-content .item {
    width: 50%;
  }
}
@media (max-width: 767px) {
  #tab-slider .tab-slider-in #slider-content .item {
    width: 100%;
    padding: 0;
  }
}
#tab-slider .tab-slider-in #slider-content .item .item-in {
  background: #fff;
  margin: 2px 0 2px 0;
  border-radius: 5px;
  -webkit-box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
  box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
}
#tab-slider .tab-slider-in #slider-content .item .item-in .item-cont {
  padding: 20px;
}
@media (min-width: 1025px) and (max-width: 1280px) {
  #tab-slider .tab-slider-in #slider-content .item .item-in .item-cont {
    height: 250px;
  }
}
@media (min-width: 768px) and (max-width: 1024px) {
  #tab-slider .tab-slider-in #slider-content .item .item-in .item-cont {
    height: 230px;
  }
}
#tab-slider .tab-slider-in #slider-content .item .imgTitle {
  position: relative;
  display: flex;
  -webkit-display: flex;
  align-items: center;
  justify-content: center;
  height: 180px;
  overflow: hidden;
  border-top-left-radius: 5px;
  border-top-right-radius: 5px;
}
#tab-slider .tab-slider-in #slider-content .item h3 {
  font-size: 20px;
  margin-bottom: 10px;
}
#tab-slider .tab-slider-in #slider-content .item p {
  font-size: 16px;
}
#tab-slider .tab-slider-in #slider-content .item a {
  float: right;
  margin: 0 20px 0 0;
  font-size: 16px;
  font-style: italic;
  color: rgba(173, 0, 0, 0.82);
  font-weight: bold;
  letter-spacing: 1px;
  transition: linear 0.1s;
}
#tab-slider .tab-slider-in #slider-content .item a:hover {
  text-shadow: 0 0 1px grey;
}
#tab-slider .MS-controls button {
  position: absolute;
  border: none;
  background-color: transparent;
  outline: 0;
  font-size: 50px;
  top: 50%;
  transform: translateY(-50%);
  color: #fff;
  transition: 0.15s linear;
  width: 30px;
  height: 30px;
  font-size: 20px;
  line-height: 20px;
  border-radius: 50%;
  cursor: pointer;
  -webkit-box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
  box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
}
#tab-slider .MS-controls button:hover {
  color: rgba(0, 0, 0, 0.8);
}
#tab-slider .MS-controls button img {
  width: 7px;
}
@media (max-width: 1024px) {
  #tab-slider .MS-controls button {
    font-size: 30px;
  }
}
@media (max-width: 767px) {
  #tab-slider .MS-controls button {
    font-size: 25px;
    width: 23px;
    height: 23px;
  }
}
#tab-slider .MS-controls .MS-left {
  left: -15px;
  padding-right: 2px;
}
@media (max-width: 1024px) {
  #tab-slider .MS-controls .MS-left {
    left: -5px;
  }
}
#tab-slider .MS-controls .MS-right {
  right: -15px;
  padding-left: 2px;
}
@media (max-width: 1024px) {
  #tab-slider .MS-controls .MS-right {
    right: -5px;
  }
}

/******************************* case-study **************************************/
.case-study {
  /* nav.nav-split a.prev:hover svg.icon {
      -webkit-transform: translateX(-100%);
      transform: translateX(-100%);
  } */
  /* nav.nav-split a.next:hover svg.icon {
      -webkit-transform: translateX(100%);
      transform: translateX(100%);
  } */
}
.case-study .svg-wrap {
  height: 0;
  width: 0;
  position: absolute;
  overflow: hidden;
}
.case-study .slider1 {
  width: 100%;
  height: 400px;
  position: relative;
  display: flex;
  -webkit-display: flex;
  align-items: center;
  justify-content: center;
}
@media (max-width: 1024px) {
  .case-study .slider1 {
    width: calc(100% - 20px);
    margin: 0 auto;
  }
}
@media (max-width: 767px) {
  .case-study .slider1 {
    height: auto !important;
  }
}
.case-study .slider1 .slide {
  width: 100%;
  z-index: 0;
  content: "";
  display: none !important;
  height: auto !important;
}
.case-study .slider1 .slide.active {
  z-index: 3;
  display: block !important;
}
.case-study .slider1 .slide .case-study-in {
  z-index: 3;
  width: 100%;
  z-index: 50;
  display: flex;
}
@media (max-width: 767px) {
  .case-study .slider1 .slide .case-study-in {
    display: block;
  }
}
.case-study nav.nav-split .icon-wrap {
  position: relative;
  display: block;
  padding: 4px 0px;
}
@media (max-width: 767px) {
  .case-study nav.nav-split .icon-wrap {
    padding: 1px 0;
  }
}
.case-study nav.nav-split svg.icon {
  -webkit-transition: -webkit-transform 0.3s 0.3s;
  transition: transform 0.3s 0.3s;
  fill: #fff;
  width: 16px;
}
@media (max-width: 767px) {
  .case-study nav.nav-split svg.icon {
    width: 12px;
  }
}
.case-study nav.nav-split a:hover {
  -webkit-transform: scale(1.05);
  transform: scale(1.05);
}
.case-study nav.nav-split a svg {
  display: block;
  margin: 0 auto;
  padding: 0;
  transform: rotate(90deg);
  -webkit-transform: rotate(90deg);
}
.case-study nav.nav-split a svg:hover {
  transform: rotate(-270deg);
  -webkit-transform: rotate(-270deg);
}
.case-study nav.nav-split a.prev {
  right: -15px;
  bottom: 170px;
}
@media (max-width: 767px) {
  .case-study nav.nav-split a.prev {
    bottom: 110px;
  }
}
.case-study nav.nav-split a.prev .icon-wrap {
  padding-bottom: 2px;
}
.case-study nav.nav-split a.next {
  right: -15px;
  bottom: 120px;
}
@media (max-width: 767px) {
  .case-study nav.nav-split a.next {
    bottom: 50px;
  }
}
.case-study nav.nav-split a.next .icon-wrap {
  padding-top: 5px;
}
.case-study nav.nav-split:hover svg.icon {
  -webkit-transition-delay: 0s;
  transition-delay: 0s;
}
.case-study nav.pagination {
  position: absolute;
  top: 50%;
  transform: translateY(-50%);
  z-index: 10;
  left: 0;
}
@media (max-width: 767px) {
  .case-study nav.pagination {
    bottom: -10px;
  }
}
.case-study nav.pagination span {
  width: 12px;
  height: 12px;
  display: block;
  background-color: transparent;
  box-shadow: inset 0 0 0 8px #e5e5e5;
  -webkit-transition: box-shadow 0.3s ease;
  transition: box-shadow 0.3s ease;
  -moz-border-radius: 50%;
  -webkit-border-radius: 50%;
  border-radius: 50%;
  margin: 10px;
  cursor: pointer;
}
.case-study .case-study-in {
  z-index: 0;
  display: none;
}
.case-study .case-study-in .img {
  text-align: center;
  width: calc(100% - 320px);
  -webkit-box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
  box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
  display: flex;
  -webkit-display: flex;
  align-items: center;
  justify-content: center;
  max-height: 400px;
  overflow: hidden;
}
@media (max-width: 767px) {
  .case-study .case-study-in .img {
    width: 100%;
    min-height: auto;
  }
}
.case-study .case-study-in .sliderblock-cont {
  width: 300px;
  min-height: 400px;
  padding: 30px;
  margin-left: 20px;
  -webkit-box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
  box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
  position: relative;
}
@media (max-width: 1024px) {
  .case-study .case-study-in .sliderblock-cont {
    min-height: auto;
  }
}
@media (max-width: 767px) {
  .case-study .case-study-in .sliderblock-cont {
    padding: 20px 20px 90px;
    min-height: auto;
    margin-left: 0;
    width: 100%;
  }
}
.case-study .case-study-in .sliderblock-cont h3 {
  font-size: 20px;
  margin-bottom: 10px;
}
.case-study .case-study-in .sliderblock-cont p {
  padding: 0px;
}
.case-study .case-study-in .sliderblock-cont a.btn {
  bottom: 0;
  position: absolute;
  right: 30px;
}
@media (max-width: 767px) {
  .case-study .case-study-in .sliderblock-cont a.btn {
    right: 20px;
  }
}

/** download app **/
.download-app .mobile {
  display: inline-block;
  vertical-align: middle;
  width: 50%;
}
.download-app .download-links {
  display: inline-block;
  vertical-align: middle;
  width: 49%;
}
@media (max-width: 479px) {
  .download-app .download-links {
    width: 130px;
  }
}
.download-app .download-links a {
  display: block;
  width: 140px;
  margin: 0 auto 40px;
}
.download-app .download-links a img {
  -webkit-transition: transform 0.2s ease-in-out;
  transition: transform 0.2s ease-in-out;
}
.download-app .download-links a img:hover {
  -webkit-transform: scale(1.05);
  -moz-transform: scale(1.05);
  transform: scale(1.05);
}
@media (max-width: 479px) {
  .download-app .download-links a {
    min-width: 100px;
    width: 100px;
    margin: 0 auto 20px;
  }
}

/** brands powered by wowsome **/
.brands .slider-wrap {
  position: relative;
  margin: 0px auto;
  width: 600px;
}
@media (min-width: 1025px) and (max-width: 1280px) {
  .brands .slider-wrap {
    width: 480px;
  }
}
@media (min-width: 480px) and (max-width: 767px) {
  .brands .slider-wrap {
    width: 450px;
  }
}
@media (max-width: 479px) {
  .brands .slider-wrap {
    width: 300px;
  }
}
.brands .slider {
  position: relative;
  width: 510px;
  margin: auto;
}
@media (min-width: 1025px) and (max-width: 1280px) {
  .brands .slider {
    width: 420px;
  }
}
@media (min-width: 480px) and (max-width: 767px) {
  .brands .slider {
    width: 390px;
  }
}
@media (max-width: 479px) {
  .brands .slider {
    width: 270px;
  }
}
.brands ul {
  margin: 0 -10px;
}
.brands ul li {
  text-align: center;
  margin: 0 auto;
  -moz-transition: -moz-transform 0.15s linear;
  -o-transition: -o-transform 0.15s linear;
  -webkit-transition: -webkit-transform 0.15s linear;
}
.brands ul li span {
  display: block;
  width: 170px;
  height: auto;
  overflow: hidden;
  background: #fff;
  margin: 20px 0px;
  -moz-transition: -moz-transform 0.15s linear;
  -o-transition: -o-transform 0.15s linear;
  -webkit-transition: -webkit-transform 0.15s linear;
}
.brands ul li span:hover, .brands ul li span:focus {
  -webkit-transform: scale(1.15);
  -moz-transform: scale(1.15);
  -o-transform: scale(1.15);
  position: relative;
  z-index: 5;
}
.brands ul li span img {
  width: 100%;
  height: auto;
}
@media (min-width: 1025px) and (max-width: 1280px) {
  .brands ul li span {
    width: 130px;
    height: 90px;
    margin: 10px auto;
  }
}
@media (min-width: 480px) and (max-width: 767px) {
  .brands ul li span {
    width: 120px;
    height: 85px;
    margin: 10px auto;
  }
}
@media (max-width: 479px) {
  .brands ul li span {
    width: 85px;
    height: 80px;
    margin: 5px auto;
  }
}
.brands .slider-arrow {
  position: absolute;
  top: 50%;
  transform: translateY(-50%);
  background: none;
  box-shadow: none;
  height: 50px;
}
.brands .slider-arrow svg.icon {
  fill: #b2b2b2;
  width: 30px;
  height: 32px;
}
.brands .slider-arrow img {
  height: 50px;
}
.brands .sa-left {
  left: 10px;
}
@media (max-width: 479px) {
  .brands .sa-left {
    left: 0px;
  }
}
.brands .sa-right {
  right: 10px;
}
@media (max-width: 479px) {
  .brands .sa-right {
    right: 0px;
  }
}

/************** recent blog post ***********/
.post-grid .section-in {
  margin: 0;
}
.post-grid .post-left, .post-grid .post-right-top, .post-grid .post-right-btm {
  background: #eeeeee;
  position: relative;
}
.post-grid .post-left .post-img, .post-grid .post-right-top .post-img, .post-grid .post-right-btm .post-img {
  overflow: hidden;
  height: 100%;
}
.post-grid .post-left .post-img img, .post-grid .post-right-top .post-img img, .post-grid .post-right-btm .post-img img {
  width: 100%;
  height: 100%;
  object-fit: cover;
}
.post-grid .post-left:after, .post-grid .post-right-top:after, .post-grid .post-right-btm:after {
  content: " ";
  display: block;
  position: absolute;
  left: 0;
  top: 0;
  width: 100%;
  height: 100%;
  z-index: 1;
  opacity: 0.3;
  background-repeat: no-repeat;
  background-position: 50%;
}
@media (max-width: 767px) {
  .post-grid .post-left, .post-grid .post-right-top, .post-grid .post-right-btm {
    height: 180px !important;
    float: none;
  }
}
.post-grid .post-left .post-cont, .post-grid .post-right-top .post-cont, .post-grid .post-right-btm .post-cont {
  position: absolute;
  left: 0;
  right: 0;
  top: 0;
  z-index: 10;
  color: #fff;
  height: 100%;
  background: rgba(0, 0, 0, 0.7);
}
.post-grid .post-left .post-cont .post-cont-in, .post-grid .post-right-top .post-cont .post-cont-in, .post-grid .post-right-btm .post-cont .post-cont-in {
  position: absolute;
  bottom: 20px;
  left: 20px;
  right: 20px;
}
@media (max-width: 767px) {
  .post-grid .post-left .post-cont .post-cont-in, .post-grid .post-right-top .post-cont .post-cont-in, .post-grid .post-right-btm .post-cont .post-cont-in {
    left: 15px;
    right: 15px;
  }
}
.post-grid .post-left .post-cont h4, .post-grid .post-right-top .post-cont h4, .post-grid .post-right-btm .post-cont h4 {
  margin-bottom: 8px;
  overflow: hidden;
  text-overflow: ellipsis;
  max-height: 51px;
}
.post-grid .post-left .post-cont h4 a, .post-grid .post-right-top .post-cont h4 a, .post-grid .post-right-btm .post-cont h4 a {
  color: #fff;
}
.post-grid .post-left .post-cont .post-date, .post-grid .post-right-top .post-cont .post-date, .post-grid .post-right-btm .post-cont .post-date {
  margin-bottom: 15px;
  color: #fff;
}
.post-grid .post-left .post-cont .read-more, .post-grid .post-right-top .post-cont .read-more, .post-grid .post-right-btm .post-cont .read-more {
  margin-bottom: 0;
  text-decoration: underline;
  color: #fff;
}
.post-grid .post-left .post-cont .read-more:hover, .post-grid .post-right-top .post-cont .read-more:hover, .post-grid .post-right-btm .post-cont .read-more:hover {
  text-decoration: none;
}
.post-grid .post-left, .post-grid .post-right {
  width: calc(50% - 20px);
  float: left;
  margin: 0 10px;
}
@media (min-width: 768px) and (max-width: 1024px) {
  .post-grid .post-left, .post-grid .post-right {
    height: 350px !important;
  }
}
@media (max-width: 767px) {
  .post-grid .post-left, .post-grid .post-right {
    width: 100%;
    margin: 0;
  }
}
@media (max-width: 767px) {
  .post-grid .post-right {
    margin-top: 20px;
  }
}
.post-grid .post-right-top, .post-grid .post-right-btm {
  height: calc(100% / 2 - 10px);
  display: block;
  width: 100%;
  float: left;
}
.post-grid .post-right-top {
  margin-bottom: 10px;
}
.post-grid .post-right-btm {
  margin-top: 10px;
}

/************** our work section *******************/
.our-work .ow-videos-in {
  width: 480px;
  margin: 0 auto;
  -webkit-animation-name: zoomIn;
  animation-name: zoomIn;
}
@media (max-width: 479px) {
  .our-work .ow-videos-in {
    width: 290px;
  }
}
.our-work .ow-videos-in a {
  width: 230px;
  height: 170px;
  display: inline-block;
  position: relative;
}
@media (max-width: 479px) {
  .our-work .ow-videos-in a {
    width: 140px;
    height: 120px;
  }
}
.our-work .ow-videos-in a:hover video {
  -webkit-transform: scale(1.05);
  -moz-transform: scale(1.05);
  transform: scale(1.05);
}
.our-work .ow-videos-in a video {
  -webkit-box-shadow: 0 10px 12px -4px rgba(0, 0, 0, 0.3);
  box-shadow: 0 10px 12px -4px rgba(0, 0, 0, 0.3);
  -webkit-transition: transform 0.2s ease-in-out;
  transition: transform 0.2s ease-in-out;
  object-fit: initial;
  border-radius: 5px;
}
.our-work .ow-videos-in a:after {
  content: " ";
  display: block;
  position: absolute;
  left: 0;
  top: 0;
  width: 100%;
  height: 100%;
  z-index: 1;
  opacity: 1;
  background-image: url(https://cdn2.hubspot.net/hubfs/1635524/assets/website/images/play.png);
  background-repeat: no-repeat;
  background-position: 50%;
  background-size: 35px;
}
@media (max-width: 479px) {
  .our-work .ow-videos-in a:after {
    background-size: 35px;
  }
}
.our-work .ow-videos-in a:nth-child(1) {
  margin: 0 5px 5px 0;
}
.our-work .ow-videos-in a:nth-child(1) video {
  width: 230px;
  height: 170px;
}
@media (max-width: 479px) {
  .our-work .ow-videos-in a:nth-child(1) video {
    width: 140px;
    height: 120px;
  }
}
@media (max-width: 479px) {
  .our-work .ow-videos-in a:nth-child(1) {
    margin: 0 0 5px 0;
  }
}
.our-work .ow-videos-in a:nth-child(1):after {
  background-position: 50%;
}
.our-work .ow-videos-in a:nth-child(2) {
  margin: 0 0 5px 5px;
  vertical-align: top;
  text-align: left;
}
.our-work .ow-videos-in a:nth-child(2) video {
  width: 160px;
  height: 110px;
  margin-top: 60px;
}
@media (max-width: 479px) {
  .our-work .ow-videos-in a:nth-child(2) video {
    width: 120px;
    height: 90px;
    margin-top: 30px;
  }
}
.our-work .ow-videos-in a:nth-child(2):after {
  background-position: 66px 98px;
}
@media (max-width: 479px) {
  .our-work .ow-videos-in a:nth-child(2):after {
    background-position: 46px 54px;
  }
}
.our-work .ow-videos-in a:nth-child(3) {
  margin: 5px 5px 0 0;
  vertical-align: top;
  text-align: right;
}
.our-work .ow-videos-in a:nth-child(3) video {
  width: 160px;
  height: 110px;
}
@media (max-width: 479px) {
  .our-work .ow-videos-in a:nth-child(3) video {
    width: 120px;
    height: 90px;
  }
}
.our-work .ow-videos-in a:nth-child(3):after {
  background-position: 136px 38px;
}
@media (max-width: 479px) {
  .our-work .ow-videos-in a:nth-child(3):after {
    background-position: 66px 24px;
  }
}
@media (max-width: 479px) {
  .our-work .ow-videos-in a:nth-child(3) {
    margin: 3px 0 0 0;
  }
}
.our-work .ow-videos-in a:nth-child(4) {
  margin: 5px 0 0 5px;
  vertical-align: top;
  text-align: right;
}
.our-work .ow-videos-in a:nth-child(4) video {
  width: 230px;
  height: 170px;
}
@media (max-width: 479px) {
  .our-work .ow-videos-in a:nth-child(4) video {
    width: 140px;
    height: 120px;
  }
}
.our-work .ow-videos-in a:nth-child(4):after {
  background-position: 50%;
}
@media (max-width: 479px) {
  .our-work .ow-videos-in a:nth-child(4) {
    margin: 3px 0 0 5px;
  }
}
.our-work .campaigns-main-list {
  margin-left: -10px;
  margin-right: -10px;
  width: calc(100% + 20px);
}
.our-work .campaigns-main-list .camp-list-block {
  width: 50%;
  padding: 0 10px;
  margin: 0 0 20px;
}
@media (min-width: 768px) and (max-width: 1024px) {
  .our-work .campaigns-main-list .camp-list-block {
    width: 25%;
  }
}
@media (max-width: 767px) {
  .our-work .campaigns-main-list .camp-list-block {
    width: 50%;
  }
}
@media (max-width: 479px) {
  .our-work .campaigns-main-list .camp-list-block .camp-list-block-in {
    height: 142px;
  }
}
@media (min-width: 1025px) {
  .our-work .left50 {
    padding-right: 30px;
  }
}

/************** our work gallery ***********/
.ourwork-gallery h2 {
  font-size: 34px;
  line-height: 34px;
  color: #000;
}
@media (max-width: 767px) {
  .ourwork-gallery h2 {
    font-size: 26px;
  }
}
.ourwork-gallery .videos-in {
  width: 100%;
}
.ourwork-gallery .videos-in .video-block {
  margin: 0 -8px;
}
@media (max-width: 767px) {
  .ourwork-gallery .videos-in .video-block {
    margin: 0;
  }
}
.ourwork-gallery .videos-in .video-block .custom {
  height: 190px;
  width: 100%;
  overflow: hidden;
  float: left;
  color: #fff;
  box-shadow: 0 0 10px rgba(0, 0, 0, 0.2);
  text-decoration: none;
  position: relative;
}
@media (min-width: 768px) and (max-width: 1024px) {
  .ourwork-gallery .videos-in .video-block .custom {
    height: 165px;
  }
}
@media (max-width: 767px) {
  .ourwork-gallery .videos-in .video-block .custom {
    height: auto;
  }
}
.ourwork-gallery .videos-in .video-block .custom video {
  width: 100%;
  height: 100%;
  object-fit: fill;
  float: left;
}
.ourwork-gallery .videos-in .video-block .custom:after {
  content: " ";
  display: block;
  position: absolute;
  left: 0;
  top: 0;
  width: 100%;
  height: 100%;
  z-index: 1;
  opacity: 1;
  background-image: url(https://cdn2.hubspot.net/hubfs/1635524/assets/website/images/play.png);
  background-repeat: no-repeat;
  background-position: 50%;
  background-size: 69px;
}
@media (max-width: 479px) {
  .ourwork-gallery .videos-in .video-block .custom:after {
    background-size: 50px;
  }
}
.ourwork-gallery .videos-in .video-block .large {
  width: 70%;
  height: 412px;
  padding: 8px;
}
@media (min-width: 768px) and (max-width: 1024px) {
  .ourwork-gallery .videos-in .video-block .large {
    height: 362px;
  }
}
@media (max-width: 767px) {
  .ourwork-gallery .videos-in .video-block .large {
    width: 100%;
    height: auto;
    padding: 0;
    margin: 0 0 40px;
  }
}
@media (max-width: 479px) {
  .ourwork-gallery .videos-in .video-block .large {
    margin: 0 0 25px;
  }
}
.ourwork-gallery .videos-in .video-block .large .custom {
  width: 100%;
  height: 100%;
}
.ourwork-gallery .videos-in .video-block .small {
  width: 30%;
  padding: 8px;
}
@media (max-width: 767px) {
  .ourwork-gallery .videos-in .video-block .small {
    width: 100%;
    margin: 0 0 40px;
    padding: 0;
  }
}
@media (max-width: 479px) {
  .ourwork-gallery .videos-in .video-block .small {
    margin: 0 0 25px;
  }
}
.ourwork-gallery .videos-in .video-block:nth-child(odd) .large, .ourwork-gallery .videos-in .video-block:nth-child(odd) .small {
  float: left;
}
.ourwork-gallery .videos-in .video-block:nth-child(even) .large, .ourwork-gallery .videos-in .video-block:nth-child(even) .small {
  float: right;
}
.ourwork-gallery .videos-in .video-block span {
  position: relative;
}
.ourwork-gallery .videos-in .video-block span.selected {
  width: 100%;
  height: auto;
}
.ourwork-gallery .videos-in .video-block span.selected .custom {
  height: 100%;
}
.ourwork-gallery .videos-in .video-block span.selected .custom:after {
  content: none;
}
.ourwork-gallery .videos-in .video-block span.selected .bottom-links {
  top: 8px;
  background-image: none;
  visibility: visible;
  background: linear-gradient(rgba(0, 0, 0, 0.6), transparent);
  height: 46px;
}
.ourwork-gallery .videos-in .video-block span.selected .bottom-links .cta {
  padding-right: 50px;
}
@media (max-width: 767px) {
  .ourwork-gallery .videos-in .video-block span.selected .bottom-links {
    top: 0;
  }
}
.ourwork-gallery .videos-in .video-block span.selected .right-buttons {
  padding: 10px;
}
.ourwork-gallery .videos-in .video-block span.selected .right-buttons .close-button, .ourwork-gallery .videos-in .video-block span.selected .right-buttons .info-button, .ourwork-gallery .videos-in .video-block span.selected .right-buttons .share-button {
  display: block !important;
  margin-bottom: 10px;
}
.ourwork-gallery .videos-in .video-block span.selected .right-buttons .info-button {
  display: none !important;
}
.ourwork-gallery .videos-in .video-block span.sibling {
  width: 50%;
  height: 366px;
}
.ourwork-gallery .videos-in .video-block span.sibling .custom {
  height: 350px;
}
@media (max-width: 767px) {
  .ourwork-gallery .videos-in .video-block span.sibling .custom {
    height: auto;
  }
}
@media (max-width: 767px) {
  .ourwork-gallery .videos-in .video-block span.sibling {
    height: auto;
    width: 100%;
  }
}
.ourwork-gallery .videos-in .video-block span:hover .bottom-links {
  visibility: visible;
}
.ourwork-gallery .videos-in .video-block span:hover .right-buttons .info-button {
  display: block;
}
.ourwork-gallery .videos-in .video-block span:hover .right-buttons .close-button, .ourwork-gallery .videos-in .video-block span:hover .right-buttons .share-button {
  display: none;
}
.ourwork-gallery .videos-in .video-block span:hover .custom:after {
  -webkit-transform: scale(1.05);
  -moz-transform: scale(1.05);
  transform: scale(1.05);
}
.ourwork-gallery .videos-in .video-block.flex {
  display: flex;
  flex-wrap: wrap;
  width: 100%;
}
.ourwork-gallery .videos-in .video-block.flex .selected {
  order: 1;
}
.ourwork-gallery .videos-in .video-block.flex .sibling {
  order: 2;
}
@media (max-width: 767px) {
  .ourwork-gallery .videos-in .video-block.flex {
    display: block;
  }
}
.ourwork-gallery .videos-in .video-block .right-buttons {
  position: absolute;
  top: 8px;
  right: 8px;
  z-index: 80;
  background: linear-gradient(rgba(0, 0, 0, 0.6), transparent);
}
@media (max-width: 767px) {
  .ourwork-gallery .videos-in .video-block .right-buttons {
    right: 0;
    top: 0;
  }
}
.ourwork-gallery .videos-in .video-block .right-buttons img {
  padding-top: 5px;
}
.ourwork-gallery .videos-in .video-block .right-buttons .share-button, .ourwork-gallery .videos-in .video-block .right-buttons .close-button, .ourwork-gallery .videos-in .video-block .right-buttons .info-button {
  width: 22px;
  height: 30px;
  display: none;
}
.ourwork-gallery .videos-in .video-block .right-buttons .info-button {
  position: relative;
  display: none !important;
}
.ourwork-gallery .videos-in .video-block .right-buttons .info-button .info-tooltip {
  visibility: hidden;
  position: absolute;
  right: 0;
  background: #fff;
  padding: 8px;
  width: 290px;
  border-radius: 5px;
  top: 100%;
}
.ourwork-gallery .videos-in .video-block .right-buttons .info-button .info-tooltip a {
  display: inline-block;
  width: auto !important;
  position: relative;
  padding-right: 8px;
  margin-right: 5px;
}
.ourwork-gallery .videos-in .video-block .right-buttons .info-button .info-tooltip a:after {
  content: "";
  background: #808285;
  width: 2px;
  height: 12px;
  position: absolute;
  right: 0;
  top: 50%;
  transform: translateY(-50%);
}
.ourwork-gallery .videos-in .video-block .right-buttons .info-button .info-tooltip a:last-child {
  padding-right: 0;
  margin-right: 0;
}
.ourwork-gallery .videos-in .video-block .right-buttons .info-button .info-tooltip a:last-child:after {
  content: none;
}
.ourwork-gallery .videos-in .video-block .right-buttons .info-button:hover img {
  cursor: pointer;
}
.ourwork-gallery .videos-in .video-block .right-buttons .info-button:hover .info-tooltip {
  visibility: visible;
}
.ourwork-gallery .videos-in .video-block .bottom-links {
  display: -webkit-flex;
  display: -ms-flexbox;
  display: flex;
  -webkit-flex-wrap: nowrap;
  -ms-flex-wrap: nowrap;
  flex-wrap: nowrap;
  -ms-flex-pack: end;
  justify-content: flex-end;
  left: 8px;
  right: 8px;
  bottom: 8px;
  z-index: 59;
  position: absolute;
  text-shadow: 0 0 2px rgba(0, 0, 0, 0.5);
  color: #fff;
  padding: 6px 10px;
  align-items: center;
  background-image: linear-gradient(to right, #74EBD5 0%, #9FACE6 100%);
  background-position: center;
  visibility: hidden;
}
@media (max-width: 767px) {
  .ourwork-gallery .videos-in .video-block .bottom-links {
    left: 0;
    right: 0;
    bottom: 0;
  }
}
.ourwork-gallery .videos-in .video-block .bottom-links a {
  color: #fff;
  font-size: 13px;
}
.ourwork-gallery .videos-in .video-block .bottom-links .title {
  overflow: hidden;
  flex: 1;
  display: flex;
}
.ourwork-gallery .videos-in .video-block .bottom-links .title .title-text {
  max-width: 100%;
  padding-left: 4px;
  min-height: 20px;
  line-height: 17px;
  overflow: hidden !important;
  text-overflow: ellipsis !important;
  -o-text-overflow: ellipsis;
  display: -webkit-box !important;
  -webkit-line-clamp: 2 !important;
  -webkit-box-orient: vertical;
  max-height: 32px;
  font-size: 13px;
}
.ourwork-gallery .videos-in .video-block .bottom-links .cta {
  white-space: nowrap;
  padding-left: 15px;
}
.ourwork-gallery .videos-in .video-block .bottom-links .cta img {
  vertical-align: middle;
  width: 25px;
  margin-left: 3px;
}

/************** interactive print gallery **************/
.intprint-gallery .main-title h1 {
  max-width: 100%;
  margin-bottom: 0;
}
.intprint-gallery ul.list-style1 li:before {
  background-image: linear-gradient(to right, #1D2B64 0%, #F8CDDA 100%);
  background-position: center;
}

.campaigns-main-list, .slider-ipgallery ul {
  margin-left: -20px;
  margin-right: -20px;
  float: left;
  width: calc(100% + 40px);
  margin-top: 20px;
}
@media (max-width: 1024px) {
  .campaigns-main-list, .slider-ipgallery ul {
    margin-left: -10px;
    margin-right: -10px;
    width: calc(100% + 20px);
  }
}
@media (max-width: 767px) {
  .campaigns-main-list, .slider-ipgallery ul {
    margin-top: 0;
  }
}
@media (max-width: 479px) {
  .campaigns-main-list, .slider-ipgallery ul {
    margin-left: -5px;
    margin-right: -5px;
    width: calc(100% + 10px);
  }
}
.campaigns-main-list .camp-list-block, .slider-ipgallery ul .camp-list-block {
  width: 25%;
  float: left;
  padding: 0 20px;
  position: relative;
  margin: 0 0 40px;
}
@media (min-width: 768px) and (max-width: 1024px) {
  .campaigns-main-list .camp-list-block, .slider-ipgallery ul .camp-list-block {
    padding: 0 10px;
    margin: 0 0 20px;
  }
}
@media (min-width: 480px) and (max-width: 767px) {
  .campaigns-main-list .camp-list-block, .slider-ipgallery ul .camp-list-block {
    width: 33.3333%;
    padding: 0 10px;
    margin: 0 0 20px;
  }
}
@media (max-width: 479px) {
  .campaigns-main-list .camp-list-block, .slider-ipgallery ul .camp-list-block {
    width: 50%;
    padding: 0 5px;
    margin: 0 0 10px;
  }
}
.campaigns-main-list .camp-list-block .camp-list-block-in, .slider-ipgallery ul .camp-list-block .camp-list-block-in {
  background: #fff;
  width: 100%;
  height: 252px;
  box-shadow: 0 0 10px -3px;
  position: relative;
  transition: transform 0.2s, -webkit-transform 0.2s;
  border-radius: 6px;
}
@media (min-width: 768px) and (max-width: 1024px) {
  .campaigns-main-list .camp-list-block .camp-list-block-in, .slider-ipgallery ul .camp-list-block .camp-list-block-in {
    height: 192px;
  }
}
@media (min-width: 480px) and (max-width: 767px) {
  .campaigns-main-list .camp-list-block .camp-list-block-in, .slider-ipgallery ul .camp-list-block .camp-list-block-in {
    height: 172px;
  }
}
@media (max-width: 479px) {
  .campaigns-main-list .camp-list-block .camp-list-block-in, .slider-ipgallery ul .camp-list-block .camp-list-block-in {
    height: 172px;
  }
}
.campaigns-main-list .camp-list-block .camp-list-block-in .campaigns-brand, .slider-ipgallery ul .camp-list-block .camp-list-block-in .campaigns-brand {
  position: absolute;
  left: 0;
  top: 0;
  background: linear-gradient(rgba(0, 0, 0, 0.8), transparent);
  width: 100%;
  padding: 6px 0 36px 6px;
  border-top-left-radius: 6px;
  border-top-right-radius: 6px;
}
.campaigns-main-list .camp-list-block .camp-list-block-in .campaigns-brand .campaigns-brand-icon, .slider-ipgallery ul .camp-list-block .camp-list-block-in .campaigns-brand .campaigns-brand-icon {
  float: left;
  background: 0 0;
  width: 40px;
  height: 40px;
  border-radius: 25px;
  -webkit-box-shadow: 0 10px 12px -4px rgba(0, 0, 0, 0.3);
  box-shadow: 0 10px 12px -4px rgba(0, 0, 0, 0.3);
}
@media (max-width: 767px) {
  .campaigns-main-list .camp-list-block .camp-list-block-in .campaigns-brand .campaigns-brand-icon, .slider-ipgallery ul .camp-list-block .camp-list-block-in .campaigns-brand .campaigns-brand-icon {
    width: 35px;
    height: 35px;
  }
}
.campaigns-main-list .camp-list-block .camp-list-block-in .campaigns-brand .campaigns-brand-icon img, .slider-ipgallery ul .camp-list-block .camp-list-block-in .campaigns-brand .campaigns-brand-icon img {
  width: 100%;
  height: 100%;
  border-radius: 50%;
  -o-object-fit: cover;
  object-fit: cover;
}
.campaigns-main-list .camp-list-block .camp-list-block-in .campaigns-brand .campaigns-name, .slider-ipgallery ul .camp-list-block .camp-list-block-in .campaigns-brand .campaigns-name {
  display: inline-block;
  overflow: hidden;
  text-overflow: ellipsis;
  height: 40px;
  width: calc(100% - 45px);
  margin-left: 5px;
  line-height: 1.4;
  padding-top: 3px;
  text-align: left;
}
@media (max-width: 767px) {
  .campaigns-main-list .camp-list-block .camp-list-block-in .campaigns-brand .campaigns-name, .slider-ipgallery ul .camp-list-block .camp-list-block-in .campaigns-brand .campaigns-name {
    height: 35px;
    width: calc(100% - 40px);
  }
}
.campaigns-main-list .camp-list-block .camp-list-block-in .campaigns-brand .campaigns-name span, .slider-ipgallery ul .camp-list-block .camp-list-block-in .campaigns-brand .campaigns-name span {
  color: #fff;
  display: block;
}
.campaigns-main-list .camp-list-block .camp-list-block-in .campaigns-brand .campaigns-name .brand-name, .slider-ipgallery ul .camp-list-block .camp-list-block-in .campaigns-brand .campaigns-name .brand-name {
  font-size: 14px;
  overflow: hidden;
  text-overflow: ellipsis;
  white-space: nowrap;
}
@media (min-width: 768px) and (max-width: 1024px) {
  .campaigns-main-list .camp-list-block .camp-list-block-in .campaigns-brand .campaigns-name .brand-name, .slider-ipgallery ul .camp-list-block .camp-list-block-in .campaigns-brand .campaigns-name .brand-name {
    font-size: 13px;
  }
}
@media (max-width: 767px) {
  .campaigns-main-list .camp-list-block .camp-list-block-in .campaigns-brand .campaigns-name .brand-name, .slider-ipgallery ul .camp-list-block .camp-list-block-in .campaigns-brand .campaigns-name .brand-name {
    font-size: 12px;
  }
}
.campaigns-main-list .camp-list-block .camp-list-block-in .campaigns-brand .campaigns-name .desc, .slider-ipgallery ul .camp-list-block .camp-list-block-in .campaigns-brand .campaigns-name .desc {
  font-size: 12px;
  overflow: hidden;
  text-overflow: ellipsis;
  white-space: nowrap;
}
@media (min-width: 768px) and (max-width: 1024px) {
  .campaigns-main-list .camp-list-block .camp-list-block-in .campaigns-brand .campaigns-name .desc, .slider-ipgallery ul .camp-list-block .camp-list-block-in .campaigns-brand .campaigns-name .desc {
    font-size: 12px;
  }
}
@media (max-width: 767px) {
  .campaigns-main-list .camp-list-block .camp-list-block-in .campaigns-brand .campaigns-name .desc, .slider-ipgallery ul .camp-list-block .camp-list-block-in .campaigns-brand .campaigns-name .desc {
    font-size: 10px;
  }
}
.campaigns-main-list .camp-list-block .camp-list-block-in .campaign-img, .slider-ipgallery ul .camp-list-block .camp-list-block-in .campaign-img {
  height: 100%;
  overflow: hidden;
  border-radius: 6px;
}
.campaigns-main-list .camp-list-block .camp-list-block-in .campaign-img img, .slider-ipgallery ul .camp-list-block .camp-list-block-in .campaign-img img {
  width: 100%;
  height: 100%;
  -o-object-fit: cover;
  object-fit: cover;
  border-radius: 6px;
}
.campaigns-main-list .camp-list-block .camp-list-block-in .camp-hover, .slider-ipgallery ul .camp-list-block .camp-list-block-in .camp-hover {
  position: absolute;
  background: rgba(0, 0, 0, 0.8);
  height: 100%;
  width: 100%;
  border-radius: 6px;
  top: 0;
  left: 0;
  visibility: hidden;
}
.campaigns-main-list .camp-list-block .camp-list-block-in .camp-hover span, .slider-ipgallery ul .camp-list-block .camp-list-block-in .camp-hover span {
  position: absolute;
  left: 50%;
  top: 50%;
  transform: translate(-50%, -50%);
  color: #fff;
  text-transform: uppercase;
}
@media (max-width: 767px) {
  .campaigns-main-list .camp-list-block .camp-list-block-in .camp-hover span, .slider-ipgallery ul .camp-list-block .camp-list-block-in .camp-hover span {
    font-size: 13px;
  }
}
.campaigns-main-list .camp-list-block .camp-list-block-in:hover .camp-hover, .slider-ipgallery ul .camp-list-block .camp-list-block-in:hover .camp-hover {
  visibility: visible;
}

.slider-ipgallery ul .camp-list-block {
  width: 100%;
  margin: 0 0 20px;
}
@media (max-width: 767px) {
  .slider-ipgallery ul .camp-list-block {
    margin: 0;
  }
}

.latest-int-ads h2 {
  font-size: 30px;
  line-height: 30px;
  color: #000;
}
@media (max-width: 767px) {
  .latest-int-ads h2 {
    font-size: 22px;
  }
}
.latest-int-ads .slider-wrap {
  position: relative;
}
.latest-int-ads .slider-wrap .nav-split .prev, .latest-int-ads .slider-wrap .nav-split .next {
  position: absolute;
  top: 50%;
  transform: translateY(-50%);
  background: #fff;
}
.latest-int-ads .slider-wrap .nav-split .prev {
  left: -15px;
}
@media (max-width: 767px) {
  .latest-int-ads .slider-wrap .nav-split .prev {
    left: -10px;
  }
}
.latest-int-ads .slider-wrap .nav-split .next {
  right: -15px;
}
@media (max-width: 767px) {
  .latest-int-ads .slider-wrap .nav-split .next {
    right: -10px;
  }
}
.latest-int-ads .slider-wrap .nav-split svg {
  fill: #000;
}

/************** How we work ****************/
.hw-panel {
  padding: 60px 0;
}
.hw-panel .hw-panel-in {
  height: 350px !important;
  border-radius: 25px;
  padding: 20px;
  margin: 0 auto 40px auto;
  width: 90%;
  overflow: hidden;
  -webkit-box-shadow: 0px 0px 35px 0px rgba(0, 0, 0, 0.12), 0px 6px 12px rgba(0, 0, 0, 0.08);
  box-shadow: 0px 0px 35px 0px rgba(0, 0, 0, 0.12), 0px 6px 12px rgba(0, 0, 0, 0.08);
}
.hw-panel .hw-panel-in img {
  max-width: 300px;
}
@media (max-width: 1024px) {
  .hw-panel .hw-panel-in img {
    max-width: 100%;
  }
}
.hw-panel .hw-panel-in:last-child {
  margin-bottom: 0;
}
@media (max-width: 1024px) {
  .hw-panel .hw-panel-in {
    height: auto !important;
  }
}
@media (max-width: 479px) {
  .hw-panel .hw-panel-in {
    padding: 15px;
    width: 95%;
  }
}

/**************** Blog Main ******************/
.blog-main {
  /** promotional content **/
  /** all posts **/
}
.blog-main ul li {
  margin-bottom: 50px;
  display: flex;
  -webkit-display: flex;
  justify-content: space-between;
}
.blog-main ul li .entry-thumbnail {
  vertical-align: top;
}
.blog-main ul li .entry-thumbnail .post-img {
  display: block;
  width: 160px;
  height: 160px;
  margin: 0 auto;
  overflow: hidden;
  -webkit-transition: transform 0.2s ease-in-out;
  transition: transform 0.2s ease-in-out;
  background: rgba(0, 0, 0, 0.7);
}
.blog-main ul li .entry-thumbnail .post-img img {
  width: 100%;
  height: 100%;
  object-fit: cover;
  -webkit-transition: transform 0.2s ease-in-out;
  transition: transform 0.2s ease-in-out;
}
.blog-main ul li .entry-thumbnail .post-img img:hover, .blog-main ul li .entry-thumbnail .post-img img:focus {
  -webkit-transform: scale(1.05);
  -moz-transform: scale(1.05);
  transform: scale(1.05);
}
@media (max-width: 479px) {
  .blog-main ul li .entry-thumbnail .post-img {
    width: 100px;
    height: 100px;
  }
}
.blog-main ul li .entry-content {
  padding-left: 15px;
  height: 120px;
  position: relative;
  width: calc(100% - 120px);
}
@media (max-width: 479px) {
  .blog-main ul li .entry-content {
    width: calc(100% - 100px);
    height: 100px;
  }
}
.blog-main ul li .entry-content h4.post-title {
  font-size: 20px;
  max-height: 52px;
  width: 100%;
  position: relative;
  margin-top: -5px;
  margin-bottom: 20px;
}
@media (max-width: 767px) {
  .blog-main ul li .entry-content h4.post-title {
    font-size: 18px;
  }
}
@media (max-width: 479px) {
  .blog-main ul li .entry-content h4.post-title {
    max-height: 25px;
  }
}
.blog-main ul li .entry-content h4.post-title a {
  color: #383838;
  overflow: hidden !important;
  text-overflow: ellipsis !important;
  -o-text-overflow: ellipsis;
  display: -webkit-box !important;
  -webkit-line-clamp: 2 !important;
  -webkit-box-orient: vertical;
  font-weight: bold;
}
.blog-main ul li .entry-content h4.post-title a:hover, .blog-main ul li .entry-content h4.post-title a:focus {
  color: #f5333f;
}
.blog-main ul li .entry-content p {
  height: 25px;
  width: 100%;
  overflow: hidden !important;
  text-overflow: ellipsis !important;
  -o-text-overflow: ellipsis;
  display: -webkit-box !important;
  -webkit-line-clamp: 2 !important;
  -webkit-box-orient: vertical;
  font-size: 14px;
}
.blog-main ul li .entry-content .post-info {
  position: absolute;
  bottom: -42px;
  font-size: 13px;
}
.blog-main ul li .entry-content .post-info p:nth-child(1) {
  color: #383838;
  font-weight: bold;
}
.blog-main ul li:last-child {
  margin-bottom: 0 !important;
}
.blog-main .latest-posts .left {
  width: calc(100% - 420px);
  height: 480px;
  margin-right: 20px;
  background-color: #f5f5f5;
  float: left;
  position: relative;
}
@media (max-width: 1279px) {
  .blog-main .latest-posts .left {
    width: 100%;
    float: none;
  }
}
@media (min-width: 480px) and (max-width: 767px) {
  .blog-main .latest-posts .left {
    height: 300px;
  }
}
@media (max-width: 479px) {
  .blog-main .latest-posts .left {
    height: 202px;
  }
}
.blog-main .latest-posts .left .bg {
  width: 100%;
  height: 100%;
  overflow: hidden;
  position: absolute;
  right: 0;
  left: 0;
}
.blog-main .latest-posts .left .bg img {
  width: 100%;
  height: 100%;
  object-fit: cover;
}
.blog-main .latest-posts .left .left-cont {
  height: 100%;
  width: 100%;
  position: absolute;
  background: rgba(0, 0, 0, 0.7);
}
.blog-main .latest-posts .left .left-cont-in {
  position: absolute;
  bottom: 10px;
  left: 15px;
  max-width: 400px;
  color: #fff;
}
.blog-main .latest-posts .left .left-cont-in h1 {
  margin-bottom: 0;
  font-size: 36px;
  line-height: 40px;
  max-height: 80px;
  overflow: hidden !important;
  text-overflow: ellipsis !important;
  -o-text-overflow: ellipsis;
  display: -webkit-box !important;
  -webkit-line-clamp: 2 !important;
  -webkit-box-orient: vertical;
}
.blog-main .latest-posts .left .left-cont-in h1 a {
  color: #fff;
}
.blog-main .latest-posts .left .left-cont-in h1 a:hover {
  color: #f5333f;
}
@media (min-width: 480px) and (max-width: 767px) {
  .blog-main .latest-posts .left .left-cont-in h1 {
    font-size: 30px;
    line-height: 30px;
    max-height: 60px;
  }
}
@media (max-width: 479px) {
  .blog-main .latest-posts .left .left-cont-in h1 {
    font-size: 25px;
    line-height: 30px;
    max-height: 60px;
  }
}
.blog-main .latest-posts .left .left-cont-in h1 + p {
  overflow: hidden !important;
  text-overflow: ellipsis !important;
  -o-text-overflow: ellipsis;
  display: -webkit-box !important;
  -webkit-line-clamp: 2 !important;
  -webkit-box-orient: vertical;
  max-height: 26px;
}
.blog-main .latest-posts .left .left-cont-in .post-info {
  margin-top: 20px;
}
@media (max-width: 479px) {
  .blog-main .latest-posts .left .left-cont-in .post-info {
    margin-top: 15px;
  }
}
.blog-main .latest-posts .right {
  float: right;
  width: 400px;
}
@media (max-width: 1279px) {
  .blog-main .latest-posts .right {
    width: 100%;
    float: none;
    margin-top: 40px;
  }
}
@media (max-width: 1279px) {
  .blog-main .latest-posts {
    height: auto !important;
  }
}
@media (max-width: 1279px) {
  .blog-main .latest-posts .section-in {
    height: auto !important;
    display: block;
  }
}
.blog-main .latest-posts ul li {
  margin-bottom: 26.5px;
}
.blog-main .latest-posts ul li .entry-thumbnail .post-img {
  width: 100px;
  height: 100px;
}
.blog-main .latest-posts ul li .entry-content {
  height: 100px;
  width: calc(100% - 100px);
}
.blog-main .latest-posts ul li .entry-content h4.post-title {
  margin-right: 0;
  padding-right: 0;
  text-align: left !important;
  max-height: 25px !important;
  margin-bottom: 5px;
  font-size: 18px;
}
.blog-main .latest-posts ul li .entry-content h4.post-title:before {
  content: none !important;
}
.blog-main .latest-posts ul li .entry-content h4.post-title:after {
  content: none !important;
}
.blog-main .latest-posts ul li .entry-content h4.post-title + p {
  font-size: 14px;
}
.blog-main .latest-posts ul li .entry-content h4.post-title a {
  max-height: 25px;
  overflow: hidden !important;
  text-overflow: ellipsis !important;
  -o-text-overflow: ellipsis;
  display: -webkit-box !important;
  -webkit-line-clamp: 2 !important;
  -webkit-box-orient: vertical;
}
.blog-main .latest-posts ul li .entry-content .post-info {
  bottom: -7px;
  font-size: 12px;
}
.blog-main .latest-posts ul li .entry-content .post-info p:nth-child(1) {
  margin-bottom: -4px;
}
.blog-main .promotion-content {
  min-height: 80px;
  display: flex;
  -webkit-display: flex;
  align-items: center;
  justify-content: left;
  -webkit-box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
  box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
  padding: 15px;
  font-size: 20px;
  color: #fff;
}
.blog-main .all-posts .left {
  width: calc(100% - 420px);
  height: 100%;
  margin-right: 20px;
  float: left;
  position: relative;
}
@media (max-width: 767px) {
  .blog-main .all-posts .left {
    width: 100%;
    float: none;
  }
}
.blog-main .all-posts .left .entry-content {
  padding-left: 0;
  padding-right: 15px;
}
@media (max-width: 479px) {
  .blog-main .all-posts .left .entry-content {
    padding-right: 10px;
  }
}
@media (max-width: 479px) {
  .blog-main .all-posts .left .entry-content h4 {
    margin-bottom: 5px;
  }
  .blog-main .all-posts .left .entry-content h4 a {
    max-height: 25px;
  }
}
@media (max-width: 479px) {
  .blog-main .all-posts .left .entry-content .post-info {
    bottom: -7px;
  }
  .blog-main .all-posts .left .entry-content .post-info p:nth-child(1) {
    margin-bottom: -4px;
  }
}
.blog-main .all-posts .left .entry-thumbnail img {
  object-fit: cover;
}
.blog-main .all-posts .right {
  float: right;
  width: 360px;
  margin-left: 40px;
}
@media (max-width: 767px) {
  .blog-main .all-posts .right {
    width: 100%;
    float: none;
    margin-left: 0;
    margin-top: 40px;
  }
}
.blog-main .all-posts .popular-posts {
  -webkit-box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
  box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
  padding: 20px;
}
@media (max-width: 479px) {
  .blog-main .all-posts .popular-posts {
    padding: 15px;
  }
}
.blog-main .all-posts .popular-posts h3 {
  margin-bottom: 20px;
}
.blog-main .all-posts .popular-posts ul li {
  margin-bottom: 25px;
}
.blog-main .all-posts .popular-posts ul li .entry-thumbnail .post-img {
  width: 80px;
  height: 80px;
}
.blog-main .all-posts .popular-posts ul li .entry-content {
  height: 80px;
  width: calc(100% - 80px);
}
.blog-main .all-posts .popular-posts ul li .post-info {
  bottom: -5px;
}
.blog-main .all-posts .popular-posts .entry-content h4.post-title {
  margin-right: 0;
  padding-right: 0;
  text-align: left !important;
  max-height: 25px;
  word-wrap: break-word;
  font-size: 18px;
}
.blog-main .all-posts .popular-posts .entry-content h4.post-title:before {
  content: none !important;
}
.blog-main .all-posts .popular-posts .entry-content h4.post-title:after {
  content: none !important;
}
.blog-main .all-posts .popular-posts .entry-content h4.post-title a {
  max-height: 25px;
}
.blog-main .all-posts .search-blog {
  margin-bottom: 34.5px;
}
.blog-main .all-posts .search-blog .search-input input {
  width: 100%;
  padding: 0px;
  border: none;
  margin: 0px;
  height: auto;
  background: url("https://cdn2.hubspot.net/hubfs/1635524/assets/website/images/search-icon.png") left center no-repeat white;
  background-size: 20px;
  text-indent: 35px;
  outline: none;
  -webkit-box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
  box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
  padding: 8px;
  background-position: 10px;
  color: inherit;
}
.blog-main .all-posts .search-blog .search-tags {
  -webkit-box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
  box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
  padding: 15px;
}
@media (max-width: 479px) {
  .blog-main .all-posts .search-blog .search-tags {
    padding: 10px;
  }
}
.blog-main .all-posts .search-blog .search-tags a {
  background: #f5333f;
  color: #fff;
  padding: 2px 10px;
  border-radius: 25px;
  margin: 5px;
  display: inline-block;
}

/************** blog detail ****************/
.blog-detail h1 {
  color: #000;
  margin-top: 5px;
  max-width: 100%;
  font-size: 40px;
}
@media (max-width: 479px) {
  .blog-detail h1 {
    font-size: 26px;
  }
}
.blog-detail h1 a:hover {
  color: #f5333f;
}
.blog-detail h2, .blog-detail h3 {
  background-image: linear-gradient(to right, #f5333f 0%, #ac222b 100%);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}
.blog-detail ul {
  margin-bottom: 20px;
}
@media (min-width: 768px) and (max-width: 1024px) {
  .blog-detail .flex-col-rev {
    display: block;
    flex-direction: initial;
  }
}
.blog-detail .left {
  width: 49%;
  display: inline-block;
  vertical-align: middle;
  padding-right: 30px;
}
@media (min-width: 768px) and (max-width: 1024px) {
  .blog-detail .left {
    padding-right: 15px;
  }
}
@media (max-width: 767px) {
  .blog-detail .left {
    width: 100%;
    margin-top: 30px;
  }
}
.blog-detail .left .desc {
  max-width: 450px;
}
.blog-detail .right {
  width: 49%;
  display: inline-block;
  vertical-align: middle;
  margin: 0 auto;
}
@media (max-width: 767px) {
  .blog-detail .right {
    width: 100%;
    max-height: 360px;
    overflow: hidden;
    object-fit: cover;
  }
}
.blog-detail .cat-name {
  color: #f5333f;
  text-transform: uppercase;
}
.blog-detail .post-info {
  margin-top: 30px;
}
@media (max-width: 767px) {
  .blog-detail .post-info {
    margin-bottom: 30px;
  }
}
.blog-detail .post-info .img {
  width: 70px;
  height: 70px;
  border-radius: 50%;
  display: inline-block;
  vertical-align: middle;
  overflow: hidden;
  -webkit-box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
  box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
  background: url(https://cdn2.hubspot.net/hubfs/1635524/assets/website/images/user_b.png) center/contain no-repeat;
  background-size: cover;
  background-position: center;
}
.blog-detail .post-info .img img {
  width: 100%;
  height: 100%;
  object-fit: cover;
  -webkit-box-shadow: 0 10px 12px -4px rgba(0, 0, 0, 0.3);
  box-shadow: 0 10px 12px -4px rgba(0, 0, 0, 0.3);
}
.blog-detail .post-info .info {
  width: calc(100% - 75px);
  display: inline-block;
  vertical-align: middle;
  padding-left: 10px;
  color: #000;
  font-size: 14px;
}
.blog-detail .post-info .info .name {
  color: #000;
  font-size: 18px;
}
.blog-detail .post-info.btm .img {
  width: 120px;
  height: 120px;
}
@media (max-width: 767px) {
  .blog-detail .post-info.btm .img {
    width: 100px;
    height: 100px;
  }
}
.blog-detail .post-info.btm .info {
  width: calc(100% - 125px);
}
@media (max-width: 767px) {
  .blog-detail .post-info.btm .info {
    width: calc(100% - 105px);
  }
}
.blog-detail .post-info.btm .info .name {
  font-size: 20px;
  margin-bottom: 10px;
}
.blog-detail .post-info.btm .info .written-by {
  font-size: 13px;
  text-transform: uppercase;
}
.blog-detail .post-cont {
  width: 80%;
  margin: 0 auto;
  position: relative;
}
@media (max-width: 767px) {
  .blog-detail .post-cont {
    width: 90%;
    margin: 0 auto 0 10%;
    padding-left: 5px;
  }
}
.blog-detail .post-cont .post-cont-in {
  margin-bottom: 35px;
}
.blog-detail .post-cont .post-cont-in:last-child {
  margin-bottom: 0;
}
.blog-detail .post-cont .post-cont-in p {
  margin-bottom: 1.5em;
}
.blog-detail .post-cont .post-cont-in p:first-child:first-letter {
  color: #000;
  float: left;
  font-size: 50px;
  margin-right: 10px;
  line-height: 1;
  font-weight: bold;
}
.blog-detail .post-cont .post-cont-in h2 {
  margin-bottom: 15px;
}
.blog-detail .post-cont .social-share .left {
  position: absolute;
  top: 0;
  left: -10%;
  width: auto;
}
.blog-detail .post-cont .social-share .left ul li {
  margin-bottom: 15px;
}
.blog-detail .post-cont .social-share .left ul li:last-child {
  margin-bottom: 0;
}
.blog-detail .post-cont .social-share .left ul li img {
  width: 22px;
}
.blog-detail .post-cont .social-share .bottom {
  text-align: right;
}
.blog-detail .post-cont .social-share .bottom ul li {
  margin-right: 15px;
  display: inline;
}
.blog-detail .post-cont .social-share .bottom ul li:last-child {
  margin-right: 0;
}
.blog-detail .post-cont .social-share .bottom ul li img {
  width: 22px;
}
.blog-detail .post-cont .social-share ul li a {
  -webkit-transition: transform 0.2s ease-in-out;
  transition: transform 0.2s ease-in-out;
}
.blog-detail .post-cont .social-share ul li a:hover img {
  -webkit-transform: scale(1.05);
  -moz-transform: scale(1.05);
  transform: scale(1.05);
}
@media (min-width: 480px) and (max-width: 767px) {
  .blog-detail video, .blog-detail .hs-responsive-embed, .blog-detail iframe {
    max-width: 400px;
    max-height: 250px;
  }
}
@media (max-width: 479px) {
  .blog-detail video, .blog-detail .hs-responsive-embed, .blog-detail iframe {
    max-width: 300px;
    max-height: 200px;
  }
}
.blog-detail .post-nav .next, .blog-detail .post-nav .prev {
  margin-bottom: 12px;
}
.blog-detail .post-nav .next a, .blog-detail .post-nav .prev a {
  text-transform: uppercase;
  color: #000;
  font-size: 14px;
}
.blog-detail .post-nav .next a:hover, .blog-detail .post-nav .prev a:hover {
  color: #f5333f;
}
.blog-detail .post-nav .post-info .info {
  width: 100%;
  padding-left: 0;
  color: #000;
}
.blog-detail .related-post {
  margin: 0 -10px;
}
.blog-detail .related-post .related-post-in {
  width: 33.3333%;
  float: left;
  padding: 0 10px;
}
@media (max-width: 767px) {
  .blog-detail .related-post .related-post-in {
    width: 100%;
    float: none;
    margin-bottom: 35px;
  }
}
@media (max-width: 767px) {
  .blog-detail .related-post .related-post-in:last-child {
    margin-bottom: 0px;
  }
}
.blog-detail .related-post .related-post-in .entry-img {
  overflow: hidden;
}
.blog-detail .related-post .related-post-in .entry-img:hover img {
  -webkit-transform: scale(1.05);
  -moz-transform: scale(1.05);
  transform: scale(1.05);
}
.blog-detail .related-post .related-post-in .entry-img img {
  -webkit-box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
  box-shadow: 0 0 12px -4px rgba(0, 0, 0, 0.3);
  -webkit-transition: transform 0.2s ease-in-out;
  transition: transform 0.2s ease-in-out;
  height: 200px;
  object-fit: cover;
  object-position: center;
  width: 100%;
}
@media (min-width: 768px) and (max-width: 1024px) {
  .blog-detail .related-post .related-post-in .entry-img {
    height: auto;
  }
}
.blog-detail .related-post .related-post-in .entry-content {
  margin-top: 25px;
}
.blog-detail .related-post .related-post-in .entry-content .post-title {
  margin-bottom: 8px;
}
.blog-detail .related-post .related-post-in .entry-content .post-title a {
  color: #000;
  font-size: 22px;
}
.blog-detail .related-post .related-post-in .entry-content .post-title a:hover {
  color: #f5333f;
}
.blog-detail .related-post .related-post-in .entry-content .post-info {
  margin-top: 20px;
}
.blog-detail .related-post .related-post-in .entry-content .post-info .info {
  width: 100%;
  padding-left: 0;
}

/************** 404 page *******************/
.notfound-block {
  padding: 0 !important;
  position: relative;
}
@-moz-keyframes rocket-movement {
  100% {
    -moz-transform: translate(1200px, -600px);
  }
}
@-webkit-keyframes rocket-movement {
  100% {
    -webkit-transform: translate(1200px, -600px);
  }
}
@keyframes rocket-movement {
  100% {
    transform: translate(1200px, -600px);
  }
}
@-moz-keyframes spin-earth {
  100% {
    -moz-transform: rotate(-360deg);
    transition: transform 20s;
  }
}
@-webkit-keyframes spin-earth {
  100% {
    -webkit-transform: rotate(-360deg);
    transition: transform 20s;
  }
}
@keyframes spin-earth {
  100% {
    -webkit-transform: rotate(-360deg);
    transform: rotate(-360deg);
    transition: transform 20s;
  }
}
@-moz-keyframes move-astronaut {
  100% {
    -moz-transform: translate(-160px, -160px);
  }
}
@-webkit-keyframes move-astronaut {
  100% {
    -webkit-transform: translate(-160px, -160px);
  }
}
@keyframes move-astronaut {
  100% {
    -webkit-transform: translate(-160px, -160px);
    transform: translate(-160px, -160px);
  }
}
@-moz-keyframes rotate-astronaut {
  100% {
    -moz-transform: rotate(-720deg);
  }
}
@-webkit-keyframes rotate-astronaut {
  100% {
    -webkit-transform: rotate(-720deg);
  }
}
@keyframes rotate-astronaut {
  100% {
    -webkit-transform: rotate(-720deg);
    transform: rotate(-720deg);
  }
}
@-moz-keyframes glow-star {
  40% {
    -moz-opacity: 0.3;
  }
  90%, 100% {
    -moz-opacity: 1;
    -moz-transform: scale(1.2);
  }
}
@-webkit-keyframes glow-star {
  40% {
    -webkit-opacity: 0.3;
  }
  90%, 100% {
    -webkit-opacity: 1;
    -webkit-transform: scale(1.2);
  }
}
@keyframes glow-star {
  40% {
    -webkit-opacity: 0.3;
    opacity: 0.3;
  }
  90%, 100% {
    -webkit-opacity: 1;
    opacity: 1;
    -webkit-transform: scale(1.2);
    transform: scale(1.2);
    border-radius: 999999px;
  }
}
.notfound-block .spin-earth-on-hover {
  transition: ease 200s !important;
  transform: rotate(-3600deg) !important;
}
.notfound-block .notfound-block-in {
  width: 100%;
}
.notfound-block .notfound-block-in h1 {
  margin: 0 auto 25px auto;
  font-family: "Just Another Hand", cursive;
  font-size: 50px;
}
@media (max-width: 767px) {
  .notfound-block .notfound-block-in h1 {
    font-size: 35px;
  }
}
.notfound-block .btn {
  background-image: linear-gradient(to right, #443164 0%, #24173a 100%);
  background-position: center;
}
.notfound-block .central-body {
  /*    width: 100%;*/
  padding: 17% 5% 10% 5%;
  text-align: center;
}
@media (min-width: 768px) and (max-width: 1024px) {
  .notfound-block .central-body {
    padding: 27% 5% 20% 5%;
  }
}
@media (max-width: 767px) {
  .notfound-block .central-body {
    padding-top: 120px;
    padding-bottom: 100px;
  }
}
.notfound-block .objects img {
  z-index: 90;
  pointer-events: none;
}
.notfound-block .object_rocket {
  z-index: 95;
  position: absolute;
  transform: translateX(-50px);
  top: 75%;
  pointer-events: none;
  animation: rocket-movement 200s linear infinite both running;
}
.notfound-block .object_earth {
  position: absolute;
  top: 20%;
  left: 10%;
  z-index: 90;
  width: 280px;
  /*    animation: spin-earth 100s infinite linear both;*/
}
@media (min-width: 1025px) and (max-width: 1280px) {
  .notfound-block .object_earth {
    width: 200px;
    top: 8%;
    left: 10%;
  }
}
@media (min-width: 768px) and (max-width: 1024px) {
  .notfound-block .object_earth {
    width: 180px;
    top: 8%;
    left: 10%;
  }
}
@media (min-width: 480px) and (max-width: 767px) {
  .notfound-block .object_earth {
    width: 120px;
    top: 30px;
    left: 10px;
  }
}
@media (max-width: 479px) {
  .notfound-block .object_earth {
    width: 90px;
    top: 20px;
    left: 5px;
  }
}
.notfound-block .object_astronaut {
  animation: rotate-astronaut 200s infinite linear both alternate;
}
.notfound-block .box_astronaut {
  z-index: 110 !important;
  position: absolute;
  top: 60%;
  right: 20%;
  will-change: transform;
  animation: move-astronaut 50s infinite linear both alternate;
  width: 240px;
}
@media (min-width: 768px) and (max-width: 1024px) {
  .notfound-block .box_astronaut {
    width: 160px;
  }
}
@media (max-width: 767px) {
  .notfound-block .box_astronaut {
    width: 120px;
    top: 70%;
  }
}
@media (max-width: 479px) {
  .notfound-block .box_astronaut {
    width: 70px;
    bottom: 20px;
  }
}
.notfound-block .image-404 {
  position: relative;
  z-index: 100;
  pointer-events: none;
}
.notfound-block .stars {
  background: url(http://salehriaz.com/404Page/img/overlay_stars.svg);
  background-repeat: repeat;
  background-size: contain;
  background-position: left top;
}
.notfound-block .glowing_stars .star {
  position: absolute;
  border-radius: 100%;
  background-color: #fff;
  width: 3px;
  height: 3px;
  opacity: 0.3;
  will-change: opacity;
}
.notfound-block .glowing_stars .star:nth-child(1) {
  top: 80%;
  left: 25%;
  animation: glow-star 2s infinite ease-in-out alternate 1s;
}
.notfound-block .glowing_stars .star:nth-child(2) {
  top: 20%;
  left: 40%;
  animation: glow-star 2s infinite ease-in-out alternate 3s;
}
.notfound-block .glowing_stars .star:nth-child(3) {
  top: 25%;
  left: 25%;
  animation: glow-star 2s infinite ease-in-out alternate 5s;
}
.notfound-block .glowing_stars .star:nth-child(4) {
  top: 75%;
  left: 80%;
  animation: glow-star 2s infinite ease-in-out alternate 7s;
}
.notfound-block .glowing_stars .star:nth-child(5) {
  top: 90%;
  left: 50%;
  animation: glow-star 2s infinite ease-in-out alternate 9s;
}

/************** footer *********************/
footer .footer-top {
  overflow: hidden;
  width: 100%;
  color: #fff;
}
footer .footer-top .subscribe {
  width: 49%;
  display: inline-block;
  vertical-align: middle;
}
footer .footer-top .subscribe h3 {
  margin-bottom: 20px;
}
footer .footer-top .followus {
  width: 295px;
  display: inline-block;
  vertical-align: middle;
  float: right;
}
footer .footer-top .followus h3 {
  margin-bottom: 20px;
}
@media (max-width: 767px) {
  footer .footer-top .followus h3 {
    margin-top: 15px;
  }
}
@media (max-width: 767px) {
  footer .footer-top .followus {
    width: 100%;
    text-align: center;
    margin-top: 20px;
  }
}
footer .footer-top .followus span {
  display: inline-block;
  vertical-align: middle;
}
footer .footer-top .followus .social-icons span {
  margin-left: 30px;
}
footer .footer-top .followus .social-icons span img {
  width: 75%;
  -webkit-transition: transform 0.5s ease-in-out;
  transition: transform 0.5s ease-in-out;
}
@media (max-width: 479px) {
  footer .footer-top .followus .social-icons span img {
    width: 70%;
  }
}
footer .footer-top .followus .social-icons span:hover img {
  transform: rotate(360deg);
  -webkit-transform: rotate(360deg);
}
footer .footer-top .followus .social-icons span:first-child {
  margin-left: 0;
}
@media (max-width: 1024px) {
  footer .footer-top .followus .social-icons span {
    margin-left: 8px;
  }
}
footer .footer-main {
  background: #f6f6f6;
  overflow: hidden;
}
footer .footer-main h4 {
  margin-bottom: 10px;
}
footer .footer-main ul li {
  margin: 20px 0;
  display: block;
}
@media (max-width: 767px) {
  footer .footer-main ul li {
    margin: 10px 0;
  }
}
footer .footer-main ul li:last-child {
  margin-bottom: 0;
}
footer .footer-main .col {
  float: left;
}
footer .footer-main .col.col-1, footer .footer-main .col.col-5 {
  width: 15%;
}
@media (min-width: 768px) and (max-width: 1024px) {
  footer .footer-main .col.col-1, footer .footer-main .col.col-5 {
    width: 33.333%;
  }
}
footer .footer-main .col.col-2, footer .footer-main .col.col-3, footer .footer-main .col.col-4 {
  width: 23.333%;
}
@media (min-width: 768px) and (max-width: 1024px) {
  footer .footer-main .col.col-2, footer .footer-main .col.col-3, footer .footer-main .col.col-4 {
    width: 33.333%;
  }
}
@media (min-width: 768px) and (max-width: 1024px) {
  footer .footer-main .col.col-4, footer .footer-main .col.col-5 {
    margin-top: 40px;
  }
}
footer .footer-main .col.col-2, footer .footer-main .col.col-3, footer .footer-main .col.col-4, footer .footer-main .col.col-5 {
  text-transform: uppercase;
}
@media (min-width: 480px) and (max-width: 767px) {
  footer .footer-main .col.col-1, footer .footer-main .col.col-2, footer .footer-main .col.col-3, footer .footer-main .col.col-4, footer .footer-main .col.col-5 {
    width: 50%;
    height: 200px;
  }
}
@media (max-width: 479px) {
  footer .footer-main .col.col-1, footer .footer-main .col.col-2, footer .footer-main .col.col-3, footer .footer-main .col.col-4, footer .footer-main .col.col-5 {
    width: 100%;
    margin-bottom: 20px;
  }
}

/*# sourceMappingURL=main.cs.map */
