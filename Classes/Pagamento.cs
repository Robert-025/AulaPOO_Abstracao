using System;

namespace AulaPOO_Abstracao.Classes
{
    public abstract class Pagamento
    {
        private DateTime data;
        public DateTime Data
        {
            get{ return data; }
            set{ data = value; }
        }


        protected float valor;
        public float Valor{ get; set; }


        public string Cancelar()
        {
            return "";
        }

        
    }
}