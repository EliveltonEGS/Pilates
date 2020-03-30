﻿using System;

namespace Pilates.DTO.DTO
{
    public class PessoaDTO : EntityBaseDTO
    {
        public string Nome { get; set; }
        public DateTime DataNasimento { get; set; }
        public string Sexo { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Telefone { get; set; }
    }
}
