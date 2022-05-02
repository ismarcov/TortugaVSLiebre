// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
// Write your JavaScript code.

var turtleConnection = new signalR.HubConnectionBuilder().withUrl("/progressBar").withAutomaticReconnect().build();
var rabbitConnection = new signalR.HubConnectionBuilder().withUrl("/progressBar").withAutomaticReconnect().build();
var turtle = 0;
var rabbit = 0;
var apuestaCant = $('#apuesta').val();

$('#liebreOpt').click(function () {
    $('#compGroup').removeClass("d-block").fadeOut(1000, function () {
        $('#msgAdvice').text("Tu apuesta:");    
        $('#apuestaDiv').delay(1000).addClass('d-flex').fadeIn(1000);
        $('#jugarBtn').delay(1000).addClass('d-block').fadeIn(1000);        
    });    
});

$('#tortugaOpt').click(function () {
    $('#compGroup').removeClass("d-block").fadeOut(1000, function () {
        $('#msgAdvice').text("Tu apuesta:");    
        $('#apuestaDiv').delay(1000).addClass('d-flex').fadeIn(1000);
        $('#jugarBtn').delay(1000).addClass('d-block').fadeIn(1000);        
    });    
});

turtleConnection.on("ReceiveTurtleDist", function (turtleSpeed) {
    turtle = turtleSpeed;
    console.log("Tortuga: " + turtleSpeed);
    var turtlePercentage = (turtle / 100) * 100;
    if (turtleSpeed > 100) {
        console.log("Finish!");
        $('#jugarBtn').attr("disabled", false);
        if ($('#tortugaOpt').val() != "Tortuga") {
            apuestaCant *= -1;
        }
        saveWinner("Tortuga", apuestaCant);
        turtle = 0;
    } else {        
        $('#tortugaProgress').attr("aria-valuenow", turtle);
        $('#tortugaProgress').width(turtlePercentage + '%');
        $('#turtleImg').css({ left: turtlePercentage + '%' });
        invokeTurtle(turtle);
    }
});

rabbitConnection.on("ReceiveRabbitDist", function (rabbitSpeed) {
    rabbit = rabbitSpeed;
    console.log("Liebre: " + rabbitSpeed);
    var rabbitPercentage = (rabbit / 100) * 100;
    if (rabbitSpeed > 100) {
        console.log("Finish!");
        $('#jugarBtn').attr("disabled", false);
        $('#liebreProgress').attr("aria-valuenow", 100);
        $('#liebreProgress').width(100 + '%');
        $('#rabbitImg').css({ left: '100%' });
        rabbit = 0;
    } else {
        $('#liebreProgress').attr("aria-valuenow", rabbit);
        $('#liebreProgress').width(rabbitPercentage + '%');
        $('#rabbitImg').css({ left: rabbitPercentage + '%'});
        invokeRabbit(rabbit);
    }
});

turtleConnection.start().then(function () {
    //document.getElementById("sendButton").disabled = false;
    console.log("Tortuga Conectado!");
}).catch(function (err) {
    return console.error(err.toString());
});

rabbitConnection.start().then(function () {
    //document.getElementById("sendButton").disabled = false;
    console.log("Liebre Conectado!");
}).catch(function (err) {
    return console.error(err.toString());
});

function invokeTurtle(number) {
    turtleConnection.invoke("getTurtleStatus", number).catch(function (err) {
        return console.error(err.toString());
    });
}

function invokeRabbit(number) {
    rabbitConnection.invoke("getRabbitStatus", number).catch(function (err) {
        return console.error(err.toString());
    });
}

function jugar() {
    event.preventDefault;
    $('#jugarBtn').attr("disabled", true);
    $('#apuestaContainer').addClass("d-none");
    $('#msgAdvice').text("Vamos!!");
    $('#pista').addClass('d-block')
    invokeTurtle(turtle);
    invokeRabbit(rabbit);   
}

function saveWinner(ganador, apuestaNum) {    
    var fechaCarrera = Date.now();
    var apostadores = Math.floor(Math.random() * 100) + 1;
    var numCarrera = Math.floor(Math.random() * 100000) + 1;
    var ganancias = apuestaNum;
    var clasificatoria = new Object();
    clasificatoria.NumCarrera = numCarrera;
    clasificatoria.Id = numCarrera;
    clasificatoria.Ganador = ganador;
    clasificatoria.FechaCarrera = fechaCarrera;
    clasificatoria.Apostadores = apostadores;
    clasificatoria.Ganancias = 1;
    if (apuestaNum > 0) {
        ganancias = apostadores * apuestaCant;
    }
    
    //NumCarrera, Id, Ganador, FechaCarrera, Apostadores, Ganancias
    $.ajax({
        url: "Clasificatorias/agregar",
        type: "POST",
        data: JSON.parse(clasificatoria),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function () {
            console.log("Registro Guardado!");
        },
        error: function (err) {
            console.log("Error! " + JSON.stringify(err));
        }
    });
}
