// $(window).on('scroll', function() {
//   var st = $(this).scrollTop();
//   var sb = $(this).scrollBottom();
//   var bar = document.getElementById('scrollsDown');
//   var scrolle = 0
// console.log(st);
// if(st-1){
//   bar.classList.add("active");
//   console.log("on");
// }else if(sb){
//   bar.classList.remove("active");
//   console.log("off");
// }
//
//
//  });


 $(function(){

   var CurrentScroll = 0;
   $(window).scroll(function(event){

       var NextScroll = $(this).scrollTop();
       var bar = document.getElementById('header-background');

       if (NextScroll > CurrentScroll){
          bar.classList.remove("active");
       }
       else {
          bar.classList.add("active");
       }

       if(NextScroll < 30){
         bar.classList.remove("active");
       }

       CurrentScroll = NextScroll;  //Updates current scroll position
   });
 });

// window.addEventListener("scroll", topBar);
// var bar = document.getElementById('scrollsDown');
// var scr = document.documentElement.scrollTop;
// console.log(scr);
// function topBar(){
//   if (document.documentElement.scrollTop --) {
//     bar.classList.add("active");
//
//   }else if(document.documentElement.scrollTop ++){
//     bar.classList.remove("active");
//
//   }
// }
