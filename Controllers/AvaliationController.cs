using System;
using System.Linq;
using System.Net;
using System.Web.Http;
using AvaliacaoUsuarios.Dtos;
using AvaliacaoUsuarios.Models;

namespace AvaliacaoUsuarios.Controllers
{
    public class AvaliationController : ApiController
    {
        private AvaliacaoUsuariosContext db = new AvaliacaoUsuariosContext();
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            var avaliations = db.Avaliations;

            return Ok(avaliations);
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody] Avaliation avaliation)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            avaliation.CreatedAt = DateTime.Now;

            db.Avaliations.Add(avaliation);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = avaliation.Id }, avaliation);
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]AvaliationUpdates avaliationUpdates)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != avaliationUpdates.Id)
                BadRequest("O id informado na url é diferente do informado no corpo da requisição");

            if (db.Avaliations.Count(c => c.Id == id) == 0)
                return NotFound();

            var avaliation = db.Avaliations.Find(id);

            avaliation.Description = avaliationUpdates.Description;
            avaliation.Value = avaliationUpdates.Value;

            db.Entry(avaliation).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("O id deve ser um número maior que zero");

            var avaliation = db.Avaliations.Find(id);

            if (avaliation == null)
                return NotFound();

            db.Avaliations.Remove(avaliation);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}