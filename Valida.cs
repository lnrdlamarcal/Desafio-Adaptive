using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    public class Valida
    {
        public string validaAcesso(string palavraChave)
        {
            DateTime horaAtual = DateTime.Now; //Obtem hora atual
            string horaFormatada = horaAtual.ToString("mm"); //Extrai o minuto da hora
            string minutoValido = horaFormatada.Substring(1, 1); //Recorta o último digito do mínuto
            int converteMinuto = Int32.Parse(minutoValido); //Converte para inteiro

            if (converteMinuto > 0) //Se minuto for = 0, então palavra-chave é igual a palavra-chave original
            {
                string palavraChaveSubs = palavraChave.Substring(palavraChave.Length - converteMinuto); //Recorta as casas equivalente ao final da palavra - a quantidade de minutos
                char[] arrayReversa = palavraChaveSubs.ToCharArray(); //Converte para string
                Array.Reverse(arrayReversa); //Inverte string
                string palavraChaveCorte = string.Join("", arrayReversa); //Junta a palavra recortada ao array revertido
                string s = palavraChave.Remove(12 - converteMinuto); //Remove os caracteres antes recortados
                string j = palavraChaveCorte + s; //Junta as palavras
                return j;
            }
            else //Validação para quando o minuto for 00
            {
                return palavraChave;
            }
        }
    }
}
