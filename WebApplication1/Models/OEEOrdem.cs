namespace WebApplication1.Models {
    public class OEEOrdem {
        public int idx { get; set; }
        public string PostoNome { get; set; }
        public long NumeroOrdem { get; set; }
        public string DescricaoOrdem { get; set; }

        public string Item { get; set; }

        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }

        public int TempoOrdem { get; set; }

        public int TempoEventos { get; set; }
        
        public int TempoEventosNP { get; set; }

        public int TempoEventosP { get; set; }

        public int Produzido { get; set; }

        public int Refugado { get; set; }
        
        public int TempoProduzido { get; set; }

        public double Disponibilidade { get; set; }

        public double Eficiencia { get; set; }

        public double Qualidade { get; set; }

        public double OEE { get; set; }

        public double TempoTeorico { get; set; }

        public double TempoReal { get; set; }

        public string? Operador { get; set; }

        public List<FunEventos> Eventos { get; set; } = new List<FunEventos> { };

    }
}
