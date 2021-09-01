using System;
using System.Collections.Generic;
using System.Text;

namespace simuladorMatricula
{
    class studens
    {
        private string fName;
        private int vCred, stratrum, nCred, vTotal, vDiscount, vNet;

        public studens(int vCred, int stratrum, int nCred, int vTotal, int vDiscount, int vNet)
        {
            this.vCred = vCred;
            this.stratrum = stratrum;
            this.nCred = nCred;
            this.vTotal = vTotal;
            this.vDiscount = vDiscount;
            this.vNet = vNet;
        }

        public int VCred { get => vCred; set => vCred = value; }
        public int Stratrum { get => stratrum; set => stratrum = value; }
        public int NCred { get => nCred; set => nCred = value; }
        public int VTotal { get => vTotal; set => vTotal = value; }
        public int VDiscount { get => vDiscount; set => vDiscount = value; }
        public int VNet { get => vNet; set => vNet = value; }




    }
}
