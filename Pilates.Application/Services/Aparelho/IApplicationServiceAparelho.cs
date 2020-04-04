using Pilates.DTO.DTO;
using System;
using System.Collections.Generic;

namespace Pilates.Application.Services.Aparelho
{
    public interface IApplicationServiceAparelho
    {
        IEnumerable<AparelhoDTO> GetAll();
        void Update(AparelhoDTO input);
        void DeleteById(Guid id);
        AparelhoDTO GetById(Guid id);
        void Save(AparelhoDTO input);
    }
}
