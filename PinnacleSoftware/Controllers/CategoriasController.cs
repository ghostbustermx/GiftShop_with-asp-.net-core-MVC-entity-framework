using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PinnacleSoftware.Data;
using PinnacleSoftware.Models;
using PinnacleSoftware.ModelsClass;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace PinnacleSoftware.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly ApplicationDbContext _context;
        private CategoriaModels categoriaModels;

        
        public CategoriasController(ApplicationDbContext context)
        {
            _context = context;
            categoriaModels = new CategoriaModels(_context);
        }

        // GET: Categorias
        [Authorize(Roles = "Administrador")]
        public async Task<IActionResult> Index()
        {
            return View();
        }
        public List<object[]> filtrarDatos(int numPagina, string valor, string order)
        {
            return categoriaModels.filtrarDatos(numPagina, valor, order);
        }
        public List<Categoria> getCategorias(int id)
        {
            return categoriaModels.getCategorias(id);
        }
        public List<IdentityError> editarCategoria(int id, string nombre, string descripcion, Boolean estado, int funcion)
        {
            return categoriaModels.editarCategoria(id, nombre, descripcion, estado, funcion);
        }
        
        public List<IdentityError> guardarCategoria(string nombre, string descripcion, string estado)
        {
            return categoriaModels.guardarCategoria(nombre,descripcion,estado);
        }
     
    }
}
