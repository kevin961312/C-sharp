using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using MySolution.Module.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
