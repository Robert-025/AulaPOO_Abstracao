using System;

namespace AulaPOO_Abstracao.Classes
{
    public class Credito : Cartao 
    {
        private float limite = 3000;
        public float Limite{
            get{ return limite; }
        }


        public int parcelas;


        public void Pagar(float valor)
        {
            
        }
    }
}