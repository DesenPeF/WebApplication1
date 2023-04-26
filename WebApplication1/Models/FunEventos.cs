namespace WebApplication1.Models {
    public class FunEventos {
        public string PostoNome { get; set; }
        public string DescricaoEvento { get; set; }

        public DateTime Data { get; set; }

        public int Tempo { get; set; }

        public string BgCor { get; set; }
        public string FtCor { get; set; }

        public int EventoID { get; set; }

        public string DescricaoTipo { get; set; }

        public string CodigoTipo { get; set; }

        public int? Sequencia { get; set; }

        public int? TempoPrevisto { get; set; }

        public int? IdEventoTempoPrevisto { get; set; }
        public string Turno { get; set; }
    }
}
