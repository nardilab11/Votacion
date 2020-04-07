using System;
using System.Collections.Generic;
using System.Text;

namespace Votacion
{
    abstract class Persona
    {
        private readonly int _rut;

        protected Persona(int rut)
        {
            _rut = rut;
        }

        public int Rut => _rut;
    }
}
