﻿using Pilates.DTO.DTO;
using Pilates.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Adapter.Map.CadastroBaseEspecialidade
{ 
    public class MapperAula : IMapperExercicio
    { 

        List<EspecialidadeDTO> especialidadeDTOs = new List<EspecialidadeDTO>();

        public async Task<IEnumerable<EspecialidadeDTO>> MapperListEspecialidades(Task<IEnumerable<Especialidade>> especialidades)
        {
            foreach (var item in await especialidades)
            {
                EspecialidadeDTO especialidadeDTO = new EspecialidadeDTO()
                {
                    Id = item.Id,
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
                Id = especialidade.Id,
                Descricao = especialidade.Descricao
            };

            return especialidadeDTO;
        }

        public Especialidade MapperToEntity(EspecialidadeDTO especialidadeDTO)
        {
            Especialidade especialidade = new Especialidade()
            {
                Id = especialidadeDTO.Id,
                Descricao = especialidadeDTO.Descricao
            };

            return especialidade;
        }
    }
}