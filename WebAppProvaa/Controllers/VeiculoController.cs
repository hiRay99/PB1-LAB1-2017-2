using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppProvaa.Models;

namespace WebAppProvaa.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly Prova1Context _context;

        public VeiculoController(Prova1Context context)
        {

        }
    }

}
