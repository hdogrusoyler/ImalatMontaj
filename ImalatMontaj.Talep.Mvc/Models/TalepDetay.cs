using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImalatMontaj.Talep.Mvc.Models
{
    public class TalepDetay
    {
        public Entities.Concrete.Talep talep { get; set; }
        public List<Entities.Concrete.Foto> fotos { get; set; }
    }
}
