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
            int numberOfDay = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);// get the number of day in the current month
            DateTime firstDay = new DateTime(currentDate.Year, currentDate.Month, 1);// get the first day indexes (1-7) in the current month
            for (int i = 0; i < 6; i++)//we display 6 line
            {
                for (int j = 0; j < 7; j++)// with the 7 day case in each
                {
                    if (indexOfDay != numberOfDay + 1)//if we haven''t reach the last day
                    {
                        if (i == 0 && j+1 < firstDay.Day)//if we haven't reach teh first day add a blank case'
                        {
                            calendarStr += "|    ";
                        }
                        else if (indexOfDay < 10)// else , if the number is lower then 10 we add a 0 before the number in the case
                        {
                            calendarStr += "| 0" + indexOfDay + " ";
                            indexOfDay++;
                        }
                        else // else we simply display the number in the cas
                        {
                            calendarStr += "| " + indexOfDay + " ";
                            indexOfDay++;
                        }
                    }
                    else// if we have reached the last day we fill the remaining case with blank
                    {
                        calendarStr += "|    ";
                    }
                }

                calendarStr += "|\n";//add the end line to each row
            }

            calendarStr += "====================================\n";// add the last row to the calendar
            return getMonth(currentDate.Month) + " " + currentDate.Year + "\n" +  calendarStr;//return the month and year followed by the calendar
        }

        //Author : Alexandre Brière
        //Input : the number corresponding to the current month (1-12)
        //Output : the string that correspond to the current month
        //Description: allow to display the current month in word
        private string getMonth(int month)
        {
            switch (month)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12:
                    return "December";
                default:
                    return "not a month";
            }
        }
    }
}