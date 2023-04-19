using System;
namespace AppConDataBaseSqlLite
{
	public class Persona
	{

		public int Id { get; set; }
        public String Nome { get; set; }
        public String Cognome { get; set; }


        public Persona()
        {
            this.Id = 0;
            this.Nome = "Mario";
            this.Cognome = "rossi";
        }


        public override string ToString()
        {
            return this.Id + " " + this.Nome + " " + this.Cognome;
        }
    }
}

