using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tutorial1.Controllers
{
    public class PostController : Controller
    {
        // GET: Hello world

        public string Index()
        {
            return "this is my <b> Default - InDex <b> action ...";
        }
        // GET: Hello world/welcome
        public string Welcome()
        {
            return "this is welcome action method";
        }
    }
}