using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthShopData.Models
{
    public class CatalogItemSpecs
    {
        public int Id { get; set; }
        public string Polyphony { get; set; }
        public string Oscillators { get; set; }
        public string Lfo { get; set; }
        public string Filter { get; set; }
        public string Effects { get; set; }
        public string Keyboard { get; set; }
        public string Memory { get; set; }
        public int DateProduced { get; set; }
    }
}
