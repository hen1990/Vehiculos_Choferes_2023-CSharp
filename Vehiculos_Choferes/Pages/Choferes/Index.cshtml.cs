using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vehiculos_Choferes.Datos;
using Vehiculos_Choferes.Modelos;

namespace Vehiculos_Choferes.Pages.Choferes
{
    public class IndexModel : PageModel
    {

        public readonly ApplicationDbContext _contexto;

        public IndexModel(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<Chofer> Choferes { get; set; }


        public async Task OnGet()
        {
            Choferes = await _contexto.Chofer.ToListAsync();
        }
    }
}
