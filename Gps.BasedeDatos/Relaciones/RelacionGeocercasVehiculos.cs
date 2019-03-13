﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gps.BasedeDatos.Relaciones
{
    public class RelacionGeocercasVehiculos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Guid { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime UpdateDate { get; set; }

        public int IdGeocerca { get; set; }
        public int IdVehiculo { get; set; }
    }
}