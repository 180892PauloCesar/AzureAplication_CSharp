using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AzureApp.Models;
using Microsoft.CodeAnalysis;

namespace AzureApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["PaaS"] = "PaaS";
            ViewData["IaaS"] = "IaaS";
            ViewData["SaaS"] = "SaaS";
            ViewData["Software"] = "Software as a Service(SaaS), é um método para fornecer aplicativos de software pela internet, sob demanda, e normalmente com base em assinaturas.Nessa categoria, os provedores de nuvem hospedam e gerenciam o aplicativo de software e a infraestrutura subjacente, sendo também responsáveis por manutenções, como atualizações de software e patches de segurança. Permite utilizar aplicativos rapidamente com um custo inicial mínimo.";
            ViewData["Platform"]  = "Platform as a Service (PaaS), temos, sob demanda, um ambiente para desenvolvimento, teste, fornecimento e gerenciamento de aplicativos de software. O objetivo dessa categoria é facilitar aos desenvolvedores criarem aplicativos móveis ou web rapidamente, sem se preocupar com a configuração ou com o gerenciamento de infraestrutura de servidores, armazenamento, rede e banco de dados. Permite evitar os gastos e a complexidade de comprar e gerenciar licenças de software, infraestrutura e middleware de aplicativo ou ferramentas de desenvolvimento e outros recursos.";
            ViewData["Infrastructure"] = " Infrastructure as a Service (IaaS). Nessa categoria é possível alugar infraestrutura de TI, como servidores, máquinas virtuais, armazenamento, redes e sistemas operacionais, de um provedor de nuvem em uma base pré-paga. O provisionamento e o gerenciamento dessa infraestrutura é todo feito pela internet, o que ajuda a evitar os gastos e a complexidade que haveriam se tivéssemos que comprar e gerenciar nossos próprios servidores físicos e outras infraestruturas em um datacenter.";


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
}
