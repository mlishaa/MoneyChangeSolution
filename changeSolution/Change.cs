using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace changeSolution
{


    enum Rest
    {
         Hundered =100, Fifty=50 , Twenty =20, Ten =10,Five =5, TwoDollas=2 , 
                                             Dollar =1, Quarter =25 , Dime =10, Nickel =5, Penny=1
    }
  

    class Change
    {
        private double _change;
        private double _total;
        private double _provided;
      

        public double Total
        {
            get => _total;

            set => _total = value;
        }
        public double Provided
        {
            get => _provided;
            set => _provided = value;
        }

        public double getChange()
        {
            return Provided - Total;
        }

        string[] rest = { "Hundered", "Fifty", "Twenty", "Ten", "Five", "Two Dollar", "Dollar", "Quarter", "Dime", "Nickel", "Penny" };
        double[] restVales = { 100, 50, 20, 10, 5, 2, 1, 0.25, 0.10, 0.05, 0.01 };
        public string getChangeInVoice()
        {
            
            double change = Math.Round(getChange(),2);

            StringBuilder msg = new StringBuilder();
            for (int i=0;i< rest.Length; ++i)
            {
                

                if (change >= restVales[i])
                {
                    int number =(int)( change / (restVales[i]));
                    msg.AppendLine(string.Format("{0,-20} : {1,-20}", number, rest[i]));
                    change = Math.Round(change % restVales[i],2);
                }
            }
            return msg.ToString();
           
        }       
    }
}
