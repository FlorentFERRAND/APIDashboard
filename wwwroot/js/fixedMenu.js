$(window).scroll(function() {
    var sticky = $('.menu-header-fixed'),
        scroll = $(window).scrollTop();
    if (scroll >= 1) {
        sticky.addClass('sticky');
        sticky.addClass('shadow');
    }
    else {
        sticky.removeClass('sticky');
        sticky.removeClass('shadow');
    }
});