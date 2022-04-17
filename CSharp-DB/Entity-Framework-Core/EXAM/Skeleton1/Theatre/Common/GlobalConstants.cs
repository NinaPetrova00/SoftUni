namespace Theatre.Common
{
    public static class GlobalConstants
    {
        //Theatre
        public const int THEATRE_NAME_MAX_LENGTH = 30;
        public const int THEATRE_NAME_MIN_LENGTH = 4;

        public const int THEATRE_DIRECTOR_MAX_LENGTH = 30;
        public const int THEATRE_DIRECTOR_MIN_LENGTH = 4;

        public const int THEATRE_NUMBEROFHALLS_MIN_LENGTH = 1;
        public const int THEATRE_NUMBEROFHALLS_MAX_LENGTH = 10;

        //Play
        public const int PLAY_TITLE_MAX_LENGTH = 50;
        public const int PLAY_TITLE_MIN_LENGTH = 50;

        public const float PLAY_RAITING_MIN_VALUE = 0.00f;
        public const float PLAY_RAITING_MAX_VALUE = 10.00f;

        public const int PLAY_DESCRIPTION_MAX_LENGTH = 700;

        public const int PLAY_SCREENWRITER_MAX_LENGTH = 30;
        public const int PLAY_SCREENWRITER_MIN_LENGTH = 4;

        public const int PLAY_DURATION_MIN_LENGTH = 1;

        //Cast
        public const int CAST_FULLNAME_MAX_LENGTH = 30;
        public const int CAST_FULLNAME_MIN_LENGTH = 4;
        public const string CAST_PHONENUMBER_REGEX = @"^.\d{2}-\d{2}-\d{3}-\d{4}$";
        public const int CAST_PHONENUMBER_MAX_LENGTH = 15;

        //Tickets
        public const float TICKETS_PRICE_MIN_VALUE = 1.00f;
        public const float TICKETS_PRICE_MAX_VALUE = 100.00f;

        public const int TICKETS_ROWNUMBER_MIN_VALUE = 1;
        public const int TICKETS_ROWNUMBER_MAX_VALUE = 10;
    }
}
