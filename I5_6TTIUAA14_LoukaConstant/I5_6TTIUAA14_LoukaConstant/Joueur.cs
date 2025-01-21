using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I5_6TTIUAA14_LoukaConstant
{
    internal class Joueur
    {
        private string _pseudo;
        private PaintBallGun _myPaintBallGun;
        private byte _nbCartouchesEnPoche;

        public Joueur(string pseudo, PaintBallGun mypaintBallGun, byte nbCartouchesEnPoche)
        {
            _pseudo = pseudo;
            _myPaintBallGun = mypaintBallGun;
            _nbCartouchesEnPoche = nbCartouchesEnPoche;
        }

        public string Pseudo
        {
            get { return _pseudo; }
            set { _pseudo = value; }
        }

        public PaintBallGun MyPaintBallGun
        {
            get { return _myPaintBallGun; }
            set { _myPaintBallGun = value; }
        }


        public byte NbCartouchesEnPoche
        {
            get { return _nbCartouchesEnPoche; }
            set { _nbCartouchesEnPoche = value; }
        }

        public string Recharge()
        {

            if (MyPaintBallGun.NbBallesChargeur == 0)
            {
               
            }

            return "Recharge de " + MyPaintBallGun + " balles dans le chargeur effectuée";
        }

        //public bool Tire()
        //{
            
        //}

        public string VerifiePoche()
        {
            return "Vous avez " + NbCartouchesEnPoche + " cartouches dans votre poche et " + MyPaintBallGun.NbBallesChargeur + " balles dans le chargeur";
           
        }



    }
}
