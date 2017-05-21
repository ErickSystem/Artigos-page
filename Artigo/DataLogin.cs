using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artigo
{
    public class DataLogin
    {
        private string dia;
        private string mes;
        private string ano;
        private string hora;
        private string minuto;


        string data;
        public string retornarData()
        {
             dia = DateTime.Now.Day.ToString();
             mes = DateTime.Now.Month.ToString();
             ano = DateTime.Now.Year.ToString();
            //passa a data para o Label e apresenta na tela
<<<<<<< HEAD
            hora = DateTime.Now.Hour.ToString();
            minuto = DateTime.Now.Minute.ToString();
            return data = dia + "/" + "0" + mes + "/" + ano + " " + hora + ":" + minuto;
=======

            return data = dia + "/" + "0" + mes + "/" + ano;
>>>>>>> fbe72b702681d7a8197e185615d39ee0462346ae
        }
        //recebe a data atual
       
    }
}
