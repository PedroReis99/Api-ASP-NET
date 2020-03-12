using ApiLinx.API.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiLinx.API.Data;
using Microsoft.AspNetCore.Cors;

namespace ApiLinx.API.Controller
{
    [EnableCors("AllowSpecificOrigin")]
    [ApiController]
    [Route("")]
    public class ControleItem :ControllerBase
    {
 
        [HttpGet]
        [Route("insert/produto")]

        public async Task<ActionResult<List<ProdutoUpload>>> Get([FromServices] Data.DataContext context)
        {
            var produto = await context.Produtos.ToListAsync();
            return produto;
        }

        [HttpPost]
        [Route("request/produto")]

        public async Task<ActionResult<ProdutoUpload>> Post(
            [FromServices] DataContext context,
            [FromBody] ProdutoUpload model)
        {
            if (ModelState.IsValid)
            {
                context.Produtos.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
