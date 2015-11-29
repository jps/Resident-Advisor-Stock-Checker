open Suave
open Suave.Http
open Suave.Http.Applicatives
open Suave.Http.Successful
open Suave.Web

//starts a web server returning a 200 ok on localhost:8083 
//startWebServer defaultConfig (OK "Hello World!")
let app = 
    choose
        [ GET >>= choose
            [  path "/" >>= OK "Hello World!"
               path "/hello" >>= OK "Hello GET"
               path "/goodbye" >>= OK "Goodbye GET"]
          POST >>= choose
            [   path "/hello" >>= OK "Hello POST"
                path "/goodbye" >>= OK "Goodbye POST"]
        ]

//starts a web server on localhost:8083 
startWebServer defaultConfig (app)