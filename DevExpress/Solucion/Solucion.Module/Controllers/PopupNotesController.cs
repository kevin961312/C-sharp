using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.Persistent.BaseImpl;
using MySolution.Module.BusinessObjects;
using System;

namespace MySolution.Module.Controllers
{

    public partial class PopupNotesController : ViewController
    {
        public PopupNotesController() => InitializeComponent();
        protected override void OnActivated() => base.OnActivated();
        protected override void OnViewControlsCreated() => base.OnViewControlsCreated();
        protected override void OnDeactivated() => base.OnDeactivated();

        private void ShowNotesAction_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            IObjectSpace objectSpace = Application.CreateObjectSpace(typeof(Note));
            string noteListViewId = Application.FindLookupListViewId(typeof(Note));
            CollectionSourceBase collectionSource = Application.CreateCollectionSource(objectSpace, typeof(Note), noteListViewId);
            e.View = Application.CreateListView(noteListViewId, collectionSource, true);
        }

        private void ShowNotesAction_Execute(object sender, PopupWindowShowActionExecuteEventArgs e)
        {
            DemoTask task = (DemoTask)View.CurrentObject;
            foreach (Note note in e.PopupWindowViewSelectedObjects)
            {
                if (!string.IsNullOrEmpty(task.Description))
                {
                    task.Description += Environment.NewLine;
                }
                task.Description += note.Text;
            }
            if (((DetailView)View).ViewEditMode == ViewEditMode.View)
            {
                View.ObjectSpace.CommitChanges();
            }
        }
    }
}