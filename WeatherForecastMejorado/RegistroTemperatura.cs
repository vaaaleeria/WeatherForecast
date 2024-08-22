using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastMejorado
{
    public class RegistroTemperatura
    {
        private int _temperaturaRegistada;
        public int TemperaturaRegistada { get => _temperaturaRegistada; set => _temperaturaRegistada = value; }
        private Persona _user;
        public Persona User { get => _user; set => _user = value; }
        private DateOnly _fechaRegistro;
        public DateOnly FechaRegistro { get => _fechaRegistro; set => _fechaRegistro = value;}

        private TimeSpan _horaRegistro;
        public TimeSpan HoraRegistro { get => _horaRegistro;    set => _horaRegistro = value; }

        public RegistroTemperatura(int temperatura, Persona user, DateOnly fecha, TimeSpan hora)
        {
            this._temperaturaRegistada= temperatura;
            this._user = user;
            this._fechaRegistro = fecha;
            this._horaRegistro = hora;
        }
            



    }
}
