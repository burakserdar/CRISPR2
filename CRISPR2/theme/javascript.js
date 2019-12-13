



function do_change1(id) {
    document.getElementById(id).style.visibility = "visible";

}




//$("select.extra").click(function () {

//    //$(this).parents(".btn-group").find('.btn').text($(this).text());

//    //$(this).parents(".row").find('.extra2').css({ 'visibility': 'visible' });


//});


$('.extra').change(function () {

    //$(this).parents(".row").find('.extra2').css({ 'visibility': 'visible' });
    console.log("fonksiyona girdi");

    $("#off").css({ 'visibility': 'visible' });

});

$('#tamamla').click(function () {
    var Sorganism = $("#Sorganism option:selected").text();
    var Torganism = $(".Torganism").val();


    var Simplement = $("#Simplement option:selected").text();
    var Timplement = $(".Timplement").val();

    var Srna = $("#Srna option:selected").text();

    var Sofftarget = $("#Sofftarget option:selected").text();
    var Tofftarget = $(".Tofftarget").val();

    $("#lastorder").text(Sorganism + " " + Torganism + " " + Simplement + " " + Timplement + " " + Srna + " " + Sofftarget + " " + Tofftarget);

    

});








