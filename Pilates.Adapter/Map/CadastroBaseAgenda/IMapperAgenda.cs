using Pilates.DTO.DTO;
using Pilates.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Adapter.Map.CadastroBaseAgenda
{
    public interface IMapperAgenda
    {
        Agenda MapperToEntity(AgendaDTO agendaDTO);
        Task<IEnumerable<AgendaDTO>> MapperListAgendas(Task<IEnumerable<Agenda>> agendas);
        AgendaDTO MapperToDTO(Agenda agenda);
    }
}
