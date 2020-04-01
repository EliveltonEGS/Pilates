using Pilates.DTO.DTO;
using Pilates.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Adapter.Map.CadastroBaseSala
{
    public interface IMapperSala
    {
        Sala MapperToEntity(SalaDTO salaDTO);
        Task<IEnumerable<SalaDTO>> MapperListSalas(Task<IEnumerable<Sala>> sala);
        SalaDTO MapperToDTO(Sala sala);
    }
}
