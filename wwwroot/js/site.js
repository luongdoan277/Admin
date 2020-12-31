
const imgFuild = document.querySelectorAll('.img-fuild');
const imgGallery = document.querySelector('.img-gallery');
const navLink = document.querySelectorAll('.nav-link');


navLink.forEach((link, index) => {
    link.addEventListener('click', function () {
        navLink.forEach(link => { link.classList.remove('active-img') });
        link.classList.add('active-img');
        imgGallery.src = imgFuild[index].src;
    });
})