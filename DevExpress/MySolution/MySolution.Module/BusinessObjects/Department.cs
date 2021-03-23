using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace MySolution.Module.BusinessObjects
{
    [DefaultClassOptions]
    [System.ComponentModel.DefaultProperty(nameof(Title))]
    public class Department : BaseObject
    {
        public Department(Session session) : base(session) { }
        private string title;
        public string Title
        {
            get => title;
            set => SetPropertyValue(nameof(Title), ref title, value);
        }
        private string office;
        public string Office
        {
            get => office;
            set => SetPropertyValue(nameof(Office), ref office, value);
        }

        [Association("Department-Contacts")]
        public XPCollection<Contact> Contacts => GetCollection<Contact>(nameof(Contacts));

        [Association("Departments-Positions")]
        public XPCollection<Position> Positions => GetCollection<Position>(nameof(Positions));
    }
}