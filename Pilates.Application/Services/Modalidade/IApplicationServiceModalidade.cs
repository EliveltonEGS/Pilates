using Pilates.DTO.DTO;
using System;
using System.Collections.Generic;

namespace Pilates.Application.Services.Modalidade
{
    public interface IApplicationServiceModalidade
    {
        IEnumerable<ModalidadeDTO> GetAll();
        void Update(ModalidadeDTO input);
        void DeleteById(Guid id);
        ModalidadeDTO GetById(Guid id);
        void Save(ModalidadeDTO input);

    }
}
