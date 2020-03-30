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
                    Id = item.Id,
                    DataAula = item.DataAula,
                    DiaDisponivel = item.DiaDisponivel,
                    QuantidadeAulaPorSemana = item.QuantidadeAulaPorSemana,
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
                Id = agenda.Id,
                DataAula = agenda.DataAula,
                DiaDisponivel = agenda.DiaDisponivel,
                QuantidadeAulaPorSemana = agenda.QuantidadeAulaPorSemana,
                AulaId = agenda.AulaId
            };

            return agendaDTO;
        }

        public Agenda MapperToEntity(AgendaDTO agendaDTO)
        {
            Agenda agenda = new Agenda()
            {
                Id = agendaDTO.Id,
                DataAula = agendaDTO.DataAula,
                DiaDisponivel = agendaDTO.DiaDisponivel,
                QuantidadeAulaPorSemana = agendaDTO.QuantidadeAulaPorSemana,
                AulaId = agendaDTO.AulaId
            };

            return agenda;
        }
    }
}
