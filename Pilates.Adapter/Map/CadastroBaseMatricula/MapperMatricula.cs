using Pilates.DTO.DTO;
using Pilates.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pilates.Adapter.Map.CadastroBaseMatricula
{
    public class MapperMatricula : IMapperMatricula
    {

        List<MatriculaDTO> matriculaDTOs = new List<MatriculaDTO>();

        public async Task<IEnumerable<MatriculaDTO>> MapperListMatriculas(Task<IEnumerable<Matricula>> matriculas)
        {
            foreach (var item in await matriculas)
            {
                MatriculaDTO matriculaDTO = new MatriculaDTO()
                {
                    Id = item.Id,
                    DataVencimentoMatricula = item.DataVencimentoMatricula,
                    DataVencimentoMensalidade = item.DataVencimentoMensalidade,
                    FormaPagamentoId = item.FormaPagamentoId,
                    SalaId = item.SalaId,
                    ValorMatricula = item.ValorMatricula,
                    ValorMensalidade = item.ValorMensalidade
                };

                matriculaDTOs.Add(matriculaDTO);
            }

            return matriculaDTOs;
        }

        public MatriculaDTO MapperToDTO(Matricula matricula)
        {
            MatriculaDTO matriculaDTO = new MatriculaDTO()
            {
                Id = matricula.Id,
                DataVencimentoMatricula = matricula.DataVencimentoMatricula,
                DataVencimentoMensalidade = matricula.DataVencimentoMensalidade,
                FormaPagamentoId = matricula.FormaPagamentoId,
                SalaId = matricula.SalaId,
                ValorMatricula = matricula.ValorMatricula,
                ValorMensalidade = matricula.ValorMensalidade
            };

            return matriculaDTO;
        }

        public Matricula MapperToEntity(MatriculaDTO matriculaDTO)
        {
            Matricula matricula = new Matricula()
            {
                Id = matriculaDTO.Id,
                DataVencimentoMatricula = matriculaDTO.DataVencimentoMatricula,
                DataVencimentoMensalidade = matriculaDTO.DataVencimentoMensalidade,
                FormaPagamentoId = matriculaDTO.FormaPagamentoId,
                SalaId = matriculaDTO.SalaId,
                ValorMatricula = matriculaDTO.ValorMatricula,
                ValorMensalidade = matriculaDTO.ValorMensalidade
            };

            return matricula;
        }
    }
}
