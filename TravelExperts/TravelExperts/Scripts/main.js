//jQuery coded by Mike
$(document).ready(function() {
    // remove and add lines under headers
    $('.heading-text-box h3').addClass('added-class');
    $('#Register h3').addClass('addLine');

    // Code for scroll to top button
    var offset = 220;
    var duration = 800;
    $(window).scroll(function() {
        if (jQuery(this).scrollTop() > offset) {
            $('.back-to-top').fadeIn(duration);
        } else {
            $('.back-to-top').fadeOut(duration);
        }
    });

    $('.back-to-top').click(function(event) {
        event.preventDefault();
        $('html, body').animate({scrollTop: 0}, duration);
        return false;
    });

    $('a[href*="#"]').not('[href="#"]').click(function(event) {
        event.preventDefault();
        var target = $(this.hash);
        $('html, body').animate({
            scrollTop: target.offset().top - 80
        }, duration);
    });


    /* For the sticky navigation */
    //$('.js--section-features').waypoint(function(direction) {
    //    if (direction == "down") {
    //        $('nav').addClass('sticky');
    //    } else {
    //        $('nav').removeClass('sticky');
    //    }
    //}, {
    //    offset: '10px;'
    //});
});