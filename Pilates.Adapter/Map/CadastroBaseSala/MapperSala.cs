using Pilates.DTO.DTO;
using Pilates.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Adapter.Map.CadastroBaseSala
{
    public class MapperSala : IMapperSala
    {
        List<SalaDTO> salaDTOs = new List<SalaDTO>();

        public async Task<IEnumerable<SalaDTO>> MapperListSalas(Task<IEnumerable<Sala>> sala)
        {
            foreach (var item in await sala)
            {
                SalaDTO salaDTO = new SalaDTO()
                {
                    SalaId = item.SalaId,
                    Descricao = item.Descricao
                };

                salaDTOs.Add(salaDTO);
            }

            return salaDTOs;
        }

        public SalaDTO MapperToDTO(Sala sala)
        {
            SalaDTO salaDTO = new SalaDTO()
            {
                SalaId = sala.SalaId,
                Descricao = sala.Descricao
            };

            return salaDTO;
        }

        public Sala MapperToEntity(SalaDTO salaDTO)
        {
            Sala sala = new Sala()
            {
                SalaId = salaDTO.SalaId,
                Descricao = salaDTO.Descricao
            };

            return sala;
        }
    }
}
