﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedFind.Models
{
    public class Medic
    {
        public string MedicAccount { get; set; }

        public string Name { get; set; }

        public Category Specialty { get; set; }

        public string Description { get; set; }



    }
    public enum Category
    {

        Parodontologie,
        Prostetica_dentara,
        Chirurgia_Oro_Maxilo_Faciala,
        Chirurgia_Dento_Alveolara,
        Endodontie,
    }
}

