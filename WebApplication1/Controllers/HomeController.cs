using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text.Json.Serialization;
using WebApplication1.Models;

namespace WebApplication1.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }



        public IActionResult Index() {

            var jsonOrdems = @"[
            {
              'idx': 1,
              'PostoNome': 'MAQ 1',
              'NumeroOrdem': 2075,
              'DescricaoOrdem': 'TRATOR AGRO - VERMELHO',
              'Item': 'sem',
              'DataInicial': '2023-04-24T07:30:00',
              'DataFinal': '2023-04-24T08:17:36',
              'TempoOrdem': 2856,
              'TempoEventos': 68852,
              'TempoEventosNP': 507,
              'TempoEventosP': 68345,
              'Produzido': 548,
              'Refugado': 13,
              'TempoProduzido': 3425,
              'Disponibilidade': 99.76410924487043,
              'Eficiencia': 1.597309990066364,
              'Qualidade': 97.62773722627736,
              'TempoTeorico': 6.25,
              'TempoReal': 391.28284671532845,
              'OEE': 1.5557390778392965,
              'Operador': 'Luana Garcia Ramos',
              'Turno': null
            },
            {
                        'idx': 2,
              'PostoNome': 'MAQ 1',
              'NumeroOrdem': 2075,
              'DescricaoOrdem': 'TRATOR AGRO - VERMELHO',
              'Item': 'sem',
              'DataInicial': '2023-04-24T08:17:36',
              'DataFinal': '2023-04-24T13:00:13',
              'TempoOrdem': 16957,
              'TempoEventos': 0,
              'TempoEventosNP': 0,
              'TempoEventosP': 0,
              'Produzido': 1884,
              'Refugado': 8,
              'TempoProduzido': 11775,
              'Disponibilidade': 100.0,
              'Eficiencia': 69.4403491183582,
              'Qualidade': 99.57537154989384,
              'TempoTeorico': 6.25,
              'TempoReal': 9.000530785562633,
              'OEE': 69.1454856401486,
              'Operador': 'Bruna Khaler Borella',
              'Turno': null
            },
            {
               'idx': 4,
              'PostoNome': 'MAQ 1',
              'NumeroOrdem': 2075,
              'DescricaoOrdem': 'TRATOR AGRO - VERMELHO',
              'Item': 'sem',
              'DataInicial': '2023-04-24T13:00:13',
              'DataFinal': '2023-04-24T14:48:32.45',
              'TempoOrdem': 6499,
              'TempoEventos': 0,
              'TempoEventosNP': 0,
              'TempoEventosP': 0,
              'Produzido': 820,
              'Refugado': 4,
              'TempoProduzido': 5125,
              'Disponibilidade': 100.0,
              'Eficiencia': 78.85828589013695,
              'Qualidade': 99.51219512195122,
              'TempoTeorico': 6.25,
              'TempoReal': 7.925609756097561,
              'OEE': 78.47361132481922,
              'Operador': 'Jocelaine dos Santos Pedroso',
              'Turno': null
            }]";

            var jsonEventos = @"[
                {
                    'idx': 1,
                    'PostoNome': 'MAQ 1',
                    'EventoID': 104,
                    'DescricaoEvento': 'Maquina Parada',
                    'TipoID': 1,
                    'DescricaoTipo': 'Sistema',
                    'CodigoTipo': 'S',
                    'EventoLogID': 825378,
                    'Data': '2023-04-24T11:58:54',
                    'Tempo': 17,
                    'BgCor': 'red',
                    'FtCor': 'WHITE',
                    'Sequencia': 0,
                    'TempoPrevisto': 0,
                    'IdEventoTempoPrevisto': 0,
                    'Turno': 'Sem Turno'
                },
                {
                    'idx': 2,
                    'PostoNome': 'MAQ 1',
                    'EventoID': 104,
                    'DescricaoEvento': 'Maquina Parada',
                    'TipoID': 1,
                    'DescricaoTipo': 'Sistema',
                    'CodigoTipo': 'S',
                    'EventoLogID': 825207,
                    'Data': '2023-04-24T09:57:55',
                    'Tempo': 12,
                    'BgCor': 'red',
                    'FtCor': 'WHITE',
                    'Sequencia': 0,
                    'TempoPrevisto': 0,
                    'IdEventoTempoPrevisto': 0,
                    'Turno': 'Sem Turno'
                },
                {
                    'idx': 3,
                    'PostoNome': 'MAQ 1',
                    'EventoID': 105,
                    'DescricaoEvento': 'Em Operacao',
                    'TipoID': 1,
                    'DescricaoTipo': 'Sistema',
                    'CodigoTipo': 'S',
                    'EventoLogID': 825206,
                    'Data': '2023-04-24T09:57:54',
                    'Tempo': 2,
                    'BgCor': 'green',
                    'FtCor': 'white',
                    'Sequencia': 1,
                    'TempoPrevisto': 60,
                    'Turno': 'Sem Turno'
                },
                {
                    'idx': 4,
                    'PostoNome': 'MAQ 1',
                    'EventoID': 105,
                    'DescricaoEvento': 'Em Operacao',
                    'TipoID': 1,
                    'DescricaoTipo': 'Sistema',
                    'CodigoTipo': 'S',
                    'EventoLogID': 825208,
                    'Data': '2023-04-24T09:58:06',
                    'Tempo': 7248,
                    'BgCor': 'green',
                    'FtCor': 'white',
                    'Sequencia': 1,
                    'TempoPrevisto': 60,
                    'Turno': 'Sem Turno'
                },
                {
                    'idx': 5,
                    'PostoNome': 'MAQ 1',
                    'EventoID': 105,
                    'DescricaoEvento': 'Em Operacao',
                    'TipoID': 1,
                    'DescricaoTipo': 'Sistema',
                    'CodigoTipo': 'S',
                    'EventoLogID': 825124,
                    'Data': '2023-04-24T09:10:41',
                    'Tempo': 2733,
                    'BgCor': 'green',
                    'FtCor': 'white',
                    'Sequencia': 1,
                    'TempoPrevisto': 60,
                    'Turno': 'Sem Turno'
                },
                {
                    'idx': 6,
                    'PostoNome': 'MAQ 1',
                    'EventoID': 105,
                    'DescricaoEvento': 'Em Operacao',
                    'TipoID': 1,
                    'DescricaoTipo': 'Sistema',
                    'CodigoTipo': 'S',
                    'EventoLogID': 825078,
                    'Data': '2023-04-24T08:34:31',
                    'Tempo': 1977,
                    'BgCor': 'green',
                    'FtCor': 'white',
                    'Sequencia': 1,
                    'TempoPrevisto': 60,
                    'Turno': 'Sem Turno'
                },
                {
                    'idx': 7,
                    'PostoNome': 'MAQ 1',
                    'EventoID': 125,
                    'DescricaoEvento': 'Intervalo',
                    'TipoID': 2,
                    'DescricaoTipo': 'Programada',
                    'CodigoTipo': 'P',
                    'EventoLogID': 825380,
                    'Data': '2023-04-24T11:59:11',
                    'Tempo': 3662,
                    'BgCor': 'Yellow',
                    'FtCor': 'black',
                    'Sequencia': 21,
                    'TempoPrevisto': 0,
                    'Turno': 'Sem Turno'
                },
                {
                    'idx': 8,
                    'PostoNome': 'MAQ 1',
                    'EventoID': 126,
                    'DescricaoEvento': 'Bico Trancado',
                    'TipoID': 3,
                    'DescricaoTipo': 'Nao Programada',
                    'CodigoTipo': 'NP',
                    'EventoLogID': 825077,
                    'Data': '2023-04-24T08:34:26',
                    'Tempo': 5,
                    'BgCor': 'red',
                    'FtCor': 'Black',
                    'Sequencia': 22,
                    'TempoPrevisto': 0,
                    'Turno': 'Sem Turno'
                },
                {
                    'idx': 9,
                    'PostoNome': 'MAQ 1',
                    'EventoID': 128,
                    'DescricaoEvento': 'Ajuste Maquina',
                    'TipoID': 3,
                    'DescricaoTipo': 'Nao Programada',
                    'CodigoTipo': 'NP',
                    'EventoLogID': 825121,
                    'Data': '2023-04-24T09:07:28',
                    'Tempo': 193,
                    'BgCor': 'ORANGE',
                    'FtCor': 'Black',
                    'Sequencia': 24,
                    'TempoPrevisto': 0,
                    'Turno': 'Sem Turno'
                },
                {
                    'idx': 10,
                    'PostoNome': 'MAQ 1',
                    'EventoID': 128,
                    'DescricaoEvento': 'Ajuste Maquina',
                    'TipoID': 3,
                    'DescricaoTipo': 'Nao Programada',
                    'CodigoTipo': 'NP',
                    'EventoLogID': 825204,
                    'Data': '2023-04-24T09:56:14',
                    'Tempo': 100,
                    'BgCor': 'ORANGE',
                    'FtCor': 'Black',
                    'Sequencia': 24,
                    'TempoPrevisto': 0,
                    'Turno': 'Sem Turno'
                },
                {
                    'idx': 11,
                    'PostoNome': 'MAQ 1',
                    'EventoID': 115,
                    'DescricaoEvento': 'Aquecimento da Injetora',
                    'TipoID': 3,
                    'DescricaoTipo': 'Nao Programada',
                    'CodigoTipo': 'NP',
                    'EventoLogID': 824981,
                    'Data': '2023-04-24T08:17:36',
                    'Tempo': 1010,
                    'BgCor': 'Yellow',
                    'Sequencia': 12,
                    'TempoPrevisto': 0,
                    'Turno': 'Sem Turno'
                }
            ]";

            var model = JsonConvert.DeserializeObject<List<OEEOrdem>>(jsonOrdems);

            var eventos = JsonConvert.DeserializeObject<List<FunEventos>>(jsonEventos);

            model[0].Eventos = eventos;

            return View(model);
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

//,
//            {
//    'idx': 4,
//              'PostoNome': null,
//              'NumeroOrdem': 2075,
//              'DescricaoOrdem': 'Total da ordem',
//              'Item': 'sem',
//              'DataInicial': '2023-04-24T07:30:00',
//              'DataFinal': '2023-04-24T14:48:32.45',
//              'TempoOrdem': 306731,
//              'TempoEventos': 68852,
//              'TempoEventosNP': 507,
//              'TempoEventosP': 68345,
//              'Produzido': 3252,
//              'Refugado': 25,
//              'TempoProduzido': 20325,
//              'Disponibilidade': 99.78731972515165,
//              'Eficiencia': 8.544259896838309,
//              'Qualidade': 99.23124231242313,
//              'TempoTeorico': 6.25,
//              'TempoReal': 73.14852398523985,
//              'OEE': 8.460542984906834,
//              'Operador': '',
//              'Turno': null
//            }

