using BackEndWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BackEndWebApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PersonaController : ControllerBase
    {

        // CRUD ---> CREATE READ UPDATE DELETE



        //Simula il database.. . . . .
        public static List<Persona> persone = new List<Persona>
        {

             new Persona{Id = 1 , Nome ="mario" , Cognome="rossi" , Age= 20 },
             new Persona{Id = 2 , Nome ="luigi" , Cognome="bianchi" , Age= 18 },
             new Persona{Id = 3,  Nome ="pietro" , Cognome="nerini" , Age= 25 }

        };


        
        [HttpGet(Name = "GetPersone")]
        public IEnumerable<Persona> Get()
        {

            return persone;
        }

       

        [HttpPost]
        public async Task<IActionResult> AddPersona(Persona persona)
        {
            persone.Add(persona);
            return Ok(persona);
        }


        [HttpPut]
        public async Task<ActionResult<List<Persona>>> UpdatePerson(int id , Persona personaInput)
        {


            
            var personTmp = persone.Find(x => x.Id == id);

            

            if(personTmp is null)
            {
                return NotFound("id non presente nel vettore");
            }

            //personTmp.Id = personaInput.Id;
            personTmp.Nome = personaInput.Nome;
            personTmp.Cognome = personaInput.Cognome;
            personTmp.Age = personaInput.Age;

            

            return Ok(persone);
        }



        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {

            var personaTmp = persone.Find(x => x.Id == id);

            if(personaTmp is null)
            {
                return NotFound("Nulla da eliminare");

            }

            persone.Remove(personaTmp);

            return Ok(persone);

        }

       
    }
}
