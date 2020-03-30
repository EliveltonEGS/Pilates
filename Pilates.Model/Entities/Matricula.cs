﻿using System;

namespace Pilates.Model.Entities
{
    public class Matricula : EntityBase
    {
        public Decimal ValorMatricula { get; set; }
        public DateTime DataVencimentoMatricula { get; set; }
        public Decimal ValorMensalidade { get; set; }
        public DateTime DataVencimentoMensalidade { get; set; }
        public Guid SalaId { get; set; }
        public Sala Sala { get; set; }
        public Guid FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
    }
}