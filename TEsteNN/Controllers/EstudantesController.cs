using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TEsteNN.Models;

namespace Controllers
{
    public class EstudantesController : Controller
    {
        private readonly TesteNNContext _context;

        public EstudantesController(TesteNNContext context)
        {
            _context = context;
        }

        // GET: Estudantes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Estudante.ToListAsync());
        }

        // GET: Estudantes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudante = await _context.Estudante
                .FirstOrDefaultAsync(m => m.EstudanteId == id);

            var estudanteViewModel = new EstudantesViewModel();
            estudanteViewModel.EstudanteId = id.Value;
            estudanteViewModel.Nome = estudante.Nome;
            estudanteViewModel.Idade = estudante.Idade;
            estudanteViewModel.Sexo = estudante.Sexo;
            var cursos = from c in _context.Curso
                                   select new
                                   {
                                       c.CursoId,
                                       c.Nome,
                                       Checked = ((from ce in _context.CursosEstudantes
                                                   where (ce.EstudanteId == id) & (ce.CursoId == c.CursoId)
                                                   select ce).Count() > 0)
                                   };

            var checkboxListCursos = new List<CheckBoxViewModel>();
            foreach (var item in cursos)
            {
                checkboxListCursos.Add(new CheckBoxViewModel
                {
                    Id = item.CursoId,
                    Nome = item.Nome,
                    Checked = item.Checked
                });
            }
            estudanteViewModel.Cursos = checkboxListCursos;


            if (estudanteViewModel == null)
            {
                return NotFound();
            }

            return View(estudanteViewModel);
        }

        // GET: Estudantes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Estudantes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EstudanteId,Nome,Idade,Sexo")] Estudante estudante)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estudante);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estudante);
        }

        // GET: Estudantes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudante = await _context.Estudante.FindAsync(id);
            if (estudante == null)
            {
                return NotFound();
            }
            var CursosEstudantes = from c in _context.Curso
                                   select new
                                   {
                                       c.CursoId,
                                       c.Nome,
                                       Checked = ((from ce in _context.CursosEstudantes
                                                   where (ce.EstudanteId == id) & (ce.CursoId == c.CursoId)
                                                   select ce).Count() > 0)
                                   };
            var estudanteViewModel = new EstudantesViewModel();
            estudanteViewModel.EstudanteId = id.Value;
            estudanteViewModel.Nome = estudante.Nome;
            estudanteViewModel.Idade = estudante.Idade;
            estudanteViewModel.Sexo = estudante.Sexo;
            var checkboxListCursos = new List<CheckBoxViewModel>();
            foreach (var item in CursosEstudantes)
            {
                checkboxListCursos.Add(new CheckBoxViewModel
                {
                    Id = item.CursoId,
                    Nome = item.Nome,
                    Checked = item.Checked
                });
            }
            estudanteViewModel.Cursos = checkboxListCursos;
            return View(estudanteViewModel);
        }
    

        // POST: Estudantes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EstudanteId,Nome,Idade,Sexo, Cursos")] EstudantesViewModel estudante)
        {
            if (id != estudante.EstudanteId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var estudanteSelecionado = _context.Estudante.Find(estudante.EstudanteId);
                    estudanteSelecionado.Nome = estudante.Nome;
                    estudanteSelecionado.Idade = estudante.Idade;
                    estudanteSelecionado.Sexo = estudante.Sexo;
                    foreach (var item in _context.CursosEstudantes)
                    {
                        if (item.EstudanteId == estudante.EstudanteId)
                        {
                            _context.Entry(item).State = EntityState.Deleted;
                        }
                    }
                    foreach (var item in estudante.Cursos)
                    {
                        if (item.Checked)
                        {
                            _context.CursosEstudantes.Add(new CursoEstudante()
                            {
                                EstudanteId = estudante.EstudanteId,
                                CursoId = item.Id
                            });
                        }
                    }
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstudanteExists(estudante.EstudanteId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(estudante);
        }

        // GET: Estudantes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudante = await _context.Estudante
                .FirstOrDefaultAsync(m => m.EstudanteId == id);
            if (estudante == null)
            {
                return NotFound();
            }

            return View(estudante);
        }

        // POST: Estudantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var estudante = await _context.Estudante.FindAsync(id);
            _context.Estudante.Remove(estudante);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstudanteExists(int id)
        {
            return _context.Estudante.Any(e => e.EstudanteId == id);
        }
    }
}
