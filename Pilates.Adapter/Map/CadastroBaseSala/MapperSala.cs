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
                    Id = item.Id,
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
                Id = sala.Id,
                Descricao = sala.Descricao
            };

            return salaDTO;
        }

        public Sala MapperToEntity(SalaDTO salaDTO)
        {
            Sala sala = new Sala()
            {
                Id = salaDTO.Id,
                Descricao = salaDTO.Descricao
            };

            return sala;
        }
    }
}
