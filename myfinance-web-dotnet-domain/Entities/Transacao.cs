﻿namespace myfinance_web_dotnet_domain.Entities
{
    public class Transacao
    {
        public int? Id { get; set; }
        public string Historico { get; set; }
        public DateTimeOffset Data { get; set; }
        public decimal Valor { get; set; }
        public int PlanoContaId { get; set; }
        public required PlanoConta PlanoConta { get; set; }
    }
}