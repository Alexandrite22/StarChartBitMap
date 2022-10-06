using System;
using System.Collections.Generic;
using System.Text;

namespace StarChartBitMap
{
    class UserStarProfile
    {
        string UserName { get; set; }
        string DateOfBirth { get; set; }
        int HourOfBirth { get; set; }
        int MinuteOfBirth { get; set; }

        DateOfBirth UsersDateOfBirth = new DateOfBirth();

        string StarSign { get; set; }
        UserStarProfile ()
        {
            bool isValid = false;
            while (isValid == false)
            {
                Console.WriteLine("Please enter your Date Of Birth:");
                Console.Write("DD/MM/YYYY : ");
                string DOB = Console.ReadLine();
                string[] dobStringArray = DOB.Split("/");
                int[] dobIntArray = new int[dobStringArray.Length];
                for(int i = 0;i<3;i++)
                {
                    try
                    {
                        dobIntArray[i] = Int32.Parse(dobStringArray[i]);
                    }
                    catch
                    {

                    }
                }
                UsersDateOfBirth.Day = dobIntArray[0];
                UsersDateOfBirth.Month = dobIntArray[1];
                UsersDateOfBirth.Year = dobIntArray[2];
                if(UsersDateOfBirth.validDate())
                {
                    isValid = true;
                }
            }            
        }
    }
}
