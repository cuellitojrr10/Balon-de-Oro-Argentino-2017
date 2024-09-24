using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balon_de_Oro_Argentino_2017
{
        public class Jugador
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public string Equipo { get; set; }
            public int Goles { get; set; }
            public int Asistencias { get; set; }
            public int Votos { get; set; }

            public Jugador(string nombre, int edad, string equipo, int goles, int asistencias)
            {
                Nombre = nombre;
                Edad = edad;
                Equipo = equipo;
                Goles = goles;
                Asistencias = asistencias;
                Votos = 0;
            }

            public void RegistrarVoto()
            {
                Votos++;
            }

            public string MostrarEstadisticas()
            {
                return $"Jugador: {Nombre}, Equipo: {Equipo}, Goles: {Goles}, Asistencias: {Asistencias}, Votos: {Votos}";
            }
        }

    }

