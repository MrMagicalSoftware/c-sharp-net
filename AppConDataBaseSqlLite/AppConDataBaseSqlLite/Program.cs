
using System.Linq;
using System.Reflection.Metadata;
using AppConDataBaseSqlLite;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Documentazione :
//https://learn.microsoft.com/it-it/ef/core/get-started/overview/first-app?source=recommendations&tabs=netcore-cli

using var db = new ContextManager();




// Note: This sample requires the database to be created before running.
Console.WriteLine($"Database path: {db.DbPath}.");


// HOW TO ADD PERSONA

//Persona persona = new Persona();
//db.Add(persona);
//db.SaveChanges();



// HOW TO UPDATE PERSONA
//db.Update(new Persona { Id = 2, Cognome = "djjsadj", Nome = "jack" });


//HOW TO DELETE PERSONA

//var personaDaEliminare = db.Persona.OrderBy(p => p.Id).Last(); // ELIMINO L'ULTIMO
// SE VOGLIO ELIMINARE IL PRIMO 
// var personaDaEliminare = db.Persona.OrderBy(p => p.Id).Fist(); // ELIMINO L'ULTIMO

//db.Remove(personaDaEliminare);
//db.SaveChanges();


List<Persona> personaInData = db.Persona.ToList();


foreach (Persona el in personaInData)
    Console.WriteLine(el);


