open Suave                 // always open suave
open Suave.Http.Successful // for OK-result
open Suave.Web             // for config

//starts a web server returning a 200 ok on localhost:8083 
startWebServer defaultConfig (OK "Hello World!")