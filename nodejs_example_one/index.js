const welcome = require('./welcome'); //including a module that is a file within your program


var express = require('express')
var app = express()



app.get('/', function (req, res) {
    var name = "Chris";
    var welcomeMessage = welcome.welcome();
  res.send(`Hello  ${name}.  ${welcomeMessage}`)
})


app.get('/about', function (req, res) {
    var pageNameAbout = "the about us page";

  res.send(`This is  ${pageNameAbout}`)
})

app.get('/contact', function (req, res) {
    var pageNameContact = "the contact us page";




  res.send(`This is  ${pageNameContact}`)
})


 
app.listen(3000)
