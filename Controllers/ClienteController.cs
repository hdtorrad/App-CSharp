using Microsoft.AspNetCore.Mvc;
using SP3072118MVCDB.Models;
namespace SP3072118MVCDB.Controllers;
public class ClienteController : Controller
{
    private readonly MvcDBContext _context;

    public ClienteController(MvcDBContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Cliente);
    }

    public IActionResult Show(int id)
    {
        Cliente? cliente =_context.Cliente.Find(id);

        if(cliente == null)
        {
            return NotFound();
        }
        return View(cliente);
    }

    public IActionResult Create()
    {      
        return View();
    }

    public IActionResult CreateResult(int clienteId, string nome, string rG, string cpf, string endereco)
    {
        if(_context.Cliente.Find(clienteId) == null)
        {
            _context.Cliente.Add(new Cliente(clienteId, nome, rG, cpf, endereco));
            _context.SaveChanges();
            return RedirectToAction("Create");
        }
        else
        {
           return Content("Já existe um cliente com esse id.");
        }
       
    }

    public IActionResult Delete(int id)
    {
        _context.Cliente.Remove(_context.Cliente.Find(id));
        _context.SaveChanges();
        return View();
    }

    public IActionResult Update(int id)
    {
        Cliente cliente = _context.Cliente.Find(id);
        if(cliente == null)
        {
            return Content("Esse cliente não existe.");
        }
        else
        {
           return View(cliente);
        }
    }

    public IActionResult UpdateResult(int Id, string endereco, string nome, string rG, string cpf, string endereo)
    {
        Cliente cliente = _context.Cliente.Find(Id);

        cliente.Id = Id;
        cliente.Endereco = endereco;
        cliente.Nome = nome;
        cliente.RG = rG;
        cliente.CPF = cpf;

        _context.SaveChanges();
        return RedirectToAction("Index");
    }   
}
