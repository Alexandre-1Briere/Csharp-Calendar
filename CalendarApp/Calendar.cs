using System;

namespace CalendarApp
{
    public class Calendar
    {
        private System.DateTime currentDate;
        public DateTime CurrentDate => currentDate;

        public Calendar()
        {
            currentDate = System.DateTime.Now;
        }

        
        
        //Author : Alexandre Brière
        //Input : nothing
        //Output : the string that correspond to the current selected calendar
        //Description: override ToString to allow a display of the calendar directly by the function console.write or 
        //                console.writeLine
        public override string ToString()
        {
            string calendarStr = "====================================\n"+
                                 "| D  | L  | M  | M  | J  | V  | S  |\n" + 
                                 "====================================\n";

            for (int i = 0; i < 6; i++)
            {
                
            }
            return calendarStr;
        }
    }
}