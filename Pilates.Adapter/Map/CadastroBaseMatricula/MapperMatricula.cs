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
                    MatriculaId = item.MatriculaId,
                    DataVencimentoMatricula = item.DataVencimentoMatricula,
                    DataVencimentoMensalidade = item.DataVencimentoMensalidade,
                    FormaPagamentoId = item.FormaPagamentoId,
                    SalaId = item.SalaId,
                    ValorMatricula = item.ValorMatricula,
                    ValorMensalidade = item.ValorMensalidade,
                    AlunoId = item.AulaId,
                    AulaId = item.AulaId
                };

                matriculaDTOs.Add(matriculaDTO);
            }

            return matriculaDTOs;
        }

        public MatriculaDTO MapperToDTO(Matricula matricula)
        {
            MatriculaDTO matriculaDTO = new MatriculaDTO()
            {
                MatriculaId = matricula.MatriculaId,
                DataVencimentoMatricula = matricula.DataVencimentoMatricula,
                DataVencimentoMensalidade = matricula.DataVencimentoMensalidade,
                FormaPagamentoId = matricula.FormaPagamentoId,
                SalaId = matricula.SalaId,
                ValorMatricula = matricula.ValorMatricula,
                ValorMensalidade = matricula.ValorMensalidade,
                AlunoId = matricula.AulaId,
                AulaId = matricula.AulaId
            };

            return matriculaDTO;
        }

        public Matricula MapperToEntity(MatriculaDTO matriculaDTO)
        {
            Matricula matricula = new Matricula()
            {
                MatriculaId = matriculaDTO.MatriculaId,
                DataVencimentoMatricula = matriculaDTO.DataVencimentoMatricula,
                DataVencimentoMensalidade = matriculaDTO.DataVencimentoMensalidade,
                FormaPagamentoId = matriculaDTO.FormaPagamentoId,
                SalaId = matriculaDTO.SalaId,
                ValorMatricula = matriculaDTO.ValorMatricula,
                ValorMensalidade = matriculaDTO.ValorMensalidade,
                AlunoId = matriculaDTO.AulaId,
                AulaId = matriculaDTO.AulaId
            };

            return matricula;
        }
    }
}
