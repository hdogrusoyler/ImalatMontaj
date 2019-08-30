using ImalatMontaj.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImalatMontaj.Talep.Entities.Concrete
{
    public class Foto : IEntity
    {
        public int Id { get; set; }

        public string Yol { get; set; }

        public int TalepId { get; set; }
        public Talep Talep { get; set; }
    }
}
