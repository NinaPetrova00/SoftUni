namespace Theatre.Common
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class GlobalConstants
    {
        //Theatre
        public const int Theatre_Name_Min_Length = 4;
        public const int Theatre_Name_Max_Length = 30;

        public const int Theatre_Director_Min_Length = 4;
        public const int Theatre_Director_Max_Length = 30;

        public const int Theatre_NumberOfHalls_Min_Length = 1;
        public const int Theatre_NumberOfHalls_Max_Length = 10;

        //Play
        public const int Play_Title_Min_Length = 4;
        public const int Play_Title_Max_Length = 50;

        public const float Play_Raiting_Min_Length = 00.0f;
        public const float Play_Raiting_Max_Length = 10.0f;

        public const int Play_Description_Max_Length = 700;

        public const int Play_Screenwriter_Min_Length = 4;
        public const int Play_Screenwriter_Max_Length = 30;

        public const int Play_Duartion_Min_Length = 1;


        //Cast
        public const int Cast_FullName_Min_Length = 4;
        public const int Cast_FullName_Max_Length = 30;

        public const int Cast_PhoneNumber_Max_Length = 15;
        public const string Cast_PhoneNumber_Regex = @"^.\d{2}-\d{2}-\d{3}-\d{4}$";

        //Ticket
        public const double Ticket_Price_Min_Length = 1.00;
        public const double Ticket_Price_Max_Length = 100.00;

        public const int Ticket_RowNumber_Min_Length = 1;
        public const int Ticket_RowNumber_Max_Length = 10;
    }
}
