function stars (){
    let e = document.createElement(`div`);
    e.setAttribute('class', 'star');
    document.body.appendChild(e);
    e.style.left = Math.random() * + innerWidth + 'px';
    setTimeout(function () {
        document.body, removeChild(e)
    }, 100)

}





setInterval(function () {
    stars()
},2000)

