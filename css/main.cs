@import url("https://fonts.googleapis.com/css?family=Ubuntu");
@import url(../);
.btn-outline {
  border: 0.125rem solid #057E6C;
  border-radius: 5rem;
  display: inline-block;
  padding: 0.35em 2em 0.45em;
  background-color: transparent;
  text-decoration: none;
  box-shadow: 4px 4px 2px 1px rgba(0, 0, 255, 0.2);
  color: #057E6C;
  cursor: pointer;
}
.btn-outline:hover, .btn-outline:focus {
  background-color: #196b5b;
  border-color: #057E6C;
  transform: translateY(-4px);
  color: #fff;
}

.btn-white {
  border: 0.125rem solid #fff;
  border-radius: 5rem;
  display: inline-block;
  padding: 0.35em 2em 0.45em;
  background-color: transparent;
  text-decoration: none;
  color: #fff;
  transition: color 0.2s background-color 0.2s;
}
.btn-white:hover, .btn-white:focus {
  background-color: #196b5b;
  border-color: #057E6C;
  transform: translateY(-4px);
  color: #fff;
}

.header,
.header1 {
  padding: 0.75rem 0;
  text-align: center;
  overflow: hidden;
}
.header .logo,
.header1 .logo {
  margin-bottom: 0.75rem;
}
.header .logo img,
.header1 .logo img {
  max-width: 9em;
}
.header .logo_1,
.header1 .logo_1 {
  display: inline-block;
  max-width: 10rem;
  width: 100%;
}

.nav ul,
.nav1 ul {
  list-style-type: none;
  padding: 0;
  margin: 0;
}
.nav li,
.nav1 li {
  margin-bottom: 0.75rem;
}
.nav a,
.nav1 a {
  text-decoration: none;
  color: #057E6C;
  transform: translateY(-2px);
}
.nav a:focus,
.nav1 a:focus {
  color: darkblue;
}

.skipLinks {
  position: absolute;
  padding: 4px;
  left: 50%;
  transform: translateY(-150%);
  list-style-type: none;
  background-color: #bbb;
  transition: transform 0.2s;
}
.skipLinks:focus {
  transform: translateY(0%);
}
.skipLinks a {
  display: inline-block;
  color: #031A8C;
  font-weight: 500;
  text-decoration: none;
  z-index: 1000;
}

footer {
  text-align: center;
  color: #fff;
  background-color: #057E6C;
}
footer .logo_1 {
  display: block;
  margin-bottom: 0.75rem;
  margin: 0 auto;
}
footer a {
  color: #fff;
}
footer img {
  max-width: 10em;
  margin-bottom: 1.25rem;
}
footer .container {
  padding: 1.5rem;
}
footer .container .logo_1 {
  display: inline-block;
  max-width: 10rem;
  width: 100%;
}
footer .container .svgContent {
  display: flex;
}
footer .container .svgContent svg {
  width: auto;
  max-width: 2.5rem;
  margin: 1rem;
}
footer .container .svgContent svg path {
  fill: #fff;
  stroke: #fff;
  stroke-width: 1;
}
footer .container .svgContent svg path:focus, footer .container .svgContent svg path:hover {
  fill: #000;
  stroke: #000;
  stroke-width: 1;
  transition-delay: 150ms;
}
footer .sub-footer {
  background-color: #196b5b;
}
footer .sub-footer ul {
  margin: 0;
  padding: 0;
  font-size: smaller;
  list-style-type: none;
}
footer .sub-footer li {
  display: inline-block;
}
footer .sub-footer .top {
  color: #fff;
  background-color: black;
  position: fixed;
  bottom: 0;
  padding: 0.5em;
  right: 5rem;
  border-radius: 0.75em 0.75em 0 0;
  text-align: center;
  text-decoration: none;
}

.afford {
  text-align: center;
  padding: 3rem;
  width: auto;
}
.afford h1 {
  text-transform: uppercase;
  font-size: 3rem;
  color: darkgreen;
}
.afford p {
  font-size: 2.2rem;
}

