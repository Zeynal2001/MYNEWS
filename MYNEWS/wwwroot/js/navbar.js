document.addEventListener('scroll', () => {
    let nav = document.getElementById('mainNav');
    if (window.scrollY != 0) {
        nav.classList.add('position-fixed');
        nav.style.zIndex = 99999;
        nav.style.top = 0;
    } else {
        nav.classList.remove('position-fixed');
        nav.style.zIndex = 0;
        //nav.style.top = 0;
    }
});