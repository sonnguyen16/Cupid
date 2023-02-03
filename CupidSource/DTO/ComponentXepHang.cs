using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cupid.Toolbox_Custom;
using System.Windows.Forms;

namespace Cupid.DTO
{
    internal class ComponentXepHang
    {
        public PictureBox_Custom pc;
        public Label lbten;
        public Label lbtien;

        public ComponentXepHang()
        {

        }

        public ComponentXepHang(PictureBox_Custom pc,Label lbten,Label lbtien)
        {
            this.pc = pc;
            this.lbten = lbten;
            this.lbtien = lbtien;
        }
    }
}
