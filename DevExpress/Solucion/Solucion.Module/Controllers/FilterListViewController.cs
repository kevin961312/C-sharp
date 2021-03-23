using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using MySolution.Module.BusinessObjects;
using System;

namespace MySolution.Module.Controllers
{
    public partial class FilterListViewController : ViewController
    {
        public FilterListViewController() => InitializeComponent();

        protected override void OnActivated() => base.OnActivated();

        protected override void OnViewControlsCreated() => base.OnViewControlsCreated();

        protected override void OnDeactivated() => base.OnDeactivated();

        private void FilterListViewController_Activated(object sender, EventArgs e)
        {
            if ((View is ListView) & (View.ObjectTypeInfo.Type == typeof(Contact)))
            {
                ((ListView)View).CollectionSource.Criteria["Filter1"] = new BinaryOperator(
                   "Position.Title", "Developer", BinaryOperatorType.Equal);
            }
        }
    }
}