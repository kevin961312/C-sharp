using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;


namespace TABIndex.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Test_Person : BaseObject
    {
        public Test_Person(Session session) : base(session) { }

        private string name;
        public string Name
        {
            get => name;
            set => SetPropertyValue<string>("Name", ref name, value);
        }

        private string adress;
        public string Adress
        {
            get => adress;
            set => SetPropertyValue<string>("Adress", ref adress, value);
        }

        private int age;
        public int Age
        {
            get => age;
            set => SetPropertyValue<int>("Age", ref age, value);
        }

        private bool doYouhaveEmail;

        [ImmediatePostData(true)]
        public bool DoYouhaveEmail
        {
            get => doYouhaveEmail;
            set => SetPropertyValue<bool>("DoYouhaveEmail", ref doYouhaveEmail, value);
        }

        private string phoneNumber;

        public string PhoneNumber
        {
            get => phoneNumber;
            set => SetPropertyValue<string>("PhoneNumber", ref phoneNumber, value);
        }

        private string email;

        [Appearance("EmailDisabled", Enabled = false, Criteria = "DoYouhaveEmail = false")]
        public string Email
        {
            get => email;
            set => SetPropertyValue<string>("Email", ref email, value);
        }
    }
}
