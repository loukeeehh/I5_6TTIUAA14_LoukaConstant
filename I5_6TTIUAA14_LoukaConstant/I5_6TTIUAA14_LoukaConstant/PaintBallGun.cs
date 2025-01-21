using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace I5_6TTIUAA14_LoukaConstant
{
    internal class PaintBallGun
    {
        private byte _nbBallesChargeur;
        private byte _tailleChargeur;

        public PaintBallGun(byte nbBallesChargeur, byte tailleChargeur)
        {
            _nbBallesChargeur = nbBallesChargeur;
            _tailleChargeur = tailleChargeur;
        }

        public byte NbBallesChargeur
        {
            get { return _nbBallesChargeur; }
            set { _nbBallesChargeur = value; }
        }

        public byte TailleChargeur
        {
            get { return _tailleChargeur; }
            set { _tailleChargeur = value; }
        }

        //public bool ChargeurEstVide()
        //{
        //    bool ok = true;
        //    string infos = "";
        //    if (ok == false)
        //    {
        //        infos = "Votre chargeur est vide";
        //    }

        //    return false;
        //}


    }
}
