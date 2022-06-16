let arrow = document.querySelector(".arrow");

window.addEventListener("scroll",function(){
    if(this.window.scrollY == 0){
        arrow.style.opacity = "0";
    }
    else
    {
        arrow.style.opacity = "1";
    }
})

$('.owl-carousel').owlCarousel({
    loop:true,
    margin:10,
    nav:true,
    responsive:{
        0:{
            items:1
        },
        600:{
            items:2
        },
        1000:{
            items:3
        }
    }
})

function myFunction() {
    var x = document.getElementById("myLinks");
    if (x.style.display === "block") {
      x.style.display = "none";
    } else {
      x.style.display = "block";
    }
  }