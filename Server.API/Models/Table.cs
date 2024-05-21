namespace Server.API.Models
{
    public class Table
    {
        private int tableID;
        private string tableName;
        private int tableBuyIn;
        private int tablePlayerLimit;

        public int TableID
        {
            get { return tableID; }
            set { tableID = value; }
        }
        public string TableName
        {
            get { return tableName; }
            set { tableName = value; }
        }
        public int TableBuyIn
        {
            get { return tableBuyIn; }
            set { tableBuyIn = value; }
        }
        public int TablePlayerLimit
        {
            get { return tablePlayerLimit; }
            set { tablePlayerLimit = value; }
        }
    }
}
