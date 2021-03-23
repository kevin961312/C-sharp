using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;

namespace MySolution.Module.BusinessObjects
{
    [DefaultClassOptions]
    [System.ComponentModel.DefaultProperty(nameof(Title))]
    public class Position : BaseObject
    {
        public Position(Session session) : base(session) { }
        private string title;
        [RuleRequiredField(DefaultContexts.Save)]
        public string Title
        {
            get => title;
            set => SetPropertyValue(nameof(Title), ref title, value);
        }

        [Association("Departments-Positions")]
        public XPCollection<Department> Departments => GetCollection<Department>(nameof(Departments));
    }
}