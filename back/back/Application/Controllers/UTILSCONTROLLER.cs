using System.Collections.Generic;
using back.data.entities.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.BaseControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UTILSCONTROLLER : ControllerBase
    {
        private string stringToModel(string model, string p)
        {
            return $"modelBuilder.Entity<{model.ToUpper()}>().Property(p => p.{p.ToLower()}).HasColumnName('{p.ToUpper()}')";
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult<List<string>> convertArrayToModelRelation(ArrayToModelData req)
        {

            List<string> result = new List<string>();

            req.data.ForEach(x =>
            {
                result.Add(stringToModel(req.model, x));
            });
            return Ok(result);
        }
    }
}


// let b=(model,p,c)=>`modelBuilder.Entity<${model}>().Property(p => p.${p}).HasColumnName("${c}")`;

