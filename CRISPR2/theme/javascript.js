



function do_change1(id) {
    document.getElementById(id).style.visibility = "visible";

}




//$("select.extra").click(function () {

//    //$(this).parents(".btn-group").find('.btn').text($(this).text());

//    //$(this).parents(".row").find('.extra2').css({ 'visibility': 'visible' });


//});


$('.extra').change(function () {
    
    //$(this).parents(".row").find('.extra2').css({ 'visibility': 'visible' });
    console.log("fonsiyona girdi");

    $("#off").css({ 'visibility': 'visible' });
});






