﻿Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Message") = "Modify this template to jump-start your ASP.NET MVC application."

        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your quintessential app description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your quintessential contact page."
        'cambio hecho por QA sobre rama desarrollo



        'este es un cambio hecho por otra persona!!!!!!!!!!!!!!!!!!!
        Return View()
    End Function
End Class
