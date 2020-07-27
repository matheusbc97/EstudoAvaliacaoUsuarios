using System;
using System.Linq;
using System.Net;
using System.Web.Http;
using AvaliacaoUsuarios.Models;

namespace AvaliacaoUsuarios.Controllers
{
    public class UserController : ApiController
    {
        private AvaliacaoUsuariosContext db = new AvaliacaoUsuariosContext(); 
        // GET: api/User
        public IHttpActionResult Get()
        {
            var users = db.Users;

            return Ok(users);
        }

        // GET: api/User/5
        public IHttpActionResult Get(int id)
        {
            if (id <= 0)
                return BadRequest("O id deve ser um número maior que zero");

            var user = db.Users.Find(id);

            return Ok(user);
        }

        // POST: api/User
        public IHttpActionResult Post(User user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            user.CreatedAt = DateTime.Now;

            db.Users.Add(user);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = user.Id }, user);
        }

        // PUT: api/User/5
        public IHttpActionResult Put(int id, UserUpdates userUpdates)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != userUpdates.Id)
                BadRequest("O id informado na url é diferente do informado no corpo da requisição");

            if (db.Users.Count(c => c.Id == id) == 0)
                return NotFound();

            var user = db.Users.Find(id);

            if(userUpdates.Name != null)
                user.Name = userUpdates.Name;

            if (userUpdates.Email != null)
                user.Email = userUpdates.Email;

            if (userUpdates.Description != null)
                user.Description = userUpdates.Description;

            if (userUpdates.Avaliation != null)
                user.Avaliation = userUpdates.Avaliation;

            db.Entry(user).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // DELETE: api/User/5
        public IHttpActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("O id deve ser um número maior que zero");

            var user = db.Users.Find(id);

            if (user == null)
                return NotFound();

            db.Users.Remove(user);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
