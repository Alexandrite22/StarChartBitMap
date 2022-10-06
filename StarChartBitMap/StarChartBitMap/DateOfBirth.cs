using System;using System.Collections.Generic;
using System.Text;

namespace StarChartBitMap
{
    class DateOfBirth
    {
        public int Day;
        public int Month;
        public int Year;
        public bool validDate()
        {
            if (Year <= DateTime.Now.Year && Year > 0)
            {
                if (Month <= 12)
                {
                    if (Day > 31)
                    {
                        if ((Month == 4 || Month == 6 || Month == 9 || Month == 11) && Day > 30)
                        {
                            return false;
                        }
                        if (Month == 2)
                        {
                            if (Year % 4 == 0 && (Year % 100 != 0 && Year % 400 == 0))
                            {
                                if(Day > 29)
                                {
                                    return false;
                                }
                                else
                                {
                                    return true;
                                }
                            }
                            else
                            {
                                if (Day > 28)
                                {
                                    return false;
                                }
                                else
                                {
                                    return true;
                                }
                            }
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }    
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
