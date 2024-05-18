using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spovify.Domain.Modals
{
    public class Song
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Person Artist { get; set; }

        public Person Producer { get; set; }

        public Person Lyricist { get; set; }

    }
}
