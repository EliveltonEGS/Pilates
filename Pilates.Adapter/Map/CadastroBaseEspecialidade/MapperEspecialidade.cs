using Pilates.DTO.DTO;
using Pilates.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Adapter.Map.CadastroBaseEspecialidade
{ 
    public class MapperEspecialidade : IMapperEspecialidade
    { 

        List<EspecialidadeDTO> especialidadeDTOs = new List<EspecialidadeDTO>();

        public async Task<IEnumerable<EspecialidadeDTO>> MapperListEspecialidades(Task<IEnumerable<Especialidade>> especialidades)
        {
            foreach (var item in await especialidades)
            {
                EspecialidadeDTO especialidadeDTO = new EspecialidadeDTO()
                {
                    EspecialidadeId = item.EspecialidadeId,
                   Descricao = item.Descricao
                };

                especialidadeDTOs.Add(especialidadeDTO);
            }

            return especialidadeDTOs;
        }

        public EspecialidadeDTO MapperToDTO(Especialidade especialidade)
        {
            EspecialidadeDTO especialidadeDTO = new EspecialidadeDTO()
            {
                EspecialidadeId = especialidade.EspecialidadeId,
                Descricao = especialidade.Descricao
            };

            return especialidadeDTO;
        }

        public Especialidade MapperToEntity(EspecialidadeDTO especialidadeDTO)
        {
            Especialidade especialidade = new Especialidade()
            {
                EspecialidadeId = especialidadeDTO.EspecialidadeId,
                Descricao = especialidadeDTO.Descricao
            };

            return especialidade;
        }
    }
}
