using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Pedro Programador Paiva", "794.111.230-23", "peprog@programador.com.br", "Devdog");
        Cliente cliente2 = new Cliente(02, "Arthur A. Ferreira", "857.032.950-41", "arthur.antunes@sp.senai.br", "Madruga");
        Cliente cliente3 = new Cliente(03, "William Henry Gates III", "039.618.250-09", "bill@microsoft.com", "Bug");
        Cliente cliente4 = new Cliente(04, "Ada Lovelace", "800.777.920-50", "ada@ada.language.com", "Byron");
        Cliente cliente5 = new Cliente(05, "Linus Torvalds", "933.622.400-03", "torvalds@osdl.org", "Pinguim");
        Cliente cliente6 = new Cliente(06, "Grace Hopper", "911.702.988-00", "grace.hopper@cobol.com", "Loboc");
        Cliente cliente7 = new Cliente(07, "Valéria do Paracuru", "880.507.560-41", "valdoparacuru@paracuru.com", "Gaboso");
        Cliente cliente8 = new Cliente(08, "Elzir Cabral Ferroviário", "698.012.840-05", "elicabralferr@ferroviaria.br", "Tutbas");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);
        listaClientes.Add(cliente6);
        listaClientes.Add(cliente7);
        listaClientes.Add(cliente8);

        ViewBag.listaClientes = listaClientes;


        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A", "14.182.102/0001-80", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "CtrlAlt Dog", "15.836.698/0001-57", "ctrl@alt.dog.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "BootsPetINC", "40.810.224/0001-83", "boots.pet@gatomania.us");
        Fornecedor fornecedor4 = new Fornecedor(04, "TikTok Dogs", "87.945.350/0001-09", "noisnamidia@tiktokdogs.uk");
        Fornecedor fornecedor5 = new Fornecedor(05, "Bifinho Forever", "18.760.614/0001-37", "contato@bff.us");
        Fornecedor fornecedor6 = new Fornecedor(06, "Mercado das Raçoes", "14.182.102/0001-80", "mecaçoes@mercado.org");
        Fornecedor fornecedor7 = new Fornecedor(07, "PET Dreams", "14.182.102/0001-80", "dreampetis@dreamspet.org");

        List<Fornecedor>listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);
        listaFornecedores.Add(fornecedor6);
        listaFornecedores.Add(fornecedor7);

        ViewBag.listaFornecedores = listaFornecedores;


        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