.form-group {
  border-collapse: collapse;
  overflow: hidden;
  width: 100%;
}
.form-group thead {
  font-weight: bold;
  font-size: 1.5rem;
}
.form-group .tbody {
  position: relative;
}
.form-group .tbody th {
  padding: 2rem;
  font-size: 1.25rem;
  font-weight: bold;
}
.form-group .tbody .trPrice {
  border-bottom: none;
}
.form-group .tbody .trPrice th {
  padding: 4rem;
}
.form-group .tbody .trPrice td {
  padding: none;
  font-weight: bold;
  font-size: 4rem;
}
.form-group .tbody .trPrice td sup {
  font-size: 2rem;
}
.form-group .tbody .trSignup {
  border-bottom: none;
}
.form-group .tbody .trSignup th {
  padding-bottom: none;
}
.form-group .tbody td {
  text-align: center;
}
.form-group tr:nth-child(2) {
  border-bottom: 1px solid #ccc;
}
.form-group .tr-text th {
  padding: none;
}
.form-group .trBasic {
  border-bottom: none;
}
.form-group .trUnder {
  background-color: #DEFDC3;
  color: #057E6C;
}

.banner {
  background-size: cover;
  background-position: center;
  padding: 10rem 1.5rem;
  text-align: center;
  font-size: 1.5rem;
  color: #057E6C;
}
.banner h1,
.banner p,
.banner .btn,
.banner h2 {
  position: relative;
  z-index: 1;
  transform: translateX(-20rem);
  opacity: 0;
  animation: slideIntoSection 550ms 0.7s forwards;
}
@keyframes slideIntoSection {
  from {
    transform: translateX(-20rem);
    opacity: 0;
  }
  to {
    transform: none;
    opacity: 1;
  }
}
.banner p {
  animation-delay: 1s;
}
.banner .btn {
  animation-delay: 1.25s;
}

.banner-hero {
  background-image: linear-gradient(to bottom, #00000099, #00000099), url(../image/banners/hero-home.jpg);
}

.banner-action {
  background-image: linear-gradient(to bottom, #00000099, #00000099), url(../image/banners/soccer-banner-bw.jpg);
  padding: 5rem 1.5rem;
}

.banner-platform {
  background-image: linear-gradient(to bottom, #00000099, #00000099), url(../image/banners/hero-platform.jpg);
  margin-bottom: 5rem;
}

.build {
  gap: 1.5rem;
  padding-top: 1.5rem 0;
  align-items: center;
}
.build h1 {
  text-transform: uppercase;
  font-weight: lighter;
  font-size: 1.8em;
  margin-bottom: 1rem;
  color: #000;
}
.build h2 {
  font-weight: 600;
  font-size: 1.1em;
}
.build img {
  display: block;
  margin: 0 auto;
  width: 100%;
  padding-top: 1rem;
}
.build .build1,
.build .build2,
.build .build3,
.build .build4 {
  margin: 1.5rem auto;
  padding: 0 1.5em;
  max-width: 100%;
  width: 70%;
  display: grid;
  grid-template-areas: "text" "image";
}
.build .build1 .build-text,
.build .build2 .build-text,
.build .build3 .build-text,
.build .build4 .build-text {
  grid-area: text;
}
.build .build1 .build-img,
.build .build2 .build-img,
.build .build3 .build-img,
.build .build4 .build-img {
  grid-area: image;
}
@media only screen and (min-width: 38em) {
  .build .build1,
.build .build3 {
    grid-template-areas: "image text";
    grid-template-columns: 1fr 2fr;
  }
  .build .build2,
.build .build4 {
    grid-template-areas: "text image";
    grid-template-columns: 2fr 1fr;
  }
  .build .build-text {
    width: 50%;
    line-height: 1.5em;
  }
}

html {
  font-family: "Ubuntu", sans-serif;
}

/*# sourceMappingURL=main.cs.map */
