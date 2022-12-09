using Domain.Entities;
using Infrastructure.Context;

namespace Infrastructure.Inicialize.Entities;

public class InitializePlan
{
    public static void Inicialize(PersistenceContext persistenceContext)
    {
        var plans = new List<Plan>
        {
            new()
            {
                Duration = 30,
                Name = "Convencional",
                Routines = new List<Routine>()
                {
                    new()
                    {
                        Name = "Pierna y Abominales",
                        Training = "Sentadilla,Prensa,Barra libre,Avanzada"
                    },
                    new()
                    {
                        Name = "Pecho y Bicep",
                        Training = "Press de banca,Press superior,Predicador,Martillo"
                    },
                    new()
                    {
                        Name = "Pierna y Abominales",
                        Training = "Sentadilla,Prensa,Barra libre,Avanzada"
                    },
                    new()
                    {
                        Name = "Espalda y Tricep",
                        Training = "Remo,Remo martillo,Copas,Rompe Craneos"
                    },
                    new()
                    {
                        Name = "Circuito",
                        Training = "Bola pared,Power clean,Pull ups"
                    },
                }
            },
            new()
            {
                Duration = 15,
                Name = "Fichos",
                Routines = new List<Routine>()
                {
                    new()
                    {
                        Name = "Pierna y Abominales",
                        Training = "Sentadilla,Prensa,Barra libre,Avanzada"
                    },
                    new()
                    {
                        Name = "Pecho y Bicep",
                        Training = "Press de banca,Press superior,Predicador,Martillo"
                    },
                    new()
                    {
                        Name = "Pierna y Abominales",
                        Training = "Sentadilla,Prensa,Barra libre,Avanzada"
                    },
                    new()
                    {
                        Name = "Espalda y Tricep",
                        Training = "Remo,Remo martillo,Copas,Rompe Craneos"
                    },
                    new()
                    {
                        Name = "Circuito",
                        Training = "Bola pared,Power clean,Pull ups"
                    },
                }
            },
            new()
            {
                Duration = 30,
                Name = "Defensa personal",
                Routines = new List<Routine>()
                {
                    new()
                    {
                        Name = "Pierna y Abominales",
                        Training = "Sentadilla,Prensa,Barra libre,Avanzada"
                    },
                    new()
                    {
                        Name = "Pecho y Bicep",
                        Training = "Press de banca,Press superior,Predicador,Martillo"
                    },
                    new()
                    {
                        Name = "Pierna y Abominales",
                        Training = "Sentadilla,Prensa,Barra libre,Avanzada"
                    },
                    new()
                    {
                        Name = "Espalda y Tricep",
                        Training = "Remo,Remo martillo,Copas,Rompe Craneos"
                    },
                    new()
                    {
                        Name = "Circuito",
                        Training = "Bola pared,Power clean,Pull ups"
                    },
                }
            },
        };
        persistenceContext.Plans.AddRange(plans);
        persistenceContext.SaveChanges();
    }
}