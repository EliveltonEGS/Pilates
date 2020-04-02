using Pilates.DTO.DTO;
using Pilates.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Adapter.Map.CadastroBaseAluno
{
    public class MapperAluno : IMapperAluno
    {
        List<AlunoDTO> alunoDTOs = new List<AlunoDTO>();

        public async Task<IEnumerable<AlunoDTO>> MapperListAlunos(Task<IEnumerable<Aluno>> alunos)
        {
            foreach (var item in await alunos)
            {
                AlunoDTO alunoDTO = new AlunoDTO()
                {
                    AlunoId = item.AlunoId,
                    NomeResponsavel = item.NomeResponsavel,
                    EnderecoId = item.EnderecoId,
                    ComoConheceu = item.ComoConheceu,
                    Nome = item.Nome,
                    DataNasimento = item.DataNasimento,
                    Sexo = item.Sexo,
                    Cpf = item.Cpf,
                    Rg = item.Rg,
                    Email = item.Email,
                    Celular = item.Celular,
                    Telefone = item.Telefone
                };

                alunoDTOs.Add(alunoDTO);
            }

            return alunoDTOs;
        }

        public AlunoDTO MapperToDTO(Aluno aluno)
        {
            AlunoDTO alunoDTO = new AlunoDTO()
            {
                AlunoId = aluno.AlunoId,
                NomeResponsavel = aluno.NomeResponsavel,
                EnderecoId = aluno.EnderecoId,
                ComoConheceu = aluno.ComoConheceu,
                Nome = aluno.Nome,
                DataNasimento = aluno.DataNasimento,
                Sexo = aluno.Sexo,
                Cpf = aluno.Cpf,
                Rg = aluno.Rg,
                Email = aluno.Email,
                Celular = aluno.Celular,
                Telefone = aluno.Telefone
            };
            return alunoDTO;
        }

        public Aluno MapperToEntity(AlunoDTO alunoDTO)
        {
            Aluno aluno = new Aluno()
            {
                AlunoId = alunoDTO.AlunoId,
                NomeResponsavel = alunoDTO.NomeResponsavel,
                EnderecoId = alunoDTO.EnderecoId,
                ComoConheceu = alunoDTO.ComoConheceu,
                Nome = alunoDTO.Nome,
                DataNasimento = alunoDTO.DataNasimento,
                Sexo = alunoDTO.Sexo,
                Cpf = alunoDTO.Cpf,
                Rg = alunoDTO.Rg,
                Email = alunoDTO.Email,
                Celular = alunoDTO.Celular,
                Telefone = alunoDTO.Telefone
            };

            return aluno;
        }
    }
}
