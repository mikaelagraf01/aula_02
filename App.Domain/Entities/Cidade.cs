﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Interfaces
{

    public class Cidade
    {
        [Key]
        public Guid Id { get; set; }
        public string Cep { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }
        public int Peso { get; set; }
        
    }
}




