using Pilates.DTO.DTO;
using Pilates.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Adapter.Map.CadastroBaseProfessor
{
    public class MapperProfessor : IMapperProfessor
    {

        List<ProfessorDTO> professorDTOs = new List<ProfessorDTO>();

        public async Task<IEnumerable<ProfessorDTO>> MapperListProfessor(Task<IEnumerable<Professor>> professor)
        {
            foreach (var item in await professor)
            {
                ProfessorDTO professorDTO = new ProfessorDTO()
                {
                    ProfessorId = item.ProfessorId,
                    Celular = item.Celular,
                    Cpf = item.Cpf,
                    DataNasimento = item.DataNasimento,
                    Email = item.Email,
                    Nome = item.Nome,
                    Rg = item.Rg,
                    Sexo = item.Sexo,
                    Telefone = item.Telefone,
                    EspecialidadeId = item.EspecialidadeId,
                    EnderecoId = item.EnderecoId
                };

                professorDTOs.Add(professorDTO);
            }

            return professorDTOs;
        }

        public ProfessorDTO MapperToDTO(Professor professor)
        {
            ProfessorDTO professorDTO = new ProfessorDTO()
            {
                ProfessorId = professor.ProfessorId,
                Celular = professor.Celular,
                Cpf = professor.Cpf,
                DataNasimento = professor.DataNasimento,
                Email = professor.Email,
                Nome = professor.Nome,
                Rg = professor.Rg,
                Sexo = professor.Sexo,
                Telefone = professor.Telefone,
                EspecialidadeId = professor.EspecialidadeId,
                EnderecoId = professor.EnderecoId
            };

            return professorDTO;
        }

        public Professor MapperToEntity(ProfessorDTO professorDTO)
        {
            Professor professor = new Professor()
            {
                ProfessorId = professorDTO.ProfessorId,
                Celular = professorDTO.Celular,
                Cpf = professorDTO.Cpf,
                DataNasimento = professorDTO.DataNasimento,
                Email = professorDTO.Email,
                Nome = professorDTO.Nome,
                Rg = professorDTO.Rg,
                Sexo = professorDTO.Sexo,
                Telefone = professorDTO.Telefone,
                EspecialidadeId = professorDTO.EspecialidadeId,
                EnderecoId = professorDTO.EnderecoId
            };

            return professor;
        }
    }
}
