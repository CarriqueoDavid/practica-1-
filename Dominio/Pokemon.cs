﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;//para poder usar el diplay

namespace Dominio
{
    public class Pokemon
    {
        public int Id { get; set; }
        [DisplayName("Número")]//para ponerle acento al nombre de la columna
        public int Numero {  get; set; }//propiedades
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion {  get; set; }
        public string UrlImagen { get; set; }

        public Elemento Debilidad { get; set; }

        public Elemento Tipo { get; set; }

    }
}
