var express = require('express');
var info = require('./info');
var PerformNextMove = require('./PerformNextMove');

var app = express();

app.get('/Info', info);
app.post('/PerformNextMove', PerformNextMove);

var server = app.listen(8081);
