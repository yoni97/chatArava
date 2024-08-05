namespace AravaChat.DAL
{
    //מחלקה לניהול הנתונים של my friends
    public class Data
    {
        //משתנה סטטי לשמירת מופע יחיד של המחלקה
        static Data? GetData;

        string connectionString = " " +
            "server= DESKTOP-C9ROG7J\\SQLEXPRESS;" +
            " initial catalog=AravaChat ;" +
            " user id=sa;" +
            " password=1234 ;" +
            " TrustServerCertificate=Yes";

        //מניעת יצירת מופעים מחוץ למחלקה
        private Data()
        {
            //יצירת מופע של שכבת הנתונים עם קונקשן סטרינג
            Layer = new DataLayer(connectionString);
        }

        //מאפיין סטטי לקבלת שכבת הנתונים
        public static DataLayer Get
        {
            get
            {
                //יצירת מופע חדש
                if (GetData == null)
                {
                    GetData = new Data();
                }
                //החזרת שכבת הנתונים
                return GetData.Layer;
            }
        }
        //מאפיין לשמירת שכבת הנתונים
        public DataLayer Layer { get; set; }
    }
}
