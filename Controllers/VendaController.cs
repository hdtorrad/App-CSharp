using Microsoft.AspNetCore.Mvc;
using SP3072118MVCDB.Models;
namespace SP3072118MVCDB.Controllers;
public class VendaController : Controller
{
    private readonly MvcDBContext _context;

    public VendaController(MvcDBContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Venda);
    }

    public IActionResult Show(int id)
    {
        Venda? venda =_context.Venda.Find(id);

        if(venda == null)
        {
            return NotFound();
        }
        return View(venda);
    }

    public IActionResult Create()
    {      
        return View();
    }

    public IActionResult CreateResult(int vendaId, int pedidoId, int clienteId, string dataVenda, float desconto, float valorBruto)
    {
        if(_context.Venda.Find(vendaId) == null)
        {
            _context.Venda.Add(new Venda(vendaId, pedidoId, clienteId, dataVenda, desconto, valorBruto));
            _context.SaveChanges();
            return RedirectToAction("Create");
        }
        else
        {
           return Content("Já existe um venda com esse id.");
        }
       
    }

    public IActionResult Delete(int id)
    {
        _context.Venda.Remove(_context.Venda.Find(id));
        _context.SaveChanges();
        return View();
    }

    public IActionResult Update(int id)
    {
        Venda venda = _context.Venda.Find(id);
        if(venda == null)
        {
            return Content("Esse venda não existe.");
        }
        else
        {
           return View(venda);
        }
    }

    public IActionResult UpdateResult(int vendaId, int pedidoId, int clienteId, string dataVenda, float desconto, float valorBruto)
    {
        Venda venda = _context.Venda.Find(vendaId);

        venda.VendaId = vendaId;
        venda.PedidoId = pedidoId;
        venda.ClienteId = clienteId;
        venda.DataVenda = dataVenda;
        venda.Desconto = desconto;
        venda.ValorBruto = valorBruto;
        _context.SaveChanges();
        return RedirectToAction("Index");
    }   
}