"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/messagehub").build();

connection.start();

connection.on("ReceiveMessageHandler", function (message) {
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    alert(msg);
});