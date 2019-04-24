using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int32ToIPv4
{
    public class Kata
    {
        public static string UInt32ToIP(uint ip)
        {
            string ipString = string.Empty;

            string binaryString = Convert.ToString( ip , 2 ).PadLeft( 32 , '0' );

            for( int i = 0 ; i < 4 ; i++ )
            {
                if( ipString.Length > 0 )
                {
                    ipString += ".";
                }

                ipString += Convert.ToInt32( binaryString.Substring( i * 8 , 8 ) , 2 ).ToString();
            }

            return ipString;
        }
    }
}
