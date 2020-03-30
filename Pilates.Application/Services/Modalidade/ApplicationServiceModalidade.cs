using Pilates.Adapter.Map.CadastroBaseModalidade;
using Pilates.DTO.DTO;
using Pilates.Service.Services.CadastroBase.CadastroBaseModalidade;
using System;
using System.Collections.Generic;

namespace Pilates.Application.Services.Modalidade
{
    public class ApplicationServiceModalidade : IApplicationServiceModalidade
    {

        private readonly IServiceModalidade _serviceModalidade;
        private readonly IMapperModalidade _mapperModalidade;

        public ApplicationServiceModalidade(
            IServiceModalidade serviceModalidade,
            IMapperModalidade mapperModalidade)
        {
            _serviceModalidade = serviceModalidade;
            _mapperModalidade = mapperModalidade;
        }

        public void DeleteById(Guid id)
        {
            _serviceModalidade.DeleteById(id);
        }

        public IEnumerable<ModalidadeDTO> GetAll()
        {
            /*List<ModalidadeDTO> modalidadeDTOs = new List<ModalidadeDTO>();

            foreach (var item in _serviceModalidade.GetAll())
            {
                ModalidadeDTO modalidadeDTO = new ModalidadeDTO()
                {
                    Id = item.Id,
                    Descricao = item.Descricao
                };

                modalidadeDTOs.Add(modalidadeDTO);
            }

            return modalidadeDTOs;*/

            return _mapperModalidade.MapperListModalidades(_serviceModalidade.GetAll());
        }

        public ModalidadeDTO GetById(Guid id)
        {
            return _mapperModalidade.MapperToDTO(_serviceModalidade.GetById(id));
        }

        public void Save(ModalidadeDTO input)
        {
            _serviceModalidade.Save(_mapperModalidade.MapperToEntity(input));
        }

        public void Update(ModalidadeDTO input)
        {
            _serviceModalidade.Update(_mapperModalidade.MapperToEntity(input));
        }
    }
}
