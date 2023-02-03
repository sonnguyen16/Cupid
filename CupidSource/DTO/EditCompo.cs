using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cupid.DTO
{
    internal class EditCompo
    {
        public string Control { get; set; }
        public string OldValue { get; set; }

        public string NewValue { get; set; }


        public EditCompo(string Control, string OldValue,string NewValue)
        {
            this.Control = Control;
            this.OldValue = OldValue;
            this.NewValue = NewValue;
        }
    }
}
