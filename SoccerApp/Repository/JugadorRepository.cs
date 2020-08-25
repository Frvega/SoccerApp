using SoccerApp.Infrestuctura;
using SoccerApp.Models;
using SoccerApp.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerApp.Repository
{
    public class JugadorRepository : IJugadorRepository
    {
        private readonly SoccerAppContext _soccerAppContext;
        public JugadorRepository(SoccerAppContext soccerAppContext)
        {
            _soccerAppContext = soccerAppContext;
        }

        public Jugador CreateJugador(Jugador jugador)
        {
            _soccerAppContext.Set<Jugador>().Add(jugador);
            _soccerAppContext.SaveChanges();
            return jugador;
        }

        public Jugador EditJugador(Jugador jugador)
        {
            throw new NotImplementedException();
        }

        public bool ExistJugador(string nombre)
        {
            var jugador = _soccerAppContext.Set<Jugador>().Select(j => j.Nombre == nombre);
            if (jugador == null)
            {
                return false;
            }
            return true;
        }

        public Jugador GetJugadores(int id)
        {
            return _soccerAppContext.Set<Jugador>().FirstOrDefault(j => j.JugadorId == id);
        }

        public ICollection<Jugador> GetJugadores()
        {
            return _soccerAppContext.Set<Jugador>().Select(j => j).ToList();
        }
    }
}
