using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Balon_de_Oro_Argentino_2017
{
    public partial class Form1 : Form
    {
        private List<Jugador> jugadores; // Campo para almacenar la lista de jugadores

        public Form1()
        {
            InitializeComponent();

            // Inicializamos la lista de jugadores
            jugadores = new List<Jugador>
            {
                new Jugador("Darío Benedetto", 27, "Boca Juniors", 12, 3),
                new Jugador("Lautaro Martínez", 20, "Racing Club", 9, 4),
                new Jugador("Ignacio Scocco", 32, "River Plate", 11, 2),
                new Jugador("Fernando Belluschi", 34, "San Lorenzo", 5, 6),
                new Jugador("Maximiliano Meza", 25, "Independiente", 7, 5)
            };
        }

        // Evento que se ejecuta al cargar el formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            // Llamamos al método que actualiza el ListBox con todos los jugadores
            ActualizarListaJugadores();
        }

        // Método para agregar todos los jugadores a la ListBox
        private void ActualizarListaJugadores()
        {
            // Limpiamos la lista antes de actualizarla
            lstJugadores.Items.Clear();

            // Agregamos cada jugador al ListBox con sus estadísticas
            foreach (var jugador in jugadores)
            {
                // Puedes personalizar qué información mostrar en la lista
                lstJugadores.Items.Add($"{jugador.Nombre} - Goles: {jugador.Goles}, Asistencias: {jugador.Asistencias}");
            }
        }

        // Evento para registrar un voto a un jugador
        private void button1_Click(object sender, EventArgs e)
        {
            string nombreJugador = txtNombreJugador.Text;
            Jugador jugadorSeleccionado = jugadores.FirstOrDefault(j => j.Nombre == nombreJugador);

            if (jugadorSeleccionado != null)
            {
                jugadorSeleccionado.RegistrarVoto();
                MessageBox.Show(jugadorSeleccionado.MostrarEstadisticas(), "Estadísticas Actualizadas");
                ActualizarListaJugadores(); // Actualizamos la lista tras el voto
            }
            else
            {
                MessageBox.Show("Jugador no encontrado", "Error");
            }
        }

        // Evento para mostrar el ganador con más votos
        private void button2_Click(object sender, EventArgs e)
        {
            // Verificamos si hay jugadores en la lista
            if (jugadores.Count > 0)
            {
                // Encontramos al jugador con más votos
                Jugador ganador = jugadores.OrderByDescending(j => j.Votos).FirstOrDefault();

                // Verificamos si hay votos registrados
                if (ganador != null && ganador.Votos > 0)
                {
                    txtGanador.Text = $"El ganador es {ganador.Nombre} con {ganador.Votos} votos.";
                }
                else
                {
                    MessageBox.Show("Aún no hay votos registrados.", "Sin Votos");
                }
            }
            else
            {
                MessageBox.Show("No hay jugadores en la lista.", "Error");
            }
        }

        private void lstJugadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtGanador_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


