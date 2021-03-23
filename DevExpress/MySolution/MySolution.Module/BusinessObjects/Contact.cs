using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;

namespace MySolution.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Contact : Person
    {
        public Contact(Session session) : base(session) { }

        private string webPageAddress;
        public string WebPageAddress
        {
            get => webPageAddress;
            set => SetPropertyValue(nameof(WebPageAddress), ref webPageAddress, value);
        }

        private string nickName;
        public string NickName
        {
            get => nickName;
            set => SetPropertyValue(nameof(NickName), ref nickName, value);
        }

        private string spouseName;
        public string SpouseName
        {
            get => spouseName;
            set => SetPropertyValue(nameof(SpouseName), ref spouseName, value);
        }

        private TitleOfCourtesy titleOfCourtesy;
        public TitleOfCourtesy TitleOfCourtesy
        {
            get => titleOfCourtesy;
            set => SetPropertyValue(nameof(TitleOfCourtesy), ref titleOfCourtesy, value);
        }

        private DateTime anniversary;
        public DateTime Anniversary
        {
            get => anniversary;
            set => SetPropertyValue(nameof(Anniversary), ref anniversary, value);
        }

        private string notes;
        [Size(4096)]
        public string Notes
        {
            get => notes;
            set => SetPropertyValue(nameof(Notes), ref notes, value);
        }

        private Position position;
        public Position Position
        {
            get => position;
            set => SetPropertyValue(nameof(Position), ref position, value);
        }

        [Association("Contact-DemoTask")]
        public XPCollection<DemoTask> Tasks => GetCollection<DemoTask>(nameof(Tasks));

        private Department department;
        [Association("Department-Contacts", typeof(Department)), ImmediatePostData]
        public Department Department
        {
            get { return department; }
            set
            {
                SetPropertyValue(nameof(Department), ref department, value);
                if (!IsLoading)
                {
                    Position = null;
                    if (Manager != null && Manager.Department != value) Manager = null;
                }
            }
        }

        private Contact manager;
        [DataSourceProperty("Department.Contacts", DataSourcePropertyIsNullMode.SelectAll)]
        [DataSourceCriteria("Position.Title = 'Manager' AND Oid != '@This.Oid'")]
        public Contact Manager
        {
            get => manager;
            set => SetPropertyValue(nameof(Manager), ref manager, value);
        }
    }
}