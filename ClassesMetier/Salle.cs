﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesMetier
{
    public class Salle
    {
        public int IdSalle { get; set; }
        public string NomSalle { get; set; }
        public int NbPlaces { get; set; }

        public static implicit operator List<object>(Salle v)
        {
            throw new NotImplementedException();
        }
    }
}
