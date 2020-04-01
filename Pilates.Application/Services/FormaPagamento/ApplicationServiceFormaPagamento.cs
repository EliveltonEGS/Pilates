using Pilates.Adapter.Map.CadastroBaseFormaPagamento;
using Pilates.DTO.DTO;
using Pilates.Service.Services.CadastroBase.CadastroBaseFormaPagamento;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Application.Services.FormaPagamento
{
    public class ApplicationServiceFormaPagamento : IApplicationServiceFormaPagamento
    {

        private readonly IServiceFormaPagamento _serviceFormaPagamento;
        private readonly IMapperFormaPagamento _mapperFormaPagamento;

        public ApplicationServiceFormaPagamento(
            IServiceFormaPagamento serviceFormaPagamento,
            IMapperFormaPagamento mapperFormaPagamento)
        {
            _serviceFormaPagamento = serviceFormaPagamento;
            _mapperFormaPagamento = mapperFormaPagamento;
        }

        public void DeleteById(Guid id)
        {
            _serviceFormaPagamento.DeleteById(id);
        }

        public async Task<IEnumerable<FormaPagamentoDTO>> GetAll()
        {
            return await _mapperFormaPagamento.MapperListFormaPagamentos(_serviceFormaPagamento.GetAll());
        }

        public FormaPagamentoDTO GetById(Guid id)
        {
            return _mapperFormaPagamento.MapperToDTO(_serviceFormaPagamento.GetById(id));
        }

        public void Save(FormaPagamentoDTO input)
        {
            _serviceFormaPagamento.Save(_mapperFormaPagamento.MapperToEntity(input));
        }

        public void Update(FormaPagamentoDTO input)
        {
            _serviceFormaPagamento.Update(_mapperFormaPagamento.MapperToEntity(input));
        }
    }
}
