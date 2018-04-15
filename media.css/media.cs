/*Responsive web design*/
/*-Media-*/
/*M-(1) iPad --> max-width-1024 end end min-width-768*/
/*M-(2) iPone --> max-width-768 end min-width-320*/
@media only screen and (min-width: 768px) and (max-width: 1024px) {
  /*Child section Width end Height*/
  .cd-headline > span:first-child {
    font-size: 2.2rem;
  }
  .cd-headline > span:last-child {
    font-size: 2rem;
    font-weight: none;
  }
  .child_section {
    width: 74.4%;
    height: 92.8%;
  }
  /*style Header: text Animation*/
  #OurCurses > section > article section:nth-child(2) > article h3 {
    font-size: 1em;
  }
  #OurCurses > section > article section:nth-child(2) > article p {
    font-size: 0.7em;
  }
  #implementedProjects {
    min-height: 640px;
  }
  .vertical-carousel {
    display: flex;
    justify-content: space-between;
    align-items: center;
  }
  .item > fieldset {
    width: 31vw;
    height: 33vw;
    margin-top: 8.5em;
  }
  .item > fieldset > legend > div {
    width: 14vw;
  }
  .item > fieldset > legend > div > img {
    width: 6vw;
  }
  .text_container {
    text-align: center;
    height: 60%;
  }
  .text_container > h2 {
    font-size: 2.1vw;
  }
  .text_container > span {
    width: 7rem;
    height: 1px;
  }
  .text_container > p {
    width: 95%;
    margin: 14% auto;
    font-size: 1.3vw;
    line-height: 2.2vw;
    margin-bottom: 0px;
  }
  .text_container > button {
    font-size: 1.4vw;
    margin-top: 10%;
    width: 34%;
    height: 15.5%;
  }
  .vertical-carousel-indicators > li {
    font-size: 1.4vw;
    list-style: none;
    cursor: pointer;
    padding: 12px 0px 12px 0px;
    color: #fff;
    transition-duration: 0.50s;
  }
  .vertical-carousel-indicators li.active {
    padding-top: 1.8rem;
    padding-bottom: 1.8rem;
  }
  #needHelp > section > article:first-child > span {
    font-size: 0.7rem;
  }
  #needHelp > section > article:last-of-type > span {
    font-size: 2.2vw;
  }
  #GetStarted {
    width: 170px;
    height: 43px;
    font-size: 1.7vw;
  }
  .timeline ul li {
    font-size: 0.9rem;
  }
  .timeline ul li div {
    width: 205px;
  }
  .timeline ul li:nth-child(even) div {
    left: -255px;
    /*250+45-6*/
  }
  .timeline ul li::after {
    width: 70px;
    height: 70px;
  }
  #subsCribe > section > h2 {
    font-size: 2.3vw;
  }
  .wise_words {
    background-size: cover;
    background-position: center;
    margin-top: 5%;
  }
  .aphorisms {
    margin-left: 13%;
  }
  .aphorisms > h2 {
    font-size: 2.2vw;
    font-weight: 100;
  }
  .aphorisms > span {
    font-size: 1.4vw;
  }
  #userContact > input {
    height: 44px;
  }
  #userContact > input:last-child {
    font-size: 1.9vw;
    margin-top: 2%;
  }
  .be_informed > h3 {
    font-size: 1.6vw;
    margin-top: -2%;
  }
  .be_informed > p {
    font-size: 1.4vw;
  }
  footer > section:nth-of-type(1) {
    width: 70%;
  }
  footer section:nth-of-type(2) span {
    font-size: 1.3vw;
  }
}
@media only screen and (min-width: 320px) and (max-width: 768px) {
  /*Child section Width end Height*/
  /*                   */
  .child_section {
    width: 91.1%;
    height: 100vh;
  }
  /*                    */
  /*style Header: Fixed menu Basic.icon +search+menu+person*/
  header > a img {
    margin-left: 10%;
    margin-top: 5%;
    width: 85%;
  }
  #fixedBar > ul {
    display: flex;
  }
  #fixedBar > ul li > a img {
    max-width: 80%;
  }
  #fixedBar > ul li:last-child > a img {
    max-width: 53%;
  }
  #fixedBar > ul {
    display: flex;
    justify-content: center;
    padding: 0;
    margin: 4%;
  }
  #fixedBar > ul > li:first-child {
    display: none;
  }
  #fixedBar > ul > li:last-child {
    width: 16%;
  }
  .search {
    width: 16%;
  }
  .cd-intro {
    display: flex;
    justify-content: center;
    margin: 0;
  }
  .cd-headline {
    text-align: center;
    margin: 0;
  }
  .cd-headline > span:first-child {
    font-size: 2rem;
  }
  .cd-headline > span:last-child {
    font-size: 1.8rem;
  }
  .mouse_pad > a {
    position: absolute;
    bottom: 0;
    left: 50%;
    width: 2rem;
  }
  .mouse_pad > a img {
    width: 98%;
  }
  #implementedProjects section {
    width: 30%;
  }
  .vertical-carousel-indicators {
    display: none;
  }
  #myVerticalCarousel {
    overflow-y: scroll;
  }
  .vertical-carousel-box {
    margin: auto;
  }
  .item > fieldset {
    width: 22rem;
    height: 23rem;
    margin-top: 8.5em;
  }
  .item > fieldset > legend > div {
    width: 10rem;
  }
  .item > fieldset > legend > div > img {
    width: 4rem;
  }
  .text_container {
    text-align: center;
    height: 60%;
  }
  .text_container > h2 {
    font-size: 1.4rem;
  }
  .text_container > span {
    width: 8rem;
    height: 1px;
  }
  .text_container > p {
    width: 95%;
    margin: 14% auto;
    font-size: 0.9rem;
    line-height: 2.8vw;
    margin-bottom: 0px;
  }
  .text_container > button {
    font-size: 0.9rem;
    margin-top: 10%;
    width: 34%;
    height: 15.5%;
  }
  .vertical-carousel-indicators > li {
    font-size: 1.4vw;
    list-style: none;
    cursor: pointer;
    padding: 12px 0px 12px 0px;
    color: #fff;
    transition-duration: 0.50s;
  }
  .vertical-carousel-indicators li.active {
    padding-top: 1.8rem;
    padding-bottom: 1.8rem;
  }
  #needHelp section {
    background-size: 78%;
    min-height: 540px;
    /*min-height Height it's nedHelp > section*/
  }
  #needHelp section > article {
    display: flex;
    justify-content: center;
    flex-direction: column;
    text-align: center;
  }
  #needHelp section > article > span:first-of-type {
    font-size: 2.1vw;
  }
  #needHelp section > article > span:last-of-type {
    font-size: 3vw;
  }
  #GetStarted {
    width: 35.9%;
    height: 7vw;
    font-size: 3.1vw;
    margin: 9% auto;
  }
  .floating_img > img:nth-child(1) {
    top: 31%;
    width: 8.5%;
    /*Android*/
  }
  .floating_img > img:nth-child(2) {
    width: 7%;
    left: 30%;
    bottom: 15%;
    /* C# */
  }
  .floating_img > img:nth-child(3) {
    width: 6.8%;
    top: 65%;
    left: 14%;
    /* CSS */
  }
  .floating_img > img:nth-child(4) {
    width: 12%;
    bottom: 30%;
    right: 20%;
    /*PHP*/
  }
  .floating_img > img:nth-child(5) {
    width: 7.9%;
    top: 27%;
    right: 25% /*Pytone*/;
  }
  .floating_img > img:nth-child(6) {
    width: 6.8%;
    right: 6%;
    top: 50%;
    /*HTML*/
  }
  .floating_img > img:nth-child(7) {
    top: 15%;
    width: 7%;
    left: 35%;
    /*C++*/
  }
  .timeline ul li::after {
    width: 70px;
    height: 70px;
  }
  .timeline ul li {
    margin-left: 40px;
    font-size: 0.8rem;
  }
  .timeline ul li div {
    width: calc(60vw - 91px);
  }
  .timeline ul li:nth-child(even) div {
    left: 55px;
  }
  .timeline ul li:nth-child(even) div::before {
    left: -15px;
    border-width: 8px 16px 8px 0;
    border-color: transparent rgba(23, 19, 19, 0.43);
  }
  #subsCribe {
    display: flex;
    align-items: center;
    min-height: 600px;
    /*min-height Height it's #subsCribe*/
  }
  #subsCribe > section {
    min-height: 560px;
    /*min-height*/
  }
  .child_section {
    display: flex;
    flex-direction: column;
    justify-content: space-around;
  }
  .wise_words {
    height: 28.6%;
    width: 100%;
  }
  .slideshow1 {
    background-image: url(../img/aphorisms/Albert%20Eynshten2.png);
  }
  .aphorisms {
    margin-left: 13%;
  }
  .aphorisms > h2 {
    font-size: 4vw;
    font-weight: 100;
  }
  .aphorisms > span {
    font-size: 2.4vw;
    padding-top: 4%;
  }
  #subsCribe > section > h2 {
    font-size: 5.0vw;
    margin: 0;
    padding: 0;
  }
  #userContact > input {
    width: 64%;
    padding: 0;
  }
  #userContact input:last-child {
    width: 44%;
    margin-top: 3%;
    height: 6.6vw;
    font-size: 3.4vw;
  }
  #userContact > span {
    width: 64%;
  }
  .be_informed {
    margin-top: 0;
  }
  .be_informed > h3 {
    font-size: 3vw;
  }
  .be_informed > p {
    font-size: 2.7vw;
    margin-top: 0;
    margin-top: -2%;
  }
  .myButt {
    padding: 0.5rem 0.4rem 0.5rem 0.4rem;
    font-size: 60%;
  }
  .four .icon {
    padding: 0.4rem 0.5rem 0.2rem 0.8rem;
  }
  #last {
    height: 60vh;
    transition: 3s;
  }
  #last.container_consolidation {
    min-height: 150px;
  }
  #partner {
    height: 50vh;
  }
  footer {
    height: 10vh;
  }
  footer > section:nth-of-type(1) {
    display: none;
  }
  footer > section:nth-of-type(2) span {
    font-size: 2vw;
  }
}
@media only screen and (min-width: 320px) and (max-width: 768px) {
  .mouse_pad > a:first-child {
    position: absolute;
    bottom: 0;
    left: 49%;
    display: block;
  }
  .mouse_pad > a:first-child img {
    width: 1.7rem;
  }
  video[loop] {
    display: none;
  }
  body {
    background-color: black;
  }
  .icon-scroll {
    display: none;
  }
  #OurCurses {
    min-height: 740px;
  }
  #OurCurses > section {
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
    height: 620px;
  }
  #OurCurses > section > h2 {
    font-size: 1.5em;
  }
  #OurCurses > section > article {
    flex-direction: column;
    justify-content: center;
    align-items: center;
    width: 75%;
  }
  #OurCurses > section > article > section:nth-child(1) {
    width: 330px;
    max-width: 100%;
    height: 70%;
    border-radius: 10px 10px 0 0;
  }
  #OurCurses > section > article > section:nth-child(1) > article:nth-child(1) img {
    width: 9%;
    margin: 0;
  }
  #OurCurses > section > article > section:nth-child(1) > article:nth-child(1) h3 {
    margin: 2% 0 ;
    display: block;
    font-size: 1em;
  }
  #OurCurses > section > article > section:nth-child(2) {
    width: 330px;
    max-width: 100%;
    height: 30%;
    text-align: center;
    border-radius: 0 0 10px 10px;
    display: flex;
    align-items: center;
    justify-content: center;
  }
  #OurCurses > section > article > section:nth-child(2) button {
    width: 45%;
    height: 55%;
    line-height: 5%;
    font-size: 0.8em;
    margin: 0;
    border-radius: 5px;
  }
  #OurCurses > section > article > section:nth-child(2) article {
    display: none;
  }
  .owl-carousel .owl-item img {
    display: inline-flex;
    max-width: 90%;
    height: 34px;
  }
  #partner section {
    width: 90%;
    justify-content: center;
  }
  #partner section > section {
    width: 200px;
    flex-direction: row;
    justify-content: flex-start;
    overflow: hidden;
  }
  #partner section > section > article {
    width: 100%;
  }
  #partner section > section > article > article {
    min-width: 100px;
  }
}
@media only screen and (min-width: 768px) and (max-width: 1024px) {
  .about_us h1 {
    font-size: 1.7rem;
  }
  .about_us h3 {
    font-size: 1.1rem;
  }
  #mouse-scroll span {
    width: 6px;
    height: 6px;
  }
  .timeline ul li {
    font-size: 0.9rem;
  }
  .timeline ul li div {
    width: 205px;
  }
  .timeline ul li:nth-child(even) div {
    left: -255px;
    /*250+45-6*/
  }
  .timeline ul li::after {
    width: 70px;
    height: 70px;
  }
}
@media only screen and (min-width: 320px) and (max-width: 768px) {
  .about_us h1 {
    font-size: 1.5rem;
  }
  .about_us h3 {
    font-size: 0.9rem;
  }
  #mouse-scroll span {
    width: 4px;
    height: 4px;
  }
  .timeline ul li::after {
    width: 70px;
    height: 70px;
  }
  .timeline ul li {
    margin-left: 40px;
    font-size: 0.8rem;
  }
  .timeline ul li div {
    width: calc(60vw - 91px);
  }
  .timeline ul li:nth-child(even) div {
    left: 55px;
  }
  .timeline ul li:nth-child(even) div::before {
    left: -15px;
    border-width: 8px 16px 8px 0;
    border-color: transparent rgba(23, 19, 19, 0.43) transparent transparent;
  }
}
