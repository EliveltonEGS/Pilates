using Microsoft.AspNetCore.Mvc;
using System;

namespace Pilates.WebApi.Controllers.Cadastros
{
    [ApiController]
    public abstract class GenericController<TEntity> : ControllerBase where TEntity : class
    {
        public abstract ActionResult<TEntity> Delete(Guid id);
        public abstract ActionResult<TEntity> GetAll();
        public abstract ActionResult<TEntity> GetById(Guid id);
        public abstract ActionResult<TEntity> Post([FromBody] TEntity input);
        public abstract ActionResult<TEntity> Put(Guid id, [FromBody] TEntity input);
    }
}
