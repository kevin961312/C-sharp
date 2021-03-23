using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace MySolution.Module.BusinessObjects
{
    [DefaultClassOptions, ImageName("BO_SaleItem")]
    public class Payment : BaseObject
    {
        public Payment(Session session) : base(session) { }

        private double rate;
        public double Rate
        {
            get => rate;
            set
            {
                if (SetPropertyValue(nameof(Rate), ref rate, value))
                    OnChanged(nameof(Amount));
            }
        }

        private double hours;
        public double Hours
        {
            get => hours;
            set
            {
                if (SetPropertyValue(nameof(Hours), ref hours, value))
                    OnChanged(nameof(Amount));
            }
        }

        [PersistentAlias("Rate * Hours")]
        public double Amount
        {
            get
            {
                object tempObject = EvaluateAlias(nameof(Amount));
                if (tempObject != null) return (double)tempObject;
                else return 0;
            }
        }
    }
}