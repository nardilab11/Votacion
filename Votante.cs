using System;
using System.Collections.Generic;
using System.Text;

namespace Votacion
{
    class Votante : Persona
    {
        //inmutable el rut, quitar el set
        private char[] _nombre;
        private string _apellido;
        private bool estaHabilitado;
        
        private Votante(int rut) : base(rut) //base se refiere a la clase padre, le dice que coja rut de ahi base(rut) = Persona(rut)
        {
            // inicializar, valor por defecto, solo se use dentro de la clase: private
            _nombre = new char[32];
            _nombre[0] = 'h';
            _nombre[0] = 'o';
            _nombre[0] = 'l';
            _nombre[0] = 'a';

            _apellido = string.Empty;
            estaHabilitado = true;

            // _apellido = ""; no esta vacio tecnicamente

            // _nombre[0] = '\x00';  Null, para que no siga leyendo

            // for (int i = 0; i < _nombre.Length; i++)
               //  Console.Write(_nombre[i]);

            // foreach (char c in _nombre)
               // Console.Write(c);
            
        }

        public Votante(int rut, char[] nombre, string apellido) : this(rut)
        {
            //construir, hay que darle parametros, public, como solo este se puede ver cuando se programe, el this llama a que se haga todo (se inicialice y todo
            // no todos los atributos deben asignarse
            _nombre = nombre;
            _apellido = apellido;
        }


        public char[] Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public bool EstaHabilitado { get => estaHabilitado; set => estaHabilitado = value; }
    }
}
