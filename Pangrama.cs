using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pangrama
{
    class Pangrama
    {

        public List<char> abecedario()
        {
            List<char> pangrama = new List<char>()
            {
                'a',
                'b',
                'c',
                'd',
                'e',
                'f',
                'g',
                'h',
                'i',
                'j',
                'k',
                'l',
                'm',
                'n',
                'ñ',
                'o',
                'p',
                'q',
                'r',
                's',
                't',
                'u',
                'v',
                'w',
                'x',
                'y',
                'z'
             };

            return pangrama;
        }

        public void compararPagrama(string frase)
        {
            List<char> alfabeto = abecedario();
            List<char> letrasContains = new List<char>();
            for(int i = 0; i < frase.Length; i++  )
            {
                if ( alfabeto.Contains(frase[i]) && !letrasContains.Contains(frase[i]))
                {
                    letrasContains.Add( frase[i] );
                }
            }


            if( alfabeto.Count == letrasContains.Count)
            {
                Console.WriteLine("la palabra es un pangrama");
            }
            else
            {
                List<char> caracteresNocontains = new List<char>();
                for (int i = 0; i < alfabeto.Count; i++)
                {
                    if(!letrasContains.Contains(alfabeto[i]))
                    {
                        caracteresNocontains.Add(alfabeto[i]);   
                    }
                }

                Console.WriteLine("las letras que faltan para que esto sea un pangrama son: " + string.Join("," , caracteresNocontains) );
            }
        }
    }
}
