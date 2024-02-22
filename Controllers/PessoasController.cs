using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class PessoasController : Controller
{
    private readonly AplicacaoDbContexto _context;

    public PessoasController(AplicacaoDbContexto context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var pessoas = _context.Pessoas.ToList();
        return View(pessoas);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(PessoaModel pessoa)
    {
        _context.Pessoas.Add(pessoa);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Edit(int id)
    {
        var pessoa = _context.Pessoas.Find(id);
        return View(pessoa);
    }

    [HttpPost]
    public IActionResult Edit(PessoaModel pessoa)
    {
        _context.Pessoas.Update(pessoa);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(int id)
    {
        var pessoa = _context.Pessoas.Find(id);
        return View(pessoa);
    }

    [HttpPost]
    public IActionResult DeleteConfirmed(int id)
    {
        var pessoa = _context.Pessoas.Find(id);
        _context.Pessoas.Remove(pessoa);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}
