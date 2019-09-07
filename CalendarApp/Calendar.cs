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
            //define the calendarStr as the header of the calendar at first.
            string calendarStr = "====================================\n"+
                                 "| S  | M  | T  | W  | T  | F  | S  |\n" + 
                                 "====================================\n";
            
            //for each fo the 6 row, we will build the string representing the row base on the currentDate.
            int indexOfDay = 1;
            int numberOfDay = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
            DateTime firstDay = new DateTime(currentDate.Year, currentDate.Month, 1);
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (indexOfDay != numberOfDay + 1)
                    {
                        if (i == 0 && j+1 < firstDay.Day)
                        {
                            calendarStr += "|    ";
                        }
                        else if (indexOfDay < 9)
                        {
                            calendarStr += "| 0" + indexOfDay + " ";
                            indexOfDay++;
                        }
                        else
                        {
                            calendarStr += "| " + indexOfDay + " ";
                            indexOfDay++;
                        }
                    }
                    else
                    {
                        calendarStr += "|    ";
                    }
                }

                calendarStr += "|\n";
            }
            return calendarStr;
        }
    }
}