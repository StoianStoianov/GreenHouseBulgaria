using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouseBulgaria.Models
{
    public class Image
    {               
        public int Id { get; set; }

        public byte[] ImageBytes { get; set; }
       
        public virtual Service Service { get; set; }
    }
}
