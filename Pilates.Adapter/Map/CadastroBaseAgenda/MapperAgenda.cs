using Pilates.DTO.DTO;
using Pilates.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Adapter.Map.CadastroBaseAgenda
{
    public class MapperAgenda : IMapperAgenda
    {

        List<AgendaDTO> agendaDTOs = new List<AgendaDTO>();

        public async Task<IEnumerable<AgendaDTO>> MapperListAgendas(Task<IEnumerable<Agenda>> agendas)
        {
            foreach (var item in await agendas)
            {
                AgendaDTO agendaDTO = new AgendaDTO()
                {
                    AgendaId = item.AngendaId,
                    DataAula = item.DataAula,
                    DiaDisponivel = item.DiaDisponivel,
                    ProessorId = item.ProfessorId,
                    AulaId = item.AulaId
                };

                agendaDTOs.Add(agendaDTO);
            }

            return agendaDTOs;
        }

        public AgendaDTO MapperToDTO(Agenda agenda)
        {
            AgendaDTO agendaDTO = new AgendaDTO()
            {
                AgendaId = agenda.AngendaId,
                DataAula = agenda.DataAula,
                DiaDisponivel = agenda.DiaDisponivel,
                ProessorId = agenda.ProfessorId,
                AulaId = agenda.AulaId
            };

            return agendaDTO;
        }

        public Agenda MapperToEntity(AgendaDTO agendaDTO)
        {
            Agenda agenda = new Agenda()
            {
                AngendaId = agendaDTO.AgendaId,
                DataAula = agendaDTO.DataAula,
                DiaDisponivel = agendaDTO.DiaDisponivel,
                ProfessorId = agendaDTO.ProessorId,
                AulaId = agendaDTO.AulaId
            };

            return agenda;
        }
    }
}
