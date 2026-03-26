using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lieferverwaltung
{
    public partial class FrmMain : Form
    {
        List<Lieferung> lieferungen;
        public FrmMain()
        {
            InitializeComponent();

            List<Lieferung> lieferungen = new List<Lieferung>();
        }

        public FrmMain(List<Lieferung> lieferungen):this()
        {
            this.lieferungen = lieferungen;
            
            foreach(Lieferung aktuelleLieferung in lieferungen)
            {
                lbxLieferungen.Items.Add(aktuelleLieferung.Sendungsnummer);
            }
        }
    }
}
