using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013114400
{
    class Carro
    {
        Llanta _llanta;
        Asiento _asiento;
        Parabrisas _parabrisas;
        Volante _volante;
        public string NumSerieMotor { get; set; }
        public string NumSerieChasis { get; set; }

        public Carro(string _numSerieMotor, string _numSerieChasis)
        {
            NumSerieChasis = _numSerieChasis;
            NumSerieMotor = _numSerieMotor;
            _llanta = new Llanta();
            _asiento = new Asiento();
            _parabrisas = new Parabrisas();
            _volante = new Volante();


        }
        public Carro()
        {

        }
    }
}
