using SoccerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerApp.Repository.IRepository
{
    public interface IJugadorRepository
    {
        Jugador CreateJugador(Jugador jugador);
        Jugador GetJugadores(int id);
        ICollection<Jugador> GetJugadores();
        Jugador EditJugador(Jugador jugador);
        bool ExistJugador(string nombre);
    }
}
