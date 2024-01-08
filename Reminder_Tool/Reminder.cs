namespace Reminder_Tool
{
    public class Reminder
    {
        public string userName { get; set; }
        public string title { get; set; }
        public DateOnly startdate { get; set; }
        public string description { get; set; }
        //public interval { get; set; } 

        //password = new System.Security.Cryptography.SHA256Managed().ComputeHash(password);
        public Reminder() { }
        public Reminder(string userName, string title, DateOnly startdate,  string description)
        {
            this.userName = userName;
            this.title = title;
            this.startdate = startdate;
            this.description = description;
            //this.interval = interval;
        }

        public void createReminder () 
        {
            
        }
        public void editReminder()
        {

        }
        public void deleteReminder()
        { 
        
        }
    }
}
