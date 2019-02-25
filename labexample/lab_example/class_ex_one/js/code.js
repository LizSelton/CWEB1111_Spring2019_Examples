window.addEventListener("load", function(){
    var nodes = document.querySelectorAll('nav[data-action="expand"] *:first-child');
    for(var i =0; i < nodes.length; i++){
        nodes[i].addEventListener("click", function(){
            var parent = this.parentNode;
            if(parent.classList.contains("open") == false)parent.classList.add("open");
            
            else parent.classList.remove("open");
             });
    }

    var nodes = document.querySelectorAll('nav[data-action="expand"] *:nth-child(2) > *');
    for(var i=0; i < nodes.length; i++){
        nodes[i].style.transitionDelay = (0.5 + (i/3))+"s";
    }
})