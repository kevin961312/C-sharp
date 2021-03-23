using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;

namespace MySolution.Module.Controllers
{
    public partial class FindBySubjectController : ViewController
    {
        public FindBySubjectController() => InitializeComponent();
        protected override void OnActivated() => base.OnActivated();
        protected override void OnViewControlsCreated() => base.OnViewControlsCreated();
        protected override void OnDeactivated() => base.OnDeactivated();

        private void FindBySubjectAction_Execute(object sender, ParametrizedActionExecuteEventArgs e)
        {
            IObjectSpace objectSpace = Application.CreateObjectSpace(((ListView)View).ObjectTypeInfo.Type);
            string paramValue = e.ParameterCurrentValue as string;
            object obj = objectSpace.FindObject(((ListView)View).ObjectTypeInfo.Type, CriteriaOperator.Parse(string.Format("Contains([Subject], '{0}')", paramValue)));
            if (obj != null)
            {
                DetailView detailView = Application.CreateDetailView(objectSpace, obj);
                detailView.ViewEditMode = DevExpress.ExpressApp.Editors.ViewEditMode.Edit;
                e.ShowViewParameters.CreatedView = detailView;
            }
        }
    }
}