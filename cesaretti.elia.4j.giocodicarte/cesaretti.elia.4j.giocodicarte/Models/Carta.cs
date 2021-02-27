using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cesaretti.elia._4j.giocodicarte.Models
{
    class Carta
    {
        private int _valore;
        private string _seme;
        public int valore
        {
            get
            {
                return _valore;
            }
            set
            {
                _valore = value;
            }
        }
        public string seme
        {
            get
            {
                return _seme;
            }
            set
            {
                _seme = value;
            }
        }
        public Carta(int valore, string seme)
        {
            _valore = valore;
            _seme = seme.ToLower();
        }
        public string Visualizza(Carta Carta1)
        {
            if (_valore == 14)
            {
                return "La carta è l'Asso di " + _seme;
            }
            else
            {
                return "La tua carta è il " + _valore + " di " + _seme;
            }
        }
        public string Vince(Carta Carta1, Carta Carta2)
        {
            bool r;
            if (Carta1._seme == Carta2._seme)
            {
                if (Carta1._valore > Carta2._valore)
                {
                    r = true;
                }
                else
                {
                    r = false;
                }
            }
            else
            {
                if (Carta1._seme == "cuori" || Carta1._seme == "c")
                {
                    r = true;
                }
                else
                {
                    if (Carta2._seme == "cuori" || Carta1._seme == "c")
                    {
                        r = false;
                    }
                    else
                    {
                        if (Carta1._seme == "quadri" || Carta1._seme == "q")
                        {
                            r = true;
                        }
                        else
                        {
                            if (Carta2._seme == "quadri" || Carta2._seme == "q")
                            {
                                r = false;
                            }
                            else
                            {
                                if (Carta1._seme == "fiori" || Carta1._seme == "f")
                                {
                                    r = true;
                                }
                                else
                                {
                                    if (Carta2._seme == "fiori" || Carta2._seme == "f")
                                    {
                                        r = false;
                                    }
                                    else
                                    {
                                        r = false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (r)
            {
                return "La Prima carta è più grande della Seconda";
            }
            else
            {
                return "La Seconda carta è più grande della Prima";
            }
        }
    }
}
