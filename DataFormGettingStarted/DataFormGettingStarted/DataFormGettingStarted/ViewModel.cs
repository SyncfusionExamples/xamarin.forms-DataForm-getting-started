using System;
namespace DataFormGettingStarted
{
    public class ViewModel
    {
        private ContactsInfo contactsInfo;
        public ContactsInfo ContactsInfo
        {
            get { return this.contactsInfo; }
            set { this.contactsInfo = value; }
        }
        public ViewModel()
        {
            this.contactsInfo = new ContactsInfo();
        }
    }
}
